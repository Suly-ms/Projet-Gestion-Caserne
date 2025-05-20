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
        public event EventHandler<VehiculeChoisiEventArgs> VehiculeChoisi;
        public event EventHandler<VehiculeNonChoisiEventArgs> VehiculeNonChoisi;
        public UCChoixVehicule()
        {
            InitializeComponent();
        }

        public void ChargerDonnees(Image image, int numero, String type)
        {
            pbVehicule.Image = image;
            pbVehicule.SizeMode = PictureBoxSizeMode.StretchImage;
            lblNumero.Text = numero.ToString();
            lblType.Text = type;
        }

        private void btnChoisi_Click(object sender, EventArgs e)
        {
            if(btnChoisi.BackColor == Color.Red)
            {
                VehiculeChoisi?.Invoke(this, new VehiculeChoisiEventArgs
                {
                    Numero = int.Parse(lblNumero.Text),
                    Type = lblType.Text
                });
                btnChoisi.BackColor = Color.Green;
            }
            else
            {
                VehiculeNonChoisi?.Invoke(this, new VehiculeNonChoisiEventArgs
                {
                    Numero = int.Parse(lblNumero.Text),
                    Type = lblType.Text
                });
                btnChoisi.BackColor = Color.Red;
            }
        }
        public class VehiculeChoisiEventArgs : EventArgs
        {
            public int Numero { get; set; }
            public string Type { get; set; }
        }

        public class VehiculeNonChoisiEventArgs : EventArgs
        {
            public int Numero { get; set; }
            public string Type { get; set; }
        }
    }
}
