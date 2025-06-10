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
using Pinpon;
using UserControlChoixPompier;
using UserControlChoixVehicules;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
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
            tablePompier.Columns.Add("vehicule", typeof(string));
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
                    choixVehicule.ChargerDonnees(Image.FromFile("img/vehicules/"+code.ToLower()+".jpg"), Convert.ToInt32(Vehicules[i]["numero"]), code, Convert.ToInt32(Vehicules[i]["idCaserne"]));

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

            // Récupérer la liste des pompiers déjà sélectionnés
            var pompiersDejaSelectionnes = new HashSet<string>();
            if (pompierVehiculeEnregistre.Tables.Contains("Pompiers"))
            {
                foreach (DataRow row in pompierVehiculeEnregistre.Tables["Pompiers"].Rows)
                {
                    pompiersDejaSelectionnes.Add($"{row["Nom"]}_{row["Prenom"]}");
                }
            }

            foreach (DataRow pompier in pompiers)
            {
                int matricule = Convert.ToInt32(pompier["matricule"]);

                // Vérifier si le pompier a l'habilitation requise
                bool aHabilitation = habilitationPompiers.Any(h =>
                    Convert.ToInt32(h["matriculePompier"]) == matricule &&
                    Convert.ToInt32(h["idHabilitation"]) == lastHabilitation
                );

                if (!aHabilitation)
                    continue;

                // Vérifier si le pompier est déjà sélectionné pour cette habilitation
                bool dejaSelectionne = false;
                if (pompierVehiculeEnregistre.Tables.Contains("Pompiers"))
                {
                    foreach (DataRow row in pompierVehiculeEnregistre.Tables["Pompiers"].Rows)
                    {
                        if (row != null &&
                            row["Nom"].ToString() == pompier["nom"].ToString() &&
                            row["Prenom"].ToString() == pompier["prenom"].ToString() &&
                            Convert.ToInt32(row["habilitation"]) == lastHabilitation)
                        {
                            dejaSelectionne = true;
                            break;
                        }
                    }
                }

                // Vérifier si le pompier est déjà sélectionné pour une autre habilitation
                string clePompier = $"{pompier["nom"]}_{pompier["prenom"]}";
                if (pompiersDejaSelectionnes.Contains(clePompier) && !dejaSelectionne)
                    continue;

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
                string vehicule = "";

                Color couleur = dejaSelectionne ? Color.Green : Color.Red;

                // Désactiver le bouton si le compteur est à 0 et le pompier n'est pas déjà sélectionné
                if (habilitationCompteurs.ContainsKey(lastHabilitation) && habilitationCompteurs[lastHabilitation] == 0 && !dejaSelectionne)
                {
                    choixPompier.desactiverButton();
                }

                choixPompier.ChargerDonnees(
                    Image.FromFile("img/grades/" + grade + ".png"),
                    grade, nom, prenom, couleur, vehicule
                );
                pnlChoixPompier.Controls.Add(choixPompier);

                top += 130;
            }
        }

        private List<int> getHabilitationVehicule(string typeVehicule)
        {
            List<int> habilitations = new List<int>();
            DataRow[] rows = MesDatas.DsGlobal.Tables["Embarquer"].Select($"codeTypeEngin = '{typeVehicule}'");
            foreach (DataRow row in rows)
            {
                habilitations.Add(Convert.ToInt32(row["idHabilitation"]));
            }
            return habilitations;
        }

        private void UcVehicule_VehiculeChoisi(object sender, VehiculeChoisiEventArgs e)
        {
            // Ajouter une ligne au DataSet
            pompierVehiculeEnregistre.Tables["Vehicules"].Rows.Add(e.Numero, e.Type, e.Caserne);
            chargerDataSetPompierVehiculeEnregistre();
            // Recalculer tous les boutons d’habilitation (comme dans la suppression)
            pnlChoixHabilitation.Controls.Clear();

            foreach (int habilitation in getHabilitationVehicule(e.Type))
            {
                if(habilitationCompteurs.ContainsKey(habilitation))
                {
                    habilitationCompteurs[habilitation] += Convert.ToInt32(MesDatas.DsGlobal.Tables["Embarquer"]
                    .Select($"codeTypeEngin = '{e.Type}' AND idHabilitation = {habilitation}")[0]["nombre"]);
                }
                else
                {
                    habilitationCompteurs[habilitation] = Convert.ToInt32(MesDatas.DsGlobal.Tables["Embarquer"]
                    .Select($"codeTypeEngin = '{e.Type}' AND idHabilitation = {habilitation}")[0]["nombre"]);
                }
                System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                button.Text += MesDatas.DsGlobal.Tables["Habilitation"]
                .Select("id = " + habilitation)[0]["libelle"].ToString() + $" x{habilitationCompteurs[habilitation]}";
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.Click += (s, e_) => afficherPompier(s);
                button.AutoSize = true;
                button.Dock = DockStyle.Top;
                button.Tag = habilitation;
                pnlChoixHabilitation.Controls.Add(button);
            }
        }

        private void UcVehicule_VehiculeNonChoisi(object sender, VehiculeNonChoisiEventArgs e)
        {
            // Supprimer le véhicule du DataSet
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

            // Supprimer les pompiers associés aux habilitations de ce véhicule
            List<int> habilitations = getHabilitationVehicule(e.Type);
            foreach (int habilitation in habilitations)
            {
                foreach (DataRow row in pompierVehiculeEnregistre.Tables["Pompiers"].Rows.Cast<DataRow>().ToList())
                {
                    if ((int)row["habilitation"] == habilitation)
                    {
                        row.Delete();
                    }
                }
            }
            pompierVehiculeEnregistre.Tables["Pompiers"].AcceptChanges();

            chargerDataSetPompierVehiculeEnregistre();

            // Recalculer tous les boutons d’habilitation (comme dans la suppression)
            // Recalculer tous les compteurs d’habilitation à partir des véhicules restants
            habilitationCompteurs.Clear();

            foreach (DataRow vehicule in pompierVehiculeEnregistre.Tables["Vehicules"].Rows)
            {
                string type = vehicule["Type"].ToString();
                foreach (int habilitation in getHabilitationVehicule(type))
                {
                    int nombre = Convert.ToInt32(MesDatas.DsGlobal.Tables["Embarquer"]
                        .Select($"codeTypeEngin = '{type}' AND idHabilitation = {habilitation}")[0]["nombre"]);
                    if (habilitationCompteurs.ContainsKey(habilitation))
                        habilitationCompteurs[habilitation] += nombre;
                    else
                        habilitationCompteurs[habilitation] = nombre;
                }
            }

            // Mettre à jour les boutons d’habilitation
            pnlChoixHabilitation.Controls.Clear();
            foreach (var kvp in habilitationCompteurs)
            {
                int habilitation = kvp.Key;
                int compteur = kvp.Value;
                System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                button.Text = MesDatas.DsGlobal.Tables["Habilitation"]
                    .Select("id = " + habilitation)[0]["libelle"].ToString() + $" x{compteur}";
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                button.Click += (s, e_) => afficherPompier(s);
                button.AutoSize = true;
                button.Dock = DockStyle.Top;
                button.Tag = habilitation;
                pnlChoixHabilitation.Controls.Add(button);
            }

            mettreAJourAffichagePompier();
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
