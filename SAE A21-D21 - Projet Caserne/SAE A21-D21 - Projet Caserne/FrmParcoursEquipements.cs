using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Utilise les fichiers Connexion.cs et mesDatas.cs
using Pinpon;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class FrmParcoursEquipements : Form
    {
        public FrmParcoursEquipements()
        {
            InitializeComponent();

            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private DataTable dtEngins = new DataTable();
        private BindingSource enginsBinding = new BindingSource();

        private void FrmParcoursEquipements_Load(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection connec = Connexion.Connec;
                string requete = "SELECT id, nom FROM Caserne";

                SQLiteDataAdapter da = new SQLiteDataAdapter(requete, connec);
                DataTable dtCaserne = new DataTable();
                da.Fill(dtCaserne);

                cbxCaserne.DisplayMember = "nom";
                cbxCaserne.ValueMember = "id";
                cbxCaserne.DataSource = dtCaserne;

                lblStatutMission.Visible = false;
                lblStatutPanne.Visible = false;
                lblStatutDisponible.Visible = false;

                pictureBoxEngin.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement casernes : " + ex.Message);
            }

            cbxCaserne_SelectedIndexChanged(sender, EventArgs.Empty);
        }

        private void ChargerTable(int idCaserne)
        {
            string requete = $@"
            SELECT 
            e.idCaserne || '-' || t.code || '-' || e.numero AS numero,
            e.dateReception,
            e.enMission,
            e.enPanne,
            t.code AS codeType
            FROM Engin e
            JOIN TypeEngin t ON e.codeTypeEngin = t.code
            WHERE e.idCaserne = {idCaserne}";

            dtEngins.Clear();

            using (SQLiteDataAdapter da = new SQLiteDataAdapter(requete, Connexion.Connec))
            {
                da.Fill(dtEngins);
            }

            enginsBinding.DataSource = dtEngins;
            enginsBinding.PositionChanged -= EnginsBinding_PositionChanged;
            enginsBinding.PositionChanged += EnginsBinding_PositionChanged;

            lblNumeroEngin.DataBindings.Clear();
            lblDateReception.DataBindings.Clear();

            lblNumeroEngin.DataBindings.Add("Text", enginsBinding, "numero");
            lblDateReception.DataBindings.Add("Text", enginsBinding, "dateReception", true, DataSourceUpdateMode.Never, null, "d");

            // Déclenche le position changed pour afficher le statut du 1er engin
            EnginsBinding_PositionChanged(null, null);
        }

        private void EnginsBinding_PositionChanged(object sender, EventArgs e)
        {
            if (enginsBinding.Current is DataRowView drv)
            {
                bool enMission = drv["enMission"] != DBNull.Value && Convert.ToBoolean(drv["enMission"]);
                bool enPanne = drv["enPanne"] != DBNull.Value && Convert.ToBoolean(drv["enPanne"]);

                lblStatutMission.Visible = enMission;
                lblStatutPanne.Visible = !enMission && enPanne;
                lblStatutDisponible.Visible = !enMission && !enPanne;

                // Ajout affichage de l’image en fonction du type
                if (drv["codeType"] != DBNull.Value)
                {
                    string codeType = drv["codeType"].ToString().ToLower();
                    string cheminImage = $@"img\vehicules\{codeType}.jpg";

                    if (System.IO.File.Exists(cheminImage))
                    {
                        pictureBoxEngin.Image = Image.FromFile(cheminImage);
                    }
                    else
                    {
                        pictureBoxEngin.Image = null;
                    }
                }
            }
        }


        private void cbxCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbxCaserne.SelectedValue.ToString(), out int idCaserne))
            {
                ChargerTable(idCaserne);
            }
        }

        private void btnFullGauche_Click(object sender, EventArgs e)
        {
            enginsBinding.Position = 0;
        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            if (enginsBinding.Position > 0)
                enginsBinding.Position--;
        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            if (enginsBinding.Position < enginsBinding.Count - 1)
                enginsBinding.Position++;
        }

        private void btnFullDroite_Click(object sender, EventArgs e)
        {
            enginsBinding.Position = enginsBinding.Count - 1;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlEngin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
