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
using UserControlChoixVehicules;
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
            frmChoixVehiculesPompier monUC = new frmChoixVehiculesPompier(cbxNatureSinistre.SelectedIndex, cbxCaserne.SelectedIndex);
            monUC.ShowDialog();
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
