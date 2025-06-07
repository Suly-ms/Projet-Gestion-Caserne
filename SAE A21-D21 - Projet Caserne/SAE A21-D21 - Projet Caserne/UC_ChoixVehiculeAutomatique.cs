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
    public partial class UC_ChoixVehiculeAutomatique : UserControl
    {
        private string m_type, m_numero, m_caserne;
        public UC_ChoixVehiculeAutomatique(Image image, string type, int numero, int caserne)
        {
            InitializeComponent();
            m_type = type;
            m_numero = numero.ToString();
            m_caserne = caserne.ToString();
            lblType.Text = type;
            lblNumero.Text = $"N° {numero}";
            lblCaserne.Text = $"Caserne N° {caserne}";
            pbVehicule.Image = image;
            pbVehicule.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void UC_ChoixVehiculeAutomatique_Load(object sender, EventArgs e)
        {

        }
    }
}
