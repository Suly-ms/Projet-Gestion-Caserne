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
    public partial class UC_ChoixPompierAutomatique : UserControl
    {
        private string m_nom, m_prenom, m_grade;
        public UC_ChoixPompierAutomatique(Image image, string grade, string nom, string prenom)
        {
            InitializeComponent();
            m_nom = nom;
            m_prenom = prenom;
            pbGrade.Image = image;
            pbGrade.SizeMode = PictureBoxSizeMode.StretchImage;
            lblGrade.Text = grade;
            lblNom.Text = $"{nom} {prenom}";
        }

        private void UC_ChoixPompierAutomatique_Load(object sender, EventArgs e)
        {

        }
    }
}
