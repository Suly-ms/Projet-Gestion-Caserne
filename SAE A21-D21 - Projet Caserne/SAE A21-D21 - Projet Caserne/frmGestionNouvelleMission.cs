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
using UserControlChoixVehicules;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class FrmGestionNouvelleMission : Form
    {
        private DataSet pompierVehiculeMission;
        private int numeroMission;
        public FrmGestionNouvelleMission()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Récupérer date aujourd'hui et l'attribuer à lblDateDelenchement
            DateTime dateAujourdhui = DateTime.Now;
            lblDateDelenchement.Text = lblDateDelenchement.Text + dateAujourdhui.ToString();

            // Récupérer les natures du sinitre et remplir la combobox attribuée

            cbxNatureSinistre.DataSource = MesDatas.DsGlobal.Tables["NatureSinistre"];
            cbxNatureSinistre.DisplayMember = "libelle";
            cbxNatureSinistre.ValueMember = "id";

            // Récupérer les natures du sinitre et remplir la combobox attribuée

            cbxCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cbxCaserne.DisplayMember = "nom";
            cbxCaserne.ValueMember = "id";

            // Récupérer le numéro de mission
            using (SQLiteCommand getMaxId = new SQLiteCommand("SELECT IFNULL(MAX(id), 0) + 1 FROM Mission", Connexion.Connec))
            {
                numeroMission = Convert.ToInt32(getMaxId.ExecuteScalar());
                lblNouvelleMission.Text = lblNouvelleMission.Text + numeroMission.ToString();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConstituer_Click(object sender, EventArgs e)
        {
            FrmChoixVehiculesPompier monUC = new FrmChoixVehiculesPompier(
                Convert.ToInt32(cbxNatureSinistre.SelectedValue),
                Convert.ToInt32(cbxCaserne.SelectedValue)
            );

            if (monUC.ShowDialog() == DialogResult.OK)
            {
                // Ici, on utilise bien l'instance monUC pour accéder à la propriété
                pompierVehiculeMission = monUC.DataSetMission;
                btnConstituer.BackColor = Color.White;
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txbMotif.Text = "";
            txbCodePostal.Text = "";
            txbRue.Text = "";
            txbVille.Text = "";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(!(txbVille.Text=="" || txbRue.Text == "" || txbCodePostal.Text == "" || pompierVehiculeMission == null))
            {
                SQLiteCommand insertIntoMission = new SQLiteCommand();
                insertIntoMission.Connection = Connexion.Connec;
                insertIntoMission.CommandText = $@"INSERT INTO Mission(id, dateHeureDepart, motifAppel, adresse, cp, ville, terminee, idNatureSinistre, idCaserne)
                                               VALUES('{numeroMission}', '{DateTime.Now}', '{txbMotif.Text}', '{txbRue.Text}', '{txbCodePostal.Text}', '{txbVille.Text}', 0, '{cbxNatureSinistre.SelectedValue}', '{cbxCaserne.SelectedValue}');";
                insertIntoMission.ExecuteNonQuery();

                DataRow[] Vehicules = pompierVehiculeMission.Tables["Vehicules"].Select();
                foreach (DataRow row in Vehicules)
                {
                    insertIntoMission.CommandText = $@"INSERT INTO PartirAvec
                                               VALUES({row["Caserne"]}, '{row["Type"]}', '{row["Numero"]}', {numeroMission}, NULL);";
                    insertIntoMission.ExecuteNonQuery();
                    insertIntoMission.CommandText = $@"UPDATE Engin
                                               SET enMission = 1 WHERE codeTypeEngin = '{row["Type"]}' AND numero = { row["Numero"]} AND idCaserne = {row["Caserne"]};";
                    MessageBox.Show(insertIntoMission.CommandText);
                    insertIntoMission.ExecuteNonQuery();
                }

                DataRow[] Pompiers = pompierVehiculeMission.Tables["Pompiers"].Select();
                foreach (DataRow row in Pompiers)
                {
                    insertIntoMission.CommandText = $@"INSERT INTO Mobiliser
                                                VALUES({row["matricule"]}, {numeroMission}, {row["habilitation"]});";
                    insertIntoMission.ExecuteNonQuery();
                }

                Connexion.FermerConnexion();

                // Ajouter dans Mission
                DataRow rowMission = MesDatas.DsGlobal.Tables["Mission"].NewRow();
                rowMission["id"] = numeroMission;
                rowMission["dateHeureDepart"] = DateTime.Now;
                rowMission["motifAppel"] = txbMotif.Text;
                rowMission["adresse"] = txbRue.Text;
                rowMission["cp"] = txbCodePostal.Text;
                rowMission["ville"] = txbVille.Text;
                rowMission["terminee"] = 0;
                rowMission["idNatureSinistre"] = cbxNatureSinistre.SelectedValue;
                rowMission["idCaserne"] = cbxCaserne.SelectedValue;
                MesDatas.DsGlobal.Tables["Mission"].Rows.Add(rowMission);

                // Ajouter dans PartirAvec + mettre à jour Engin
                foreach (DataRow vehicule in pompierVehiculeMission.Tables["Vehicules"].Rows)
                {
                    // Ajouter PartirAvec
                    DataRow rowPartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"].NewRow();
                    rowPartirAvec["idCaserne"] = vehicule["Caserne"];
                    rowPartirAvec["codeTypeEngin"] = vehicule["Type"];
                    rowPartirAvec["numeroEngin"] = vehicule["Numero"];
                    rowPartirAvec["idMission"] = numeroMission;
                    MesDatas.DsGlobal.Tables["PartirAvec"].Rows.Add(rowPartirAvec);

                    // Modifier enMission dans Engin
                    DataRow[] engin = MesDatas.DsGlobal.Tables["Engin"].Select(
                        $"idCaserne = {vehicule["Caserne"]} AND codeTypeEngin = '{vehicule["Type"]}' AND numero = {vehicule["Numero"]}"
                    );
                    if (engin.Length > 0)
                    {
                        engin[0]["enMission"] = 1;
                    }
                }

                // Ajouter dans Mobiliser
                foreach (DataRow pompier in pompierVehiculeMission.Tables["Pompiers"].Rows)
                {
                    DataRow rowMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"].NewRow();
                    rowMobiliser["matriculePompier"] = pompier["matricule"];
                    rowMobiliser["idMission"] = numeroMission;
                    rowMobiliser["idHabilitation"] = pompier["habilitation"];
                    MesDatas.DsGlobal.Tables["Mobiliser"].Rows.Add(rowMobiliser);
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                txbVille.BackColor = txbVille.Text == "" ? ColorTranslator.FromHtml("#ff9c9c") : Color.White;
                txbRue.BackColor = txbRue.Text == "" ? ColorTranslator.FromHtml("#ff9c9c") : Color.White;
                txbCodePostal.BackColor = txbCodePostal.Text == "" ? ColorTranslator.FromHtml("#ff9c9c") : Color.White;
                txbMotif.BackColor = txbMotif.Text == "" ? ColorTranslator.FromHtml("#ff9c9c") : Color.White;
                btnConstituer.BackColor = pompierVehiculeMission == null ? ColorTranslator.FromHtml("#ff9c9c") : Color.White;
                lblChampsIncomplets.BackColor = ColorTranslator.FromHtml("#ff9c9c");
                lblChampsIncomplets.Visible = true;
            }
        }

        private void txbCodePostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bloque la saisie si ce n’est pas un chiffre ou une touche de contrôle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            else
            {
                txbCodePostal.BackColor = Color.White;
            }

            // Empêche d'écrire plus de 5 chiffres
            if (!char.IsControl(e.KeyChar) && txbCodePostal.Text.Length >= 5)
            {
                e.Handled = true;
            }

            // Empêche le collage via Ctrl+V
            if ((ModifierKeys == Keys.Control) && (e.KeyChar == 22)) // 22 = Ctrl+V
            {
                e.Handled = true;
            }
        }

        private void txbMotif_TextChanged(object sender, EventArgs e)
        {
            txbMotif.BackColor = Color.White;
        }

        private void txbRue_TextChanged(object sender, EventArgs e)
        {
            txbRue.BackColor = Color.White;
        }

        private void txbVille_TextChanged(object sender, EventArgs e)
        {
            txbVille.BackColor = Color.White;
        }
    }
}
