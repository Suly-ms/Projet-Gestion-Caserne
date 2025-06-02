using Org.BouncyCastle.Asn1.Ocsp;
using Pinpon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_RecapMission;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class FrmGestionPompiers : Form
    {
        // Ouvre la connexion
        SQLiteConnection connec = Connexion.Connec;

        // Variable qui empeche l'appel de la methode cmbCaserne_SelectedIndexChanged avant que la comboBox est chartgé complètement (ca provoquait des bugs)
        bool caserneCharge = false;

        private bool m_admin = false;

        public FrmGestionPompiers()
        {
            InitializeComponent();

            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Remplit la comboBox avec toutes les casernes
            cmbCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cmbCaserne.DisplayMember = "nom";
            cmbCaserne.ValueMember = "id";
            cmbCaserne.SelectedIndex = -1;
            caserneCharge = true;
        }

        private void FrmGestionPompiers_Load(object sender, EventArgs e)
        {
        }

        private void modeAdmin()
        {
            m_admin = true;

            pcbAdmin.Image = Image.FromFile("img/admin_connecte.jpg");
            lblMode.Text = "Mode administrateur";
            btnUpdate.Visible = true;

            // Chat gpt a changer
            if (cmbPompier.SelectedItem is KeyValuePair<int, string> selectedPair)
            {
                afficherUCPompier(selectedPair.Key);
            }
            else
            {
                afficherUCPompier(Convert.ToInt16(cmbPompier.SelectedValue));
            }
        }

        private void afficherUCPompier(int matricule)
        {
            pnlAffichagePompier.Controls.Clear();

            UC_AffichagePompier mission = new UC_AffichagePompier(matricule, m_admin);
            mission.Location = new Point(15, 20);
            pnlAffichagePompier.Controls.Add(mission);
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

        private void cmbCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caserneCharge)
            {
                int idCaserne = Convert.ToInt16(cmbCaserne.SelectedValue);

                Dictionary<int, string> dico = new Dictionary<int, string>();

                foreach (DataRow row in MesDatas.DsGlobal.Tables["Affectation"].Select($"idCaserne = {idCaserne}"))
                {
                    int matricule = Convert.ToInt16(row["matriculePompier"]);
                    DataRow pompier = MesDatas.DsGlobal.Tables["Pompier"].Select($"matricule = {matricule}")[0];
                    string nomComplet = $"{pompier["nom"]} {pompier["prenom"]}";

                    dico.Add(matricule, nomComplet);
                }

                cmbPompier.DataSource = new BindingSource(dico, null);
                cmbPompier.ValueMember = "Key";
                cmbPompier.DisplayMember = "Value";
            }
        }

        private void cmbPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chat gpt a changer
            if (cmbPompier.SelectedItem is KeyValuePair<int, string> selectedPair)
            {
                afficherUCPompier(selectedPair.Key);
            }
            else
            {
                afficherUCPompier(Convert.ToInt16(cmbPompier.SelectedValue));
            }
                
        }
    }
}
