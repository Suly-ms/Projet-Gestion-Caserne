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
using static UserControlChoixVehicules.UCChoixVehicule;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class frmChoixVehiculesPompier : Form
    {
        private int m_natureSinistre;
        private int m_caserne;
        private List<DataRow> pompiers = new List<DataRow>();
        private DataRow[] pompiersTmp;
        private DataRow[] affectationPompiers;
        private DataRow[] habilitationPompiers;
        private DataRow[] habilitationMission;
        private DataSet pompierVehiculeEnregistre = new DataSet();
        public frmChoixVehiculesPompier()
        {
            InitializeComponent();
        }

        public frmChoixVehiculesPompier(int natureSinitre, int caserne)
        {
            InitializeComponent();
            m_natureSinistre = natureSinitre;
            m_caserne = caserne;
        }

        private void frmChoixVehiculesPompier_Load(object sender, EventArgs e)
        {
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

            DataTable table = new DataTable("Vehicules");
            table.Columns.Add("Numero", typeof(int));
            table.Columns.Add("Type", typeof(string));
            pompierVehiculeEnregistre.Tables.Add(table);

            int top = 10;
            int left = 20;

            try
            {
                int natureSinistre = m_natureSinistre + 1;
                DataRow[] typeVéhiculeDataRow = MesDatas.DsGlobal.Tables["Necessiter"].Select("idNatureSinistre = " + natureSinistre);
                List<string> listeTypes = new List<string>();
                foreach (DataRow r in typeVéhiculeDataRow)
                {
                    listeTypes.Add("'" + r["codeTypeEngin"].ToString() + "'");
                }

                string typesPourInClause = string.Join(",", listeTypes);

                int caserne = m_caserne + 1;

                DataRow[] Vehicules = MesDatas.DsGlobal.Tables["Engin"].Select("idCaserne = " + caserne + " AND codeTypeEngin IN (" + typesPourInClause + ")" + " AND enMission = 0 AND enPanne = 0");

                for (int i = 0; i < Vehicules.Length; i++)
                {
                    var choixVehicule = new UCChoixVehicule
                    {
                        Top = top,
                        Left = left
                    };

                    String code = Vehicules[i]["codeTypeEngin"].ToString();


                    choixVehicule.VehiculeChoisi += UcVehicule_VehiculeChoisi;
                    choixVehicule.VehiculeNonChoisi += UcVehicule_VehiculeNonChoisi;
                    choixVehicule.ChargerDonnees(imagesVehicules[code], Convert.ToInt32(Vehicules[i]["numero"]), code);

                    pnlChoixVehicule.Controls.Add(choixVehicule);
                    top += 110;
                }

                // Sélection des pompiers disponibles
                pompiersTmp = MesDatas.DsGlobal.Tables["Pompier"].Select("enMission = 0 AND enConge = 0");
                
                // Sélection des affectations des pompiers pour la caserne spécifiée
                affectationPompiers = MesDatas.DsGlobal.Tables["Affectation"].Select("idCaserne = " + caserne);
                
                // Sélection des habilitations des pompiers
                habilitationPompiers = MesDatas.DsGlobal.Tables["Passer"].Select();
                
                // Sélection des habilitations nécessaires pour la mission
                habilitationMission = MesDatas.DsGlobal.Tables["Embarquer"].Select("codeTypeEngin IN (" + typesPourInClause + ")");

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

                // Récupérer toutes les habilitations pour la mission
                List<int> habilisations = new List<int>();
                top = 10;
                foreach (DataRow r_habilitations in habilitationMission)
                {
                    int idHab = Convert.ToInt32(r_habilitations["idHabilitation"]);
                    DataRow[] habilitation = MesDatas.DsGlobal.Tables["Habilitation"].Select("id = " + idHab);

                    var boutonHabilitation = new System.Windows.Forms.Button
                    {
                        Top = top,
                        Left = left,
                        Text = habilitation[0]["libelle"].ToString(),
                        Tag = idHab // Stocker l'id de l'habilitation dans le bouton
                    };

                    boutonHabilitation.Click += new System.EventHandler(afficherPompier);
                    pnlChoixHabilitation.Controls.Add(boutonHabilitation);
                    top += 50;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex);
                return;
            }
        }

        private void afficherPompier(object sender, EventArgs e)
        {
            pnlChoixPompier.Controls.Clear();
            int top = 10;
            int left = 20;

            System.Windows.Forms.Button bouton = sender as System.Windows.Forms.Button;

            int idHabilitationCliquee = (int)bouton.Tag;

            foreach (DataRow pompier in pompiers)
            {
                int matricule = Convert.ToInt32(pompier["matricule"]);

                // Vérifier si ce pompier a cette habilitation
                bool aHabilitation = habilitationPompiers.Any(h =>
                    Convert.ToInt32(h["matriculePompier"]) == matricule &&
                    Convert.ToInt32(h["idHabilitation"]) == idHabilitationCliquee
                );

                if (aHabilitation)
                {
                    var choixPompier = new UCChoixPompier
                    {
                        Top = top,
                        Left = left
                    };

                    String grade = pompier["codeGrade"].ToString();
                    String nom = pompier["nom"].ToString() + " " + pompier["prenom"].ToString();

                    choixPompier.ChargerDonnees(Image.FromFile("img/" + grade + ".png"), grade, nom);

                    pnlChoixPompier.Controls.Add(choixPompier);
                    top += 130;
                }
            }
        }

        private void UcVehicule_VehiculeChoisi(object sender, VehiculeChoisiEventArgs e)
        {
            // Ajouter une ligne au DataSet
            pompierVehiculeEnregistre.Tables["Vehicules"].Rows.Add(e.Numero, e.Type);
            chargerDataSetPompierVehiculeEnregistre();
        }

        private void UcVehicule_VehiculeNonChoisi(object sender, VehiculeNonChoisiEventArgs e)
        {
            // Ajouter une ligne au DataSet
            foreach (DataRow row in pompierVehiculeEnregistre.Tables["Vehicules"].Rows.Cast<DataRow>().ToList())
            {
                if ((int)row["Numero"] == e.Numero && row["Type"].ToString() == e.Type)
                {
                    row.Delete();
                }
            }
            pompierVehiculeEnregistre.Tables["Vehicules"].AcceptChanges();
            chargerDataSetPompierVehiculeEnregistre();
        }

        private void chargerDataSetPompierVehiculeEnregistre()
        {
            pnlPompierEnregistre.Controls.Clear();
            pnlVehiculeEnregistre.Controls.Clear();
            int top = 20;
            int left = 5;
            foreach(DataRow row in pompierVehiculeEnregistre.Tables["Vehicules"].Rows.Cast<DataRow>().ToList())
            {
                Label label = new Label();
                label.Text = row["Type"].ToString() + row["Numero"].ToString();
                label.Top = top;
                label.Left = left;
                label.Width = 55;
                label.BackColor = Color.Yellow;
                label.AutoSize = false;
                pnlVehiculeEnregistre.Controls.Add(label);

                left += 75;
            }
        }
    }
}
