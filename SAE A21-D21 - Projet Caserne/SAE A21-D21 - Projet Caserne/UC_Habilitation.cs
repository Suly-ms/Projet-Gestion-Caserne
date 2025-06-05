using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Asn1.Pkcs;
using Pinpon;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class UC_Habilitation : UserControl
    {
        private int m_idHabiliatation;
        private DateTime m_aujourdHui = DateTime.Today;

        public UC_Habilitation(int idHabilitation)
        {
            InitializeComponent();

            m_idHabiliatation = idHabilitation;
        }

        private void UC_Habilitation_Load(object sender, EventArgs e)
        {
            DataTable tableHabilitations = MesDatas.DsGlobal.Tables["Habilitation"];
            DataRow[] habilitations = tableHabilitations.Select($"id = {m_idHabiliatation}");

            cbxHabilitation.Text = habilitations[0]["libelle"].ToString();

            dtpDateHabilitation.MaxDate = DateTime.Today;
            dtpDateHabilitation.Value = m_aujourdHui;
        }
        public int getIdHabilitation()
        {
            return m_idHabiliatation;
        }

        public DateTime getDateHabilitation()
        {
            return dtpDateHabilitation.Value;
        }

        public bool estCheck()
        {
            return cbxHabilitation.Checked;
        }

        public bool dateChange()
        {
            return !(m_aujourdHui == dtpDateHabilitation.Value);
        }

        private void cbxHabilitation_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateHabilitation.Visible = !dtpDateHabilitation.Visible;
        }

        private void pcbCalendrier_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%{DOWN}");
            dtpDateHabilitation.Focus(); // important : donner le focus au DTP avant
        }
    }
}
