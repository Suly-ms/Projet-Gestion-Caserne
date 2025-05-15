using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlChoixVehicules
{
    public partial class UCChoixVehicule: UserControl
    {
        public UCChoixVehicule()
        {
            InitializeComponent();
        }

        public void ChargerDonnees(Image image, int numero, int type)
        {
            pbVehicule.Image = image;
            lblNumero.Text = numero.ToString();
            lblType.Text = type.ToString();
        }

        private void btnChoisi_Click(object sender, EventArgs e)
        {
            btnChoisi.BackColor = btnChoisi.BackColor==Color.Red ? Color.Green : Color.Red;
        }
    }
}
