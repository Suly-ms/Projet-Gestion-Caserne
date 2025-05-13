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
using Pinpon;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class MainFormulaire : Form
    {
        public MainFormulaire()
        {
            InitializeComponent();
        }
        // Ouverture de la connection vers la base de donnée
        SQLiteConnection connec = Connexion.Connec;
        private void MainFormulaire_Load(object sender, EventArgs e)
        {
            DataTable schemaTable = connec.GetSchema("Tables");

            //dataGridView1.DataSource = schemaTable;
            string requete;
            foreach (DataRow ligne in schemaTable.Rows)
            {
                requete = "select * from " + ligne[2].ToString();

                SQLiteDataAdapter da = new SQLiteDataAdapter(requete, connec);

                da.Fill(MesDatas.DsGlobal, ligne[2].ToString());
            }
            Connexion.FermerConnexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGestionNouvelleMission NouvelleMission = new frmGestionNouvelleMission(); // Crée une instance
            NouvelleMission.Show();
        }
    }
}
