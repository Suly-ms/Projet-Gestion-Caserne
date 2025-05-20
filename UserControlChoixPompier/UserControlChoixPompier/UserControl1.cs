using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlChoixPompier
{
    public partial class UCChoixPompier: UserControl
    {
        public UCChoixPompier()
        {
            InitializeComponent();
        }

        public void ChargerDonnees(Image image, String grade, String nom)
        {
            pbGrade.Image = image;
            pbGrade.SizeMode = PictureBoxSizeMode.StretchImage;
            lblGrade.Text = grade;
            lblNom.Text = nom;
        }

        private void btnChoisi_Click(object sender, EventArgs e)
        {
            btnChoisi.BackColor = btnChoisi.BackColor == Color.Red ? Color.Green : Color.Red;
        }
    }
}
