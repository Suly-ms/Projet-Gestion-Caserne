using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class UC_CreerPompier : UserControl
    {
        private int m_matricule;
        private int m_bip;

        public UC_CreerPompier(int matricule, int bip)
        {
            InitializeComponent();
            m_matricule = matricule;
            m_bip = bip;
        }

        private void UC_CreerPompier_Load(object sender, EventArgs e)
        {
            DataTable tablePompiers = MesDatas.DsGlobal.Tables["Pompier"];
            DataRow[] pompiers = tablePompiers.Select();

            cmbSexe.Items.Add("Masculin");
            cmbSexe.Items.Add("Feminin");

            lblAge.Text = $"Age : {calculerAge()} ans";

            dtpDateNaissance.MaxDate = DateTime.Today.AddYears(-2);

            rdbProfessionnel.Checked = true;

            remplirCmbCaserneRattachement();
            remplirCmbGrade();
        }

        public char getType()
        {
            return rdbProfessionnel.Checked ? 'p' : 'v';
        }

        public string getCodeGrade()
        {
            DataTable tableGrades = MesDatas.DsGlobal.Tables["Grade"];
            DataRow grade = tableGrades.Select($"libelle = '{cmbGrade.Text}'")[0];

            return grade["code"].ToString().ToUpper();
        }

        public int getIdCaserne()
        {
            return Convert.ToInt16(cmbCaserneRattachement.SelectedValue);
        }

        public int getMatricule()
        {
            return m_matricule;
        }

        public string getNom()
        {
            return txbNom.Text;
        }

        public string getPrenom()
        {
            return txbPrenom.Text;
        }
        public char getSexe()
        {
            return cmbSexe.SelectedIndex == 0 ? 'm' : 'f';
        }

        public string getTelephone()
        {
            return txbTelephone.Text;
        }

        public DateTime getDateNaissance()
        {
            return dtpDateNaissance.Value;
        }
        public int getBip()
        {
            return m_bip;
        }

        private void remplirCmbCaserneRattachement()
        {
            // Remplit la comboBox avec toutes les casernes
            cmbCaserneRattachement.DataSource = MesDatas.DsGlobal.Tables["Caserne"];

            cmbCaserneRattachement.DisplayMember = "nom";
            cmbCaserneRattachement.ValueMember = "id";
            cmbCaserneRattachement.SelectedValue = -1;
        }

        private void remplirCmbGrade()
        {
            DataTable tableGrades = MesDatas.DsGlobal.Tables["Grade"];
            DataRow[] grades = tableGrades.Select();

            foreach (DataRow grade in grades)
            {
                cmbGrade.Items.Add(grade["libelle"]);
            }
            cmbGrade.SelectedIndex = 0;
        }

        private void cmbGrade_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private int calculerAge()
        {
            DateTime dateNaissance = dtpDateNaissance.Value;
            DateTime aujourdHui = DateTime.Today;

            int age = aujourdHui.Year - dateNaissance.Year;

            // Si l'anniversaire n'est pas encore passé cette année on retire 1
            if (dateNaissance > aujourdHui.AddYears(-age)) age--;

            return age;
        }

        public bool estMajeur()
        {
            return calculerAge() >= 18;
        }

        public bool estRemplit()
        {
            return (txbNom.Text != "" && txbPrenom.Text != "" && txbTelephone.Text != "" && cmbCaserneRattachement.SelectedItem != null && cmbSexe.SelectedItem != null && cmbGrade.SelectedItem != null);
        }

        private void dtpDateNaissance_ValueChanged(object sender, EventArgs e)
        {
            lblAge.Text = $"Age : {calculerAge()} ans";
        }

        private void txbTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txbTelephone_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dtpDateNaissance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Empêche toute saisie clavier
        }

        private void dtpDateNaissance_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true; // Supprime l'effet de la touche
        }
    }
}
