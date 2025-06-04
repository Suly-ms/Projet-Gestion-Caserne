using Pinpon;
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

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class FrmConnexionAdmin : Form
    {
        // Ouvre la connexion
        SQLiteConnection connec = Connexion.Connec;

        public FrmConnexionAdmin()
        {
            InitializeComponent();

            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private bool estAdmin(string login, string mdp)
        {
            string requete = $"select * from Admin";
            SQLiteDataAdapter da = new SQLiteDataAdapter(requete, connec);
            DataTable dt = new DataTable();

            // Remplit le DataTable avec les données
            da.Fill(dt);

            // Recherche dans tout le dataTable si le user saisis en parametre est admin
            foreach (DataRow row in dt.Rows)
            {
                if (row["login"].ToString().ToLower() == login.ToLower() && row["mdp"].ToString() == mdp)
                {
                    return true; // Renvoie vrai si trouvé
                }
            }
            return false; // Sinon faux
        }

        private void FrmConnexionAdmin_Load(object sender, EventArgs e)
        {
            txbMdp.UseSystemPasswordChar = true;
        }

        private void pcbAfficherMdp_MouseDown(object sender, MouseEventArgs e)
        {
            txbMdp.UseSystemPasswordChar = false;
        }

        private void pcbAfficherMdp_MouseUp(object sender, MouseEventArgs e)
        {
            txbMdp.UseSystemPasswordChar = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string login = txbLogin.Text;
            string mdp = txbMdp.Text;

            if (estAdmin(login, mdp)) 
            {
                MessageBox.Show($"Vous vous êtes bien connecté en tant que {login}");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show($"Le login ou le mot de passe est incorrect");
                txbMdp.Clear();
            }
        }

        public string LoginAdmin
        {
            get { return txbLogin.Text; }
        }

        private void txbMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnValider_Click(sender, EventArgs.Empty);
            }

        }
    }
}
