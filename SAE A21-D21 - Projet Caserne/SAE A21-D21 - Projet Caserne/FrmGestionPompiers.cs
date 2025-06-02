using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class FrmGestionPompiers : Form
    {
        // Ouvre la connexion
        SQLiteConnection connec = Connexion.Connec;

        public FrmGestionPompiers()
        {
            InitializeComponent();

            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void FrmGestionPompiers_Load(object sender, EventArgs e)
        {

        }

        private void modeAdmin()
        {
            pcbAdmin.Image = Image.FromFile("img/admin_connecte.jpg");
            lblMode.Text = "Mode administrateur";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbAdmin_Click(object sender, EventArgs e)
        {
            FrmConnexionAdmin frmConnexionAdmin = new FrmConnexionAdmin();

            // Ouvre le form pour se connecté à un compte admin, sauvegarde le resultat dans une variable
            DialogResult result = frmConnexionAdmin.ShowDialog();

            // Si l'utilisateur s'est connecté à un compte admin, affiche les options admin sur le form
            if (result == DialogResult.OK)
            {
                modeAdmin();
                pcbAdmin.Enabled = false; // Plus cliquable
            }
        }
    }
}
