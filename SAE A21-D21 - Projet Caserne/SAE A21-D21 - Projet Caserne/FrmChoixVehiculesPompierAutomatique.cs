using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class FrmChoixVehiculesPompierAutomatique : Form
    {
        DataSet m_dataSet;
        public FrmChoixVehiculesPompierAutomatique(DataSet dataSet)
        {
            InitializeComponent();
            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            m_dataSet = dataSet;
        }

        private void FrmChoixVehiculesPompierAutomatique_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in m_dataSet.Tables["Pompier"].Rows)
            {
                string nom = row["Nom"].ToString();
                string prenom = row["Prenom"].ToString();
                string grade = row["codeGrade"].ToString();
                Image image = Image.FromFile("img/grades/" + grade + ".png");
                UC_ChoixPompierAutomatique ucChoixPompier = new UC_ChoixPompierAutomatique(image, grade, nom, prenom);
                ucChoixPompier.Dock = DockStyle.Top; // Permet de les empiler verticalement
                pnlPompier.Controls.Add(ucChoixPompier);
            }
            foreach (DataRow row in m_dataSet.Tables["Engin"].Rows)
            {
                string type = row["codeTypeEngin"].ToString();
                int numero = Convert.ToInt32(row["numero"]);
                int caserne = Convert.ToInt32(row["idCaserne"]);
                Image image = Image.FromFile("img/vehicules/" + type.ToLower() + ".jpg");
                UC_ChoixVehiculeAutomatique ucChoixVehicule = new UC_ChoixVehiculeAutomatique(image, type, numero, caserne);
                ucChoixVehicule.Dock = DockStyle.Top; // Permet de les empiler verticalement
                pnlVehicule.Controls.Add(ucChoixVehicule);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DataSet pompierVehiculeMission = m_dataSet;
            this.DialogResult = DialogResult.OK;
        }

        public DataSet DataSetMission
        {
            get { return m_dataSet; }
        }
    }
}
