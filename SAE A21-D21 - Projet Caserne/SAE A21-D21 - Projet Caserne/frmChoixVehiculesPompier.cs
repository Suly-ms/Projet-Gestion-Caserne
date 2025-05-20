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
using UserControlChoixVehicules;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Pinpon;
using UserControlChoixPompier;

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
                    habilisations.Add(Convert.ToInt32(r_habilitations["idHabilitation"]));
                    DataRow[] habilitation = MesDatas.DsGlobal.Tables["Habilitation"].Select("id = " + r_habilitations["idHabilitation"]);
                    var boutonHabilitation = new System.Windows.Forms.Button
                    {
                        Top = top,
                        Left = left,
                        Text = habilitation[0]["libelle"].ToString(),
                    };
                    boutonHabilitation.Click += new System.EventHandler(afficherPompier);
                    pnlChoixHabilitation.Controls.Add(boutonHabilitation);
                    top += 50;
                }

                // Récupérer tous les matricules des pompiers qui ont les bonnes habilitations pour la mission
                List<int> matriculeBonneHabilitations = new List<int>();
                foreach (DataRow r_habilitationPompiers in habilitationPompiers)
                {
                    if (habilisations.Contains(Convert.ToInt32(r_habilitationPompiers["idHabilitation"])))
                    {
                        matriculeBonneHabilitations.Add(Convert.ToInt32(r_habilitationPompiers["matriculePompier"]));
                    }
                }

                List<DataRow> tmp = new List<DataRow>();
                foreach (DataRow r_pompiers in pompiers)
                {
                    if (matriculeBonneHabilitations.Contains(Convert.ToInt32(r_pompiers["matricule"])))
                    {
                        tmp.Add(r_pompiers);
                    }
                }
                pompiers = tmp;

                String habilitationPompier;
                foreach (DataRow r_pompiers in pompiers)
                {
                    // Récupérer les habilitations pour le pompier actuel
                    List<string> habilitationList = new List<string>();
                    foreach (DataRow r_habilitationPompiers in habilitationPompiers)
                    {
                        if (Convert.ToInt32(r_habilitationPompiers["matriculePompier"]) == Convert.ToInt32(r_pompiers["matricule"]))
                        {
                            habilitationList.Add(r_habilitationPompiers["idHabilitation"].ToString());
                        }
                    }

                    // Ajouter les habilitations à la nouvelle ligne
                    habilitationPompier = string.Join(", ", habilitationList);
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
            for (int i = 0; i < pompiers.Count; i++)
            {
                if (MesDatas.DsGlobal.Tables["Passer"].Select("idHabilitation = " + ) pompiers[i]["matricule"])
                {
                    var choixPompier = new UCChoixPompier
                    {
                        Top = top,
                        Left = left
                    };

                    String grade = pompiers[i]["codeGrade"].ToString();
                    String nom = pompiers[i]["nom"].ToString() + " " + pompiers[i]["prenom"].ToString();

                    choixPompier.ChargerDonnees(Image.FromFile("img/" + grade + ".png"), grade, nom);

                    pnlChoixPompier.Controls.Add(choixPompier);
                    top += 130;
                }
            }
        }
    }
}
