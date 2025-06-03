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
            cmbCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cmbCaserne.DisplayMember = "nom";
            cmbCaserne.ValueMember = "id";
            cmbCaserne.SelectedIndex = -1;
            caserneCharge = true;
        }

        private int chercherIdCaserne(int matricule)
        {
            DataTable tableAffectation = MesDatas.DsGlobal.Tables["Affectation"];

            return Convert.ToInt16(tableAffectation.Select($"matriculePompier = {matricule}")[0]["idCaserne"]);
        }

        private string chercherCaserne(int idCaserne)
        {
            DataTable tableCaserne = MesDatas.DsGlobal.Tables["Caserne"];
            DataRow[] casernes = tableCaserne.Select($"id = {idCaserne}");
            return casernes[0]["nom"].ToString();
        }

        private void modeAdmin()
        {
            m_admin = true;

            pcbAdmin.Image = Image.FromFile("img/admin_connecte.jpg");
            lblMode.Text = "Mode administrateur";
            btnUpdate.Visible = true;

            lblSeConnecter.Visible = false;
            lblConnecte.Visible = true;

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
                modeAdmin();
                pcbAdmin.Enabled = false; // Plus cliquable
                lblSeConnecter.Enabled = false;
                pnlConnexion.Enabled = false;
            }
        }

        private void cmbCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caserneCharge)
            {
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string requeteUpdatePompier = $"UPDATE Pompier SET type = '{ucPompier.getType()}', enConge = {ucPompier.estEnConge()}, codeGrade = '{ucPompier.getCodeGrade()}' WHERE matricule = {ucPompier.getMatricule()}";
                SQLiteCommand cdUpdatePompier = new SQLiteCommand();
                cdUpdatePompier.Connection = connec;
                cdUpdatePompier.CommandType = CommandType.Text;
                cdUpdatePompier.CommandText = requeteUpdatePompier;
                cdUpdatePompier.ExecuteNonQuery();

                DataRow lignePompier = MesDatas.DsGlobal.Tables["Pompier"].Select($"matricule = {ucPompier.getMatricule()} AND dateFin IS NULL")[0];
                lignePompier["type"] = ucPompier.getType();
                lignePompier["enConge"] = ucPompier.estEnConge();
                lignePompier["codeGrade"] = ucPompier.getCodeGrade();


                if (ucPompier.getIdCaserne() != chercherIdCaserne(ucPompier.getMatricule()))
                {
                    string requeteUpdateAffectation = $"UPDATE Affectation SET dateFin = {DateTime.Now} WHERE matriculePompier = {ucPompier.getMatricule()} AND dateFin IS NULL";
                    SQLiteCommand cdUpdateAffectation = new SQLiteCommand();
                    cdUpdateAffectation.Connection = connec;
                    cdUpdateAffectation.CommandType = CommandType.Text;
                    cdUpdateAffectation.CommandText = requeteUpdateAffectation;
                    cdUpdateAffectation.ExecuteNonQuery();

                    DataRow ligneAffectation = MesDatas.DsGlobal.Tables["Affectation"].Select($"matriculePompier = {ucPompier.getMatricule()} AND dateFin IS NULL")[0];
                    ligneAffectation["dateFin"] = DateTime.Now;



                    string requeteInsertAffectation = $"INSERT INTO Affectation (matriculePompier), (dateA), (idCaserne) " +
                                                      $"VALUES ({ucPompier.getMatricule()}), ({DateTime.Now}), ({ucPompier.getIdCaserne()})";
                    SQLiteCommand cdInsertAffectation = new SQLiteCommand();
                    cdInsertAffectation.Connection = connec;
                    cdInsertAffectation.CommandType = CommandType.Text;
                    cdInsertAffectation.CommandText = requeteInsertAffectation;
                    cdInsertAffectation.ExecuteNonQuery();

                    DataTable tableAffectation = MesDatas.DsGlobal.Tables["Affectation"];
                    DataRow nouvelleLigne = tableAffectation.NewRow();
                    nouvelleLigne["matriculePompier"] = ucPompier.getMatricule();
                    nouvelleLigne["dateA"] = DateTime.Now;
                    nouvelleLigne["idCaserne"] = ucPompier.getIdCaserne();
                    nouvelleLigne["dateFin"] = DBNull.Value;

                    tableAffectation.Rows.Add(nouvelleLigne);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                FrmGestionPompiers_Load(sender, EventArgs.Empty); 
            }
        }
    }
}
