using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlChoixVehicules;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class frmChoixVehiculesPompier : Form
    {
        public frmChoixVehiculesPompier()
        {
            InitializeComponent();
        }

        private void frmChoixVehiculesPompier_Load(object sender, EventArgs e)
        {
            int top = 10;
            int left = 20;

            Image img;

            try
            {
                // Charger l'image depuis le disque
                img = Image.FromFile("img/pompt_tonnes.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < 20; i++)
            {
                var choixVehicule = new UCChoixVehicule
                {
                    Top = top,
                    Left = left
                };

                // Charger les données dans le UserControl
                choixVehicule.ChargerDonnees(img, 1, 2);

                pnlChoixVehicule.Controls.Add(choixVehicule);
                top += 110;
            }
        }
    }
}
