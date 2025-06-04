using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Pinpon;

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
            lblSexe.Text = $"Sexe : {(pompier["sexe"].ToString() == "m" ? "Masculin" : "Feminin")}";

            DateTime dateNaissance = Convert.ToDateTime(pompier["dateNaissance"]);
            DateTime aujourdHui = DateTime.Today;

            lblDateNaissance.Text = $"Date de naissance : {Convert.ToDateTime(pompier["dateNaissance"]):dd/MM/yyyy}";

            int age = aujourdHui.Year - dateNaissance.Year;

            // Regarde si l'anniversaire est déjà passé cette année
            if (dateNaissance.Date > aujourdHui.AddYears(-age)) age--;

            lblAge.Text = $"Age : {age}";

            rdbProfessionnel.Checked = Convert.ToChar(pompier["type"]) == 'p';
            rdbVolontaire.Checked = Convert.ToChar(pompier["type"]) == 'v';

            rdbActif.Checked = !Convert.ToBoolean(pompier["enConge"]);
            rdbEnConge.Checked = Convert.ToBoolean(pompier["enConge"]);

            DateTime dateEmbauche = Convert.ToDateTime(pompier["dateEmbauche"]);

            lblDateEmbauche.Text = $"Date d'embauche : {dateEmbauche:dd/MM/yyyy}";

            lblTelephone.Text = $"Téléphone : {pompier["portable"].ToString()}";
            lblBip.Text = $"Bip : {pompier["bip"].ToString()}";

            lblCodeGrade.Text = pompier["codeGrade"].ToString().ToUpper();
            pcbGrade.Image = Image.FromFile($"img/grades/{lblCodeGrade.Text}.png");

            DataTable tableGrades = MesDatas.DsGlobal.Tables["Grade"];
            DataRow[] grades = tableGrades.Select();

            foreach (DataRow grade in grades)
            {
                cmbGrade.Items.Add(grade["libelle"]);
                if (grade["code"].ToString().ToUpper() == lblCodeGrade.Text)
                {
                    cmbGrade.SelectedItem = grade["libelle"];
                }
            }

            remplirCmbCaserneRattachement(chercherIdCaserne());

            DataRow[] habilitations = chercherHabilitation();

            foreach (DataRow habilitation in habilitations)
            {
                lsbHabilitation.Items.Add(habilitation["libelle"].ToString());
            }

            DataRow[] affectations = chercherAffectation();

            for (int i = affectations.Length - 1; i >= 0; i--)
            {
                lsbAffectations.Items.Add($"({i + 1}) {Convert.ToDateTime(affectations[i]["dateA"]):dd-MM-yyyy} - {chercherCaserne(Convert.ToInt16(affectations[i]["idCaserne"]))}");
            }

            if (m_admin) modeAdmin();
        }

        public char getType()
        {
            return rdbProfessionnel.Checked ? 'p' : 'v';
        }

        public string getCodeGrade()
        {
            return lblCodeGrade.Text;
        }

        public int getIdCaserne()
        {
            return Convert.ToInt16(cmbCaserneRattachement.SelectedValue);
        }

        public bool estEnConge()
        {
            return rdbEnConge.Checked;
        }

        public int getMatricule()
        {
            return m_matricule;
        }

        public string getNomComplet()
        {
            DataRow pompier = MesDatas.DsGlobal.Tables["Pompier"].Select($"matricule = {m_matricule}")[0];
            return $"{pompier["nom"]} {pompier["prenom"]}";
             
        }

        private void remplirCmbCaserneRattachement(int idCaserne)
        {
            // Remplit la comboBox avec toutes les casernes
            cmbCaserneRattachement.DataSource = MesDatas.DsGlobal.Tables["Caserne"];     
   
            cmbCaserneRattachement.DisplayMember = "nom";
            cmbCaserneRattachement.ValueMember = "id";
            cmbCaserneRattachement.SelectedValue = idCaserne;
        }

        private int chercherIdCaserne()
        {
            DataTable tableAffectation = MesDatas.DsGlobal.Tables["Affectation"];

            return Convert.ToInt16(tableAffectation.Select($"matriculePompier = {m_matricule} AND dateFin IS NULL")[0]["idCaserne"]);
        }

        private string chercherCaserne(int idCaserne)
        {
            DataTable tableCaserne = MesDatas.DsGlobal.Tables["Caserne"];
            DataRow[] casernes = tableCaserne.Select($"id = {idCaserne}");
            return casernes[0]["nom"].ToString();
        }

        private DataRow[] chercherAffectation()
        {
            DataTable tableAffectation = MesDatas.DsGlobal.Tables["Affectation"];
            return tableAffectation.Select($"matriculePompier = {m_matricule}");

        }

        private DataRow[] chercherMobilisations()
        {
            DataTable tableMobilisers = MesDatas.DsGlobal.Tables["Mobiliser"];
            return tableMobilisers.Select($"matriculePompier = {m_matricule}");
        }

        private DataRow[] chercherHabilitation()
        {
            DataRow[] mobilisations = chercherMobilisations();

            DataTable tableHabilitations = MesDatas.DsGlobal.Tables["Habilitation"];
            DataRow[] habilitations = new DataRow[mobilisations.Length];

            for (int i = 0; i < mobilisations.Length; i++)
            {
                habilitations[i] = tableHabilitations.Select($"id = {mobilisations[i]["idHabilitation"]}")[0];
            }
            return habilitations;
        }

        private void modeAdmin()
        {
            // Afficher les boutons d'edition
            pcbEditCaserne.Visible = true;
            pcbEditRdbProVol.Visible = true;
            pcbEditGrade.Visible = true;
            pcbEditRdbProVol.Visible = true;
            pcbEditRdbActifConge.Visible = true;

            // Afficher les fleches des comboBoxs
            pnlCacherCmbGrade.Visible = false;
            pnlCacherCmbCaserne.Visible = false;

        }

        private void pcbEditRdb_Click(object sender, EventArgs e)
        {
            rdbProfessionnel.Enabled = !rdbProfessionnel.Enabled;
            rdbVolontaire.Enabled = !rdbVolontaire.Enabled;
        }

        private void pcbEditCaserne_Click(object sender, EventArgs e)
        {
            cmbCaserneRattachement.Enabled = !cmbCaserneRattachement.Enabled;
        }

        private void pcbEditGrade_Click(object sender, EventArgs e)
        {
            cmbGrade.Enabled = !cmbGrade.Enabled;
        }

        private void cmbGrade_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable tableGrades = MesDatas.DsGlobal.Tables["Grade"];
            DataRow grade = tableGrades.Select($"libelle = '{cmbGrade.Text}'")[0];

            lblCodeGrade.Text = grade["code"].ToString().ToUpper();

            pcbGrade.Image = Image.FromFile($"img/grades/{lblCodeGrade.Text}.png");
        }

        private void pcbEditRdbActifConge_Click(object sender, EventArgs e)
        {
            rdbActif.Enabled = !rdbActif.Enabled;
            rdbEnConge.Enabled = !rdbEnConge.Enabled;
        }

        private void cmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
