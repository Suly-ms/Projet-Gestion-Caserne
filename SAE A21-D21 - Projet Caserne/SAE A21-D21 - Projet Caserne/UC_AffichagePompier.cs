using Org.BouncyCastle.Asn1.IsisMtt.X509;
using Pinpon;
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
    public partial class UC_AffichagePompier : UserControl
    {
        private int m_matricule;
        private bool m_admin;
        public UC_AffichagePompier(int matricule, bool admin)
        {
            InitializeComponent();

            m_matricule = matricule;
            m_admin = admin;
        }

        private void UC_AffichagePompier_Load(object sender, EventArgs e)
        {
            DataTable tablePompiers = MesDatas.DsGlobal.Tables["Pompier"];
            DataRow pompier = tablePompiers.Select($"matricule = {m_matricule}")[0];

            lblMatricule.Text = $"Matricule {m_matricule}";
            lblNom.Text = $"Nom : {pompier["nom"].ToString()}";
            lblPrenom.Text = $"Prénom : {pompier["prenom"].ToString()}";
            lblSexe.Text = $"Nom : {(pompier["sexe"].ToString() == "m" ? "Masculin" : "Feminin")}";

            DateTime dateNaissance = Convert.ToDateTime(pompier["dateNaissance"]);
            DateTime aujourdHui = DateTime.Today;

            lblDateNaissance.Text = $"Date de naissance : {Convert.ToDateTime(pompier["dateNaissance"]):dd/MM/yyyy}";

            int age = aujourdHui.Year - dateNaissance.Year;

            // Regarde si l'anniversaire est déjà passé cette année
            if (dateNaissance.Date > aujourdHui.AddYears(-age)) age--;

            lblAge.Text = $"Age : {age}";

            rdbProfessionnel.Checked = pompier["type"].ToString() == "d";
            rdbProfessionnel.Checked = pompier["type"].ToString() == "v";

            DateTime dateEmbauche = Convert.ToDateTime(pompier["dateEmbauche"]);

            lblDateEmbauche.Text = $"Date d'embauche : {dateEmbauche:dd/MM/yyyy}";

            // cmbGrade.Items.Add();

            lblTelephone.Text = $"Téléphone : {pompier["portable"].ToString()}";
            lblBip.Text = $"Bip : {pompier["bip"].ToString()}";

            if (m_admin) modeAdmin();
        }

        private void modeAdmin()
        {
            // Afficher les boutons d'edition
            pcbEditCaserne.Visible = true;
            pcbEditRdb.Visible = true;
            pcbEditGrade.Visible = true;
            pcbEditConge.Visible = true;

            // Afficher les fleches des comboBoxs
            pnlCacherCmbGrade.Visible = false;
            pnlCacherCmbCaserne.Visible = false;

        }

        private void pcbEditRdb_Click(object sender, EventArgs e)
        {
            rdbProfessionnel.Enabled = !rdbProfessionnel.Enabled;
            rdbVolontaire.Enabled = !rdbVolontaire.Enabled;
        }

        private void pcbEditGrade_Click(object sender, EventArgs e)
        {
            cmbGrade.Enabled = !cmbGrade.Enabled;
        }

        private void pcbEditCaserne_Click(object sender, EventArgs e)
        {
            cmbCaserneRattachement.Enabled = !cmbCaserneRattachement.Enabled;
        }

        private void pcbEditConge_Click(object sender, EventArgs e)
        {
            ckbEnConge.Enabled = !ckbEnConge.Enabled;
        }
    }
}
