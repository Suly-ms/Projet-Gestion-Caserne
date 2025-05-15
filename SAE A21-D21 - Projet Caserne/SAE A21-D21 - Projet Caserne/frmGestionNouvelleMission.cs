using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Utilise les fichiers Connexion.cs et mesDatas.cs
using Pinpon;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class frmGestionNouvelleMission : Form
    {
        public frmGestionNouvelleMission()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Récupérer date aujourd'hui et l'attribuer à lblDateDelenchement
            DateTime dateAujourdhui = DateTime.Now;
            lblDateDelenchement.Text = lblDateDelenchement.Text + dateAujourdhui.ToString();

            // Récupérer les natures du sinitre et remplir la combobox attribuée

            cbxNatureSinistre.DataSource = MesDatas.DsGlobal.Tables["NatureSinistre"];
            cbxNatureSinistre.DisplayMember = "libelle";
            cbxNatureSinistre.ValueMember = "id";

            // Récupérer les natures du sinitre et remplir la combobox attribuée

            cbxCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cbxCaserne.DisplayMember = "nom";
            cbxCaserne.ValueMember = "id";

            // Récupérer le numéro de mission
            DataRow[] numeroMission = MesDatas.DsGlobal.Tables["Mission"].Select();
            lblNouvelleMission.Text = lblNouvelleMission.Text + (numeroMission.Length+1).ToString();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConstituer_Click(object sender, EventArgs e)
        {
            int natureSinistre = cbxNatureSinistre.SelectedIndex+1;
            DataRow[] typeVéhiculeDataRow = MesDatas.DsGlobal.Tables["Necessiter"].Select("idNatureSinistre = " + natureSinistre);
            List<string> listeTypes = new List<string>();
            foreach (DataRow r in typeVéhiculeDataRow)
            {
                listeTypes.Add("'" + r["codeTypeEngin"].ToString() + "'");
            }

            string typesPourInClause = string.Join(",", listeTypes);

            int caserne = cbxCaserne.SelectedIndex + 1;

            DataRow[] Vehicules = MesDatas.DsGlobal.Tables["Engin"].Select("idCaserne = " + caserne + " AND codeTypeEngin IN (" + typesPourInClause + ")" + " AND enMission = 0 AND enPanne = 0");

            DataTable tableAfficher = new DataTable();

            tableAfficher.Columns.Add("Type", typeof(string)); // Exemple de renommage
            tableAfficher.Columns.Add("Numéro", typeof(string)); // Exemple de renommage

            foreach (DataRow r_vehicules in Vehicules)
            {
                DataRow newRow = tableAfficher.NewRow();
                newRow["Type"] = r_vehicules["codeTypeEngin"];
                newRow["Numéro"] = r_vehicules["numero"];
                tableAfficher.Rows.Add(newRow);
            }

            dgvEnginsMobilises.DataSource = tableAfficher;


            // Sélection des pompiers disponibles
            DataRow[] pompiersTmp = MesDatas.DsGlobal.Tables["Pompier"].Select("enMission = 0 AND enConge = 0");

            // Sélection des affectations des pompiers pour la caserne spécifiée
            DataRow[] affectationPompiers = MesDatas.DsGlobal.Tables["Affectation"].Select("idCaserne = " + caserne);

            // Sélection des habilitations des pompiers
            DataRow[] habilitationPompiers = MesDatas.DsGlobal.Tables["Passer"].Select();

            // Sélection des habilitations nécessaires pour la mission
            DataRow[] habilitationMission = MesDatas.DsGlobal.Tables["Embarquer"].Select("codeTypeEngin IN (" + typesPourInClause + ")");

            List<DataRow> pompiers = new List<DataRow>();

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
            foreach (DataRow r_habilitations in habilitationMission)
            {
                habilisations.Add(Convert.ToInt32(r_habilitations["idHabilitation"]));
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

            tableAfficher = new DataTable();

            tableAfficher.Columns.Add("Grade", typeof(string)); // Exemple de renommage
            tableAfficher.Columns.Add("NomComplet", typeof(string)); // Exemple de renommage
            tableAfficher.Columns.Add("Matricule", typeof(string)); // Exemple de renommage
            tableAfficher.Columns.Add("Habilitations", typeof(string)); // Nouvelle colonne pour les habilitations

            foreach (DataRow r_pompiers in pompiers)
            {
                DataRow newRow = tableAfficher.NewRow();
                newRow["Grade"] = r_pompiers["codeGrade"];
                newRow["NomComplet"] = r_pompiers["nom"] + " " + r_pompiers["prenom"];
                newRow["Matricule"] = r_pompiers["matricule"];

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
                newRow["Habilitations"] = string.Join(", ", habilitationList);

                tableAfficher.Rows.Add(newRow);
            }

            // Mise à jour de la source de données du DataGridView
            dgvPompiersMobilises.DataSource = tableAfficher;


            // Mise à jour de la source de données du DataGridView
            dgvPompiersMobilises.DataSource = tableAfficher;


            gbxMobilisation.Visible = true;

            frmChoixVehiculesPompier monUC = new frmChoixVehiculesPompier();
            monUC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txbMotif.Text = "";
            txbCodePostal.Text = "";
            txbRue.Text = "";
            txbVille.Text = "";
        }
    }
}
