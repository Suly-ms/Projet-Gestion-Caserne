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

            MessageBox.Show(typesPourInClause);

            int caserne = cbxCaserne.SelectedIndex + 1;

            DataRow[] Vehicules = MesDatas.DsGlobal.Tables["Engin"].Select("idCaserne = " + caserne + " AND codeTypeEngin IN (" + typesPourInClause + ")" + " AND enMission = 0 AND enPanne = 0");
            dgvEnginsMobilises.DataSource = Vehicules.CopyToDataTable();

            gbxMobilisation.Visible = true;
        }
    }
}
