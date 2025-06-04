using Org.BouncyCastle.Asn1.Ocsp;
using Pinpon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
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
        private bool caserneCharge = false;
        private bool majEnCours = false;
        private bool indexCaserne = false;

        private bool m_admin = false;

        // Declaration du userControl
        UC_AffichagePompier ucPompier;

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
            // Remplit la comboBox avec toutes les casernes

            // On utilise une copie pour éviter qu'un changement de sélection modifit aussi la sélection de l'autre comboBox (lié au même DataTable)
            cmbCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"].Copy();

            cmbCaserne.DisplayMember = "nom";
            cmbCaserne.ValueMember = "id";
            cmbCaserne.SelectedIndex = -1;
            caserneCharge = true;
        }

        private int chercherIdCaserne(int matricule)
        {
            DataTable tableAffectation = MesDatas.DsGlobal.Tables["Affectation"];

            return Convert.ToInt16(tableAffectation.Select($"matriculePompier = {matricule} AND dateFin IS NULL")[0]["idCaserne"]);
        }

        private string chercherCaserne(int idCaserne)
        {
            DataTable tableCaserne = MesDatas.DsGlobal.Tables["Caserne"];
            DataRow[] casernes = tableCaserne.Select($"id = {idCaserne}");
            return casernes[0]["nom"].ToString();
        }

        private void modeAdmin(FrmConnexionAdmin frm)
        {
            m_admin = true;

            pcbAdmin.Image = Image.FromFile("img/admin/admin_connecte.jpg");
            lblMode.Text = "Mode administrateur";
            lblMode.ForeColor = Color.FromArgb(255, 193, 7);
            btnUpdate.Visible = true;
            btnNouveauPompier.Visible = true;

            lblSeConnecter.Text = frm.LoginAdmin;
            lblSeConnecter.ForeColor = Color.FromArgb(255, 193, 7);


            Debug.WriteLine($"ModeAdmin : lblSeConnecter.ForeColor = {lblSeConnecter.ForeColor}");

            // Chat gpt a changer
            if (cmbPompier.SelectedValue != null)
            {
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

        private void afficherUCPompier(int matricule)
        {
            pnlAffichagePompier.Controls.Clear();

            ucPompier = new UC_AffichagePompier(matricule, m_admin);
            ucPompier.Location = new Point(15, 20);
            pnlAffichagePompier.Controls.Add(ucPompier);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pnlConnexion_Click(object sender, EventArgs e)
        {
            pnlConnexion_Click();
        }
        private void lblSeConnecter_Click(object sender, EventArgs e)
        {
            pnlConnexion_Click();
        }

        private void pcbAdmin_Click(object sender, EventArgs e)
        {
            pnlConnexion_Click();
        }

        private void pnlConnexion_Click()
        {
            FrmConnexionAdmin frmConnexionAdmin = new FrmConnexionAdmin();

            // Ouvre le form pour se connecté à un compte admin, sauvegarde le resultat dans une variable
            DialogResult result = frmConnexionAdmin.ShowDialog();

            // Si l'utilisateur s'est connecté à un compte admin, affiche les options admin sur le form
            if (result == DialogResult.OK)
            {
                modeAdmin(frmConnexionAdmin);
                pcbAdmin.Enabled = false; // Plus cliquable
                lblSeConnecter.Enabled = false;
                pnlConnexion.Enabled = false;
            }
        }

        private void cmbCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caserneCharge && !majEnCours)
            {
                indexCaserne = true;

                int idCaserne = Convert.ToInt16(cmbCaserne.SelectedValue);

                Dictionary<int, string> dico = new Dictionary<int, string>();

                foreach (DataRow row in MesDatas.DsGlobal.Tables["Affectation"].Select($"idCaserne = {idCaserne} AND dateFin IS NULL"))
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

        private void chargerCaserne(object sender)
        {
            if (indexCaserne)
            {
                cmbCaserne_SelectedIndexChanged(sender, EventArgs.Empty);
            }
        }

        private void cmbPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!majEnCours)
            {
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            majEnCours = true;
            try
            {

                string requeteUpdatePompier = $"UPDATE Pompier SET type = '{ucPompier.getType()}', enConge = {ucPompier.estEnConge()}, codeGrade = '{ucPompier.getCodeGrade()}' WHERE matricule = {ucPompier.getMatricule()}";
                SQLiteCommand cdUpdatePompier = new SQLiteCommand();
                cdUpdatePompier.Connection = connec;
                cdUpdatePompier.CommandType = CommandType.Text;
                cdUpdatePompier.CommandText = requeteUpdatePompier;
                cdUpdatePompier.ExecuteNonQuery();


                int newIdCaserne = chercherIdCaserne(ucPompier.getMatricule());
                if (ucPompier.getIdCaserne() != newIdCaserne)
                {
                    string requeteUpdateAffectation = $"UPDATE Affectation SET dateFin = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}' WHERE matriculePompier = {ucPompier.getMatricule()} AND dateFin IS NULL";
                    SQLiteCommand cdUpdateAffectation = new SQLiteCommand();
                    cdUpdateAffectation.Connection = connec;
                    cdUpdateAffectation.CommandType = CommandType.Text;
                    cdUpdateAffectation.CommandText = requeteUpdateAffectation;
                    cdUpdateAffectation.ExecuteNonQuery();


                    string requeteInsertAffectation = $"INSERT INTO Affectation (matriculePompier, dateA, idCaserne) " +
                                                      $"VALUES ({ucPompier.getMatricule()}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', {ucPompier.getIdCaserne()})";
                    SQLiteCommand cdInsertAffectation = new SQLiteCommand();
                    cdInsertAffectation.Connection = connec;
                    cdInsertAffectation.CommandType = CommandType.Text;
                    cdInsertAffectation.CommandText = requeteInsertAffectation;
                    cdInsertAffectation.ExecuteNonQuery();
                }

                // Recharger le dataSet
                DataTable schemaTable = connec.GetSchema("Tables");
                MesDatas.DsGlobal.Tables.Clear();

                string requete;
                foreach (DataRow ligne in schemaTable.Rows)
                {
                    requete = $"select * from {ligne[2].ToString()}";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(requete, connec);

                    da.Fill(MesDatas.DsGlobal, ligne[2].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            finally
            {
                FrmGestionPompiers_Load(sender, EventArgs.Empty);

                // Empeche l'appel des IndexChanged (eviter les erreurs...)
                majEnCours = true;

                // Attente de 0.5sec pour laisser le temps à la base de donnée de se mettre a jour
                Task.Delay(500);

                // Et pout pouvoir replacer l'utilisateur sur le même pompier (même si il a changé de caserne)
                cmbCaserne.SelectedValue = ucPompier.getIdCaserne();
                cmbPompier.SelectedValue = ucPompier.getMatricule();
                majEnCours = false;

                // Une fois tout chargé, on force l'appel pour rafraichir le user control
                cmbPompier_SelectedIndexChanged(sender, EventArgs.Empty);

                MessageBox.Show($"Les modifications apportées à {ucPompier.getNomComplet()} ont été réalisées");
            }
        }

        private void btnNouveauPompier_Click(object sender, EventArgs e)
        {
            FrmCreerPompier frmCreerPompier = new FrmCreerPompier();
            DialogResult result = frmCreerPompier.ShowDialog();

            Task.Delay(500);
            if (result == DialogResult.OK) 
            {
                chargerCaserne(sender);
                cmbCaserne.SelectedValue = frmCreerPompier.IndexCaserne;
                cmbPompier.SelectedIndex = cmbPompier.Items.Count - 1;
            } 
        }
    }
}
