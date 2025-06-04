using Pinpon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlChoixPompier;
using UserControlChoixVehicules;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static UserControlChoixPompier.UC_ChoixPompier;
using static UserControlChoixVehicules.UC_ChoixVehicule;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class FrmChoixVehiculesPompier : Form
    {
        private int m_natureSinistre;
        private int m_caserne;
        private List<DataRow> pompiers = new List<DataRow>();
        private DataRow[] pompiersTmp;
        private DataRow[] affectationPompiers;
        private DataRow[] habilitationPompiers;
        private List<DataRow> habilitationMission = new List<DataRow>();
        private int lastHabilitation;
        private DataSet pompierVehiculeEnregistre = new DataSet();
        private Dictionary<int, int> habilitationCompteurs = new Dictionary<int, int>();
        public FrmChoixVehiculesPompier()
        {
            InitializeComponent();
            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public FrmChoixVehiculesPompier(int natureSinitre, int caserne)
        {
            InitializeComponent();
            m_natureSinistre = natureSinitre;
            m_caserne = caserne;
        }

        private void frmChoixVehiculesPompier_Load(object sender, EventArgs e)
        {
            // Dictionnaire pour les images des véhicules
            Dictionary<string, Image> imagesVehicules = new Dictionary<string, Image>()
            {
                { "BRS", Image.FromFile("img/brs.jpg") },
                { "CCF", Image.FromFile("img/ccf.jpg") },
                { "EPA", Image.FromFile("img/epa.jpg") },
                { "FPT", Image.FromFile("img/fpt.jpg") },
                { "VCYN", Image.FromFile("img/vcyn.jpg") },
                { "VID", Image.FromFile("img/vid.jpg") },
                { "VPC", Image.FromFile("img/vpc.jpg") },
                { "VSAV", Image.FromFile("img/vsav.jpg") },
                { "VSS", Image.FromFile("img/vss.jpg") },
                { "VSR", Image.FromFile("img/vsr.jpg") }
            };

            // Table pour enregistrer les pompiers et véhicules choisis
            DataTable tableVehicule = new DataTable("Vehicules");
            tableVehicule.Columns.Add("Numero", typeof(int));
            tableVehicule.Columns.Add("Type", typeof(string));
            tableVehicule.Columns.Add("Caserne", typeof(int));
            pompierVehiculeEnregistre.Tables.Add(tableVehicule);

            DataTable tablePompier = new DataTable("Pompiers");
            tablePompier.Columns.Add("Nom", typeof(string));
            tablePompier.Columns.Add("Prenom", typeof(string));
            tablePompier.Columns.Add("Grade", typeof(string));
            tablePompier.Columns.Add("matricule", typeof(int));
            tablePompier.Columns.Add("habilitation", typeof(int));
            pompierVehiculeEnregistre.Tables.Add(tablePompier);

            int top = 10;
            int left = 20;

            try
            {
                int caserne = m_caserne;
                // Récupérer les Types de véhicules en fonction de l'ID du sinistre
                int natureSinistre = m_natureSinistre;
                DataRow[] typeVéhiculeDataRow = MesDatas.DsGlobal.Tables["Necessiter"].Select("idNatureSinistre = " + natureSinistre);
                List<string> listeTypes = new List<string>();
                foreach (DataRow r in typeVéhiculeDataRow)
                {
                    listeTypes.Add("'" + r["codeTypeEngin"].ToString() + "'");
                }

                // Récupérer les véhicules en fonction de la caserne choisit, des bon véhicules pour la mision et de savoir si ils sont en mission et si ils sont en panne
                List<DataRow> Vehicules = new List<DataRow>();
                foreach (string t in listeTypes)
                {
                    DataRow[] caserneTmp = MesDatas.DsGlobal.Tables["Caserne"].Select();
                    DataRow[] vehiculeTmp = MesDatas.DsGlobal.Tables["Engin"].Select($@"idCaserne = " + caserne + "AND codeTypeEngin = " + t + " AND enMission = 0 AND enPanne = 0");
                    if (vehiculeTmp.Length == 0)
                    {
                        for (int i = 0; i < caserneTmp.Count(); i++)
                        {
                            vehiculeTmp = MesDatas.DsGlobal.Tables["Engin"].Select($@"idCaserne = " + i + "AND codeTypeEngin = " + t + " AND enMission = 0 AND enPanne = 0");
                            if (vehiculeTmp.Length > 0)
                            {
                                Vehicules.AddRange(vehiculeTmp);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Vehicules.AddRange(vehiculeTmp);
                    }
                }
                // Ajouter dans le panel du choix des véhicules, les UC pour chosiir les véhicules
                for (int i = 0; i < Vehicules.Count; i++)
                {
                    UC_ChoixVehicule choixVehicule = new UC_ChoixVehicule
                    {
                        Top = top,
                        Left = left
                    };

                    String code = Vehicules[i]["codeTypeEngin"].ToString();


                    choixVehicule.VehiculeChoisi += UcVehicule_VehiculeChoisi;
                    choixVehicule.VehiculeNonChoisi += UcVehicule_VehiculeNonChoisi;
                    choixVehicule.ChargerDonnees(imagesVehicules[code], Convert.ToInt32(Vehicules[i]["numero"]), code, Convert.ToInt32(Vehicules[i]["idCaserne"]));

                    pnlChoixVehicule.Controls.Add(choixVehicule);
                    top += 110;
                }

                // Sélection des pompiers disponibles
                pompiersTmp = MesDatas.DsGlobal.Tables["Pompier"].Select("enMission = 0 AND enConge = 0");
                
                // Sélection des affectations des pompiers pour la caserne spécifiée
                affectationPompiers = MesDatas.DsGlobal.Tables["Affectation"].Select("idCaserne = " + caserne + " AND dateFin IS NULL");
                
                // Sélection des habilitations des pompiers
                habilitationPompiers = MesDatas.DsGlobal.Tables["Passer"].Select();

                // Sélection des habilitations nécessaires pour la mission
                foreach (string t in listeTypes)
                {
                    foreach(DataRow dr in MesDatas.DsGlobal.Tables["Embarquer"].Select("codeTypeEngin = " + t))
                    {
                        habilitationMission.Add(dr);
                    }
                }
                

                // Récupérer les pompiers de la caserne choisie
                foreach (DataRow r in pompiersTmp)
                {
                    int matricule = Convert.ToInt32(r["matricule"]);
                    foreach (DataRow r_affectation in affectationPompiers)
                    {
                        if (Convert.ToInt32(r_affectation["matriculePompier"]) == matricule)
                        {
                            pompiers.Add(r);
                            break; // Sortir de la boucle une fois le pompier trouvé
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex);
                return;
            }
        }

        private void AjouterOuMettreAJourBoutonHabilitation(int idHabilitation)
        {
            string nomHabilitation = MesDatas.DsGlobal.Tables["Habilitation"]
                .Select("id = " + idHabilitation)[0]["libelle"].ToString();

            int besoinTotal = 0;

            // Étape 1 : Calculer le besoin total pour tous les véhicules
            foreach (DataRow vehicule in pompierVehiculeEnregistre.Tables["Vehicules"].Rows)
            {
                string typeVehicule = vehicule["Type"].ToString();
                DataRow[] habilitations = MesDatas.DsGlobal.Tables["Embarquer"]
                    .Select($"codeTypeEngin = '{typeVehicule}' AND idHabilitation = {idHabilitation}");

                foreach (DataRow h in habilitations)
                {
                    besoinTotal += Convert.ToInt32(h["nombre"]);
                }
            }

            // Étape 2 : Calculer combien de pompiers déjà affectés ont cette habilitation
            int dejaAttribue = 0;
            if (pompierVehiculeEnregistre.Tables.Contains("Pompiers"))
            {
                foreach (DataRow pompier in pompierVehiculeEnregistre.Tables["Pompiers"].Rows)
                {
                    if (Convert.ToInt32(pompier["habilitation"]) == idHabilitation)
                    {
                        dejaAttribue++;
                    }
                }
            }

            // Étape 3 : Calcul du reste à affecter
            int restant = besoinTotal - dejaAttribue;

            // Mettre à jour le dictionnaire avec le nombre restant réel
            habilitationCompteurs[idHabilitation] = restant;

            // Si le bouton existe déjà, on le met à jour
            foreach (Control ctrl in pnlChoixHabilitation.Controls)
            {
                if (ctrl is System.Windows.Forms.Button btn && (int)btn.Tag == idHabilitation)
                {
                    btn.Text = $"{nomHabilitation} x{restant}";
                    return;
                }
            }

            // Sinon, on le crée
            System.Windows.Forms.Button bouton = new System.Windows.Forms.Button
            {
                Text = $"{nomHabilitation} x{restant}",
                Tag = idHabilitation,
                AutoSize = true,
                Left = 20
            };

            if (pnlChoixHabilitation.Controls.Count == 0)
            {
                bouton.Top = 20;
            }
            else
            {
                bouton.Top = (pnlChoixHabilitation.Controls.Count * 50) + 20;
            }
            bouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bouton.Click += (s, e) => afficherPompier(s);
            pnlChoixHabilitation.Controls.Add(bouton);
        }

        private void afficherPompier(object sender)
        {
            System.Windows.Forms.Button bouton = sender as System.Windows.Forms.Button;
            lastHabilitation = Convert.ToInt32(bouton.Tag);
                        
            int idHabilitationCliquee = Convert.ToInt32(bouton.Tag);
            mettreAJourAffichagePompier();
        }

        private void mettreAJourAffichagePompier()
        {
            pnlChoixPompier.Controls.Clear();
            int top = 10;
            int left = 20;
            foreach (DataRow pompier in pompiers)
            {
                int matricule = Convert.ToInt32(pompier["matricule"]);

                // Vérifier si le pompier a l'habilitation
                bool aHabilitation = habilitationPompiers.Any(h =>
                    Convert.ToInt32(h["matriculePompier"]) == matricule &&
                    Convert.ToInt32(h["idHabilitation"]) == lastHabilitation
                );

                if (!aHabilitation)
                    continue;

                // Vérifier si la table "Pompiers" existe
                bool present = false;
                bool afficher_vert = false;
                if (pompierVehiculeEnregistre.Tables.Contains("Pompiers"))
                {
                    foreach (DataRow row in pompierVehiculeEnregistre.Tables["Pompiers"].Rows)
                    {
                        if (!(row == null)) { 
                            if (row["Nom"].ToString() == pompier["nom"].ToString() && row["Prenom"].ToString() == pompier["prenom"].ToString() && Convert.ToInt32(row["habilitation"]) != lastHabilitation)
                            {
                                present = true;
                            }
                            else if (row["Nom"].ToString() == pompier["nom"].ToString() && row["Prenom"].ToString() == pompier["prenom"].ToString() && Convert.ToInt32(row["habilitation"]) == lastHabilitation)
                            {
                                afficher_vert = true;
                            }
                        }
                    }
                }

                if (!present)
                {
                    // Création et configuration du contrôle
                    UC_ChoixPompier choixPompier = new UC_ChoixPompier
                    {
                        Top = top,
                        Left = left
                    };

                    choixPompier.PompierChoisi += UcPompier_PompierChoisi;
                    choixPompier.PompierNonChoisi += UcPompier_PompierNonChoisi;

                    string grade = pompier["codeGrade"].ToString();
                    string nom = pompier["nom"].ToString();
                    string prenom = pompier["prenom"].ToString();

                    Color couleur = afficher_vert ? Color.Green : Color.Red;

                    if (habilitationCompteurs[lastHabilitation] == 0 && couleur == Color.Red)
                    {
                        choixPompier.desactiverButton();
                    }

                    choixPompier.ChargerDonnees(Image.FromFile("img/" + grade + ".png"), grade, nom, prenom, couleur);
                    pnlChoixPompier.Controls.Add(choixPompier);

                    top += 130;
                }
            }
        }

        private void UcVehicule_VehiculeChoisi(object sender, VehiculeChoisiEventArgs e)
        {
            // Ajouter une ligne au DataSet
            pompierVehiculeEnregistre.Tables["Vehicules"].Rows.Add(e.Numero, e.Type, e.Caserne);
            chargerDataSetPompierVehiculeEnregistre();
            // Recalculer tous les boutons d’habilitation (comme dans la suppression)
            pnlChoixHabilitation.Controls.Clear();

            var habilitations = MesDatas.DsGlobal.Tables["Habilitation"].Select();
            foreach (DataRow h in habilitations)
            {
                AjouterOuMettreAJourBoutonHabilitation(Convert.ToInt32(h["id"]));
            }
        }

        private void UcVehicule_VehiculeNonChoisi(object sender, VehiculeNonChoisiEventArgs e)
        {
            for (int i = pompierVehiculeEnregistre.Tables["Vehicules"].Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = pompierVehiculeEnregistre.Tables["Vehicules"].Rows[i];
                if (row["Numero"].ToString() == e.Numero.ToString() &&
                    row["Type"].ToString() == e.Type.ToString() &&
                    row["Caserne"].ToString() == e.Caserne.ToString())
                {
                    row.Delete();
                }
            }

            chargerDataSetPompierVehiculeEnregistre();
            // Recalculer tous les boutons d’habilitation (comme dans la suppression)
            pnlChoixHabilitation.Controls.Clear();

            var habilitations = MesDatas.DsGlobal.Tables["Habilitation"].Select();
            foreach (DataRow h in habilitations)
            {
                AjouterOuMettreAJourBoutonHabilitation(Convert.ToInt32(h["id"]));
            }
        }



        private void UcPompier_PompierChoisi(object sender, PompierChoisiEventArgs e)
        {
            DataRow[] Pompier = MesDatas.DsGlobal.Tables["Pompier"].Select(
                $"nom = '{e.Nom.Replace("'", "''")}' AND prenom = '{e.Prenom.Replace("'", "''")}'"
            );

            pompierVehiculeEnregistre.Tables["Pompiers"].Rows.Add(e.Nom, e.Prenom, e.Grade, Pompier[0]["matricule"], lastHabilitation);

            // Décrémenter le compteur
            if (habilitationCompteurs.ContainsKey(lastHabilitation))
            {
                habilitationCompteurs[lastHabilitation]--;

                // Mettre à jour le texte du bouton
                foreach (Control ctrl in pnlChoixHabilitation.Controls)
                {
                    if (ctrl is System.Windows.Forms.Button btn && (int)btn.Tag == lastHabilitation)
                    {
                        string nomHabilitation = btn.Text.Split('x')[0].Trim();
                        btn.Text = $"{nomHabilitation} x{habilitationCompteurs[lastHabilitation]}";
                        break;
                    }
                }
            }

            if (habilitationCompteurs[lastHabilitation] == 0)
            {
                mettreAJourAffichagePompier();
            }
            chargerDataSetPompierVehiculeEnregistre();
        }


        private void UcPompier_PompierNonChoisi(object sender, PompierNonChoisiEventArgs e)
        {
            foreach (DataRow row in pompierVehiculeEnregistre.Tables["Pompiers"].Rows.Cast<DataRow>().ToList())
            {
                if (row["Nom"].ToString() == e.Nom && row["Prenom"].ToString() == e.Prenom)
                {
                    int idHabilitation = (int)row["habilitation"];

                    row.Delete();

                    // Ré-incrémenter le compteur
                    if (habilitationCompteurs.ContainsKey(idHabilitation))
                    {
                        habilitationCompteurs[idHabilitation]++;

                        foreach (Control ctrl in pnlChoixHabilitation.Controls)
                        {
                            if (ctrl is System.Windows.Forms.Button btn && (int)btn.Tag == idHabilitation)
                            {
                                string nomHabilitation = btn.Text.Split('x')[0].Trim();
                                btn.Text = $"{nomHabilitation} x{habilitationCompteurs[idHabilitation]}";
                                break;
                            }
                        }
                    }
                }
            }

            if (habilitationCompteurs[lastHabilitation] == 1)
            {
                mettreAJourAffichagePompier();
            }

            pompierVehiculeEnregistre.Tables["Pompiers"].AcceptChanges();
            chargerDataSetPompierVehiculeEnregistre();
        }


        private void chargerDataSetPompierVehiculeEnregistre()
        {
            pnlPompierEnregistre.Controls.Clear();
            pnlVehiculeEnregistre.Controls.Clear();
            int top = 23;
            int left = 5;
            Label labelTxtVehicules = new Label();
            labelTxtVehicules.Text = "Véhicule(s) Enregistrés :";
            labelTxtVehicules.Top = top;
            labelTxtVehicules.Left = left;
            labelTxtVehicules.Width = 55;
            labelTxtVehicules.AutoSize = true;
            labelTxtVehicules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pnlVehiculeEnregistre.Controls.Add(labelTxtVehicules);

            Label labelTxtPompier = new Label();
            labelTxtPompier.Text = "Pompier(s) Enregistrés :";
            labelTxtPompier.Top = top;
            labelTxtPompier.Left = left;
            labelTxtPompier.Width = 55;
            labelTxtPompier.AutoSize = true;
            labelTxtPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pnlPompierEnregistre.Controls.Add(labelTxtPompier);

            foreach (DataRow row in pompierVehiculeEnregistre.Tables["Vehicules"].Rows.Cast<DataRow>().ToList())
            {
                Label label = new Label();
                label.Text = row["Type"].ToString() + row["Numero"].ToString();
                label.Top = top;
                label.Left = left+210;
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnlVehiculeEnregistre.Controls.Add(label);

                left += label.Width + 10;
            }

            left = 5;
            foreach (DataRow row in pompierVehiculeEnregistre.Tables["Pompiers"].Rows.Cast<DataRow>().ToList())
            {
                Label label = new Label();
                label.Text = row["Grade"].ToString() + " " + row["Nom"].ToString() + " " + row["Prenom"].ToString();
                label.Top = top;
                label.Left = left+210;
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pnlPompierEnregistre.Controls.Add(label);

                left += label.Width + 10;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (habilitationCompteurs.Values.All(val => val == 0))
            {
                DataSet pompierVehiculeMission = pompierVehiculeEnregistre;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblPasAssezDePompier.Visible = true;
            }
        }

        public DataSet DataSetMission
        {
            get { return pompierVehiculeEnregistre; }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
