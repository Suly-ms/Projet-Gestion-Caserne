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
    public partial class FrmChoixVehiculesPompierAutomatique : Form
    {
        public FrmChoixVehiculesPompierAutomatique(DataSet dataSet)
        {
            InitializeComponent();

            dataGridView1.DataSource = dataSet.Tables["Engin"];
            dataGridView2.DataSource = dataSet.Tables["Pompier"];
        }

        private void FrmChoixVehiculesPompierAutomatique_Load(object sender, EventArgs e)
        {

        }
    }
}
