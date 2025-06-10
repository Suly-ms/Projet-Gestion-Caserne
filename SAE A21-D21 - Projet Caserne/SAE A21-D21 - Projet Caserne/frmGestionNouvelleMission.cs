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
            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void FrmGestionNouvelleMission_Load(object sender, EventArgs e)
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
                insertIntoMission.CommandText = $"INSERT INTO Mission(id, dateHeureDepart, motifAppel, adresse, cp, ville, terminee, idNatureSinistre, idCaserne) VALUES({numeroMission}, '{DateTime.Now:yyyy-MM-dd HH:mm}', '{txbMotif.Text.Replace("'", "''")}', '{txbRue.Text.Replace("'", "''")}', '{txbCodePostal.Text.Replace("'", "''")}', '{txbVille.Text.Replace("'", "''")}', 0, {cbxNatureSinistre.SelectedValue}, {cbxCaserne.SelectedValue})";
                insertIntoMission.ExecuteNonQuery();

                DataRow[] Vehicules = pompierVehiculeMission.Tables["Vehicules"].Select();
                foreach (DataRow row in Vehicules)
                {
                    insertIntoMission.CommandText = $@"INSERT INTO PartirAvec
                                               VALUES({row["Caserne"]}, '{row["Type"]}', '{row["Numero"]}', {numeroMission}, NULL);";
                    insertIntoMission.ExecuteNonQuery();
                    insertIntoMission.CommandText = $@"UPDATE Engin
                                               SET enMission = 1 WHERE codeTypeEngin = '{row["Type"]}' AND numero = { row["Numero"]} AND idCaserne = {row["Caserne"]};";
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
                btnConstituerManuel.BackColor = pompierVehiculeMission == null ? ColorTranslator.FromHtml("#ff9c9c") : Color.White;
                btnConstituerAutomatique.BackColor = pompierVehiculeMission == null ? ColorTranslator.FromHtml("#ff9c9c") : Color.White;
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

        private void btnConstituerAutomatique_Click(object sender, EventArgs e)
        {
            // Vérification
            if (cbxNatureSinistre.SelectedValue == null || cbxCaserne.SelectedValue == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner une nature de sinistre et une caserne.");
                return;
            }

            int idNature = Convert.ToInt32(cbxNatureSinistre.SelectedValue);
            int idCaserne = Convert.ToInt32(cbxCaserne.SelectedValue);

            // Création d'un DataSet temporaire
            DataSet dsAuto = new DataSet();

            // Création des tables avec la même structure que dans FrmChoixVehiculesPompier
            DataTable tableVehicule = new DataTable("Vehicules");
            tableVehicule.Columns.Add("Numero", typeof(int));
            tableVehicule.Columns.Add("Type", typeof(string));
            tableVehicule.Columns.Add("Caserne", typeof(int));
            dsAuto.Tables.Add(tableVehicule);

            DataTable tablePompier = new DataTable("Pompiers");
            tablePompier.Columns.Add("Nom", typeof(string));
            tablePompier.Columns.Add("Prenom", typeof(string));
            tablePompier.Columns.Add("Grade", typeof(string));
            tablePompier.Columns.Add("matricule", typeof(int));
            tablePompier.Columns.Add("habilitation", typeof(int));
            tablePompier.Columns.Add("vehicule", typeof(string));
            dsAuto.Tables.Add(tablePompier);

            // Récupération des véhicules nécessaires pour le sinistre
            var besoins = MesDatas.DsGlobal.Tables["Necessiter"].Select($"idNatureSinistre = {idNature}");

            foreach (var besoin in besoins)
            {
                string typeEngin = besoin["codeTypeEngin"].ToString();
                int quantite = Convert.ToInt32(besoin["nombre"]);
                int nbVehiculesAjoutes = 0;

                // D'abord essayer dans la caserne sélectionnée
                var enginsDispoCaserne = MesDatas.DsGlobal.Tables["Engin"].Select(
                    $"idCaserne = {idCaserne} AND codeTypeEngin = '{typeEngin}' AND enMission = 0 AND enPanne = 0"
                );

                // Ajouter les véhicules de la caserne sélectionnée
                for (int i = 0; i < Math.Min(quantite, enginsDispoCaserne.Length); i++)
                {
                    tableVehicule.Rows.Add(
                        enginsDispoCaserne[i]["numero"],
                        enginsDispoCaserne[i]["codeTypeEngin"],
                        enginsDispoCaserne[i]["idCaserne"]
                    );
                    nbVehiculesAjoutes++;
                }

                // Si on n'a pas assez de véhicules, chercher dans les autres casernes
                if (nbVehiculesAjoutes < quantite)
                {
                    // Récupérer toutes les casernes sauf celle sélectionnée
                    var autresCasernes = MesDatas.DsGlobal.Tables["Caserne"].AsEnumerable()
                        .Where(c => Convert.ToInt32(c["id"]) != idCaserne);

                    foreach (DataRow autreCaserne in autresCasernes)
                    {
                        if (nbVehiculesAjoutes >= quantite) break;

                        int idAutreCaserne = Convert.ToInt32(autreCaserne["id"]);
                        var enginsDispoAutreCaserne = MesDatas.DsGlobal.Tables["Engin"].Select(
                            $"idCaserne = {idAutreCaserne} AND codeTypeEngin = '{typeEngin}' AND enMission = 0 AND enPanne = 0"
                        );

                        for (int i = 0; i < enginsDispoAutreCaserne.Length; i++)
                        {
                            if (nbVehiculesAjoutes >= quantite) break;

                            tableVehicule.Rows.Add(
                                enginsDispoAutreCaserne[i]["numero"],
                                enginsDispoAutreCaserne[i]["codeTypeEngin"],
                                enginsDispoAutreCaserne[i]["idCaserne"]
                            );
                            nbVehiculesAjoutes++;
                        }
                    }
                }
            }

            // Pour chaque véhicule, on récupère les habilitations nécessaires
            foreach (DataRow vehicule in tableVehicule.Rows)
            {
                string typeEngin = vehicule["Type"].ToString();
                int idCaserneVehicule = Convert.ToInt32(vehicule["Caserne"]);
                var habilitationsNecessaires = MesDatas.DsGlobal.Tables["Embarquer"].Select($"codeTypeEngin = '{typeEngin}'");

                foreach (var habilitation in habilitationsNecessaires)
                {
                    int idHabilitation = Convert.ToInt32(habilitation["idHabilitation"]);
                    int nombreNecessaire = Convert.ToInt32(habilitation["nombre"]);

                    // Recherche des pompiers disponibles avec l'habilitation requise
                    var pompiersDispo = MesDatas.DsGlobal.Tables["Pompier"].Select(
                        "enMission = 0 AND enConge = 0"
                    );

                    var affectations = MesDatas.DsGlobal.Tables["Affectation"].Select(
                        $"idCaserne = {idCaserneVehicule} AND dateFin IS NULL"
                    );

                    var habilitations = MesDatas.DsGlobal.Tables["Passer"].Select(
                        $"idHabilitation = {idHabilitation}"
                    );

                    int nbPompiersAjoutes = 0;
                    foreach (DataRow pompier in pompiersDispo)
                    {
                        if (nbPompiersAjoutes >= nombreNecessaire) break;

                        int matricule = Convert.ToInt32(pompier["matricule"]);

                        // Vérifier si le pompier est affecté à la caserne du véhicule
                        bool estAffecte = affectations.Any(a =>
                            Convert.ToInt32(a["matriculePompier"]) == matricule
                        );

                        // Vérifier si le pompier a l'habilitation requise
                        bool aHabilitation = habilitations.Any(h =>
                            Convert.ToInt32(h["matriculePompier"]) == matricule
                        );

                        // Vérifier si le pompier n'est pas déjà ajouté
                        bool dejaAjoute = tablePompier.AsEnumerable().Any(r =>
                            Convert.ToInt32(r["matricule"]) == matricule
                        );

                        if (estAffecte && aHabilitation && !dejaAjoute)
                        {
                            tablePompier.Rows.Add(
                                pompier["nom"],
                                pompier["prenom"],
                                pompier["codeGrade"],
                                matricule,
                                idHabilitation,
                                typeEngin
                            );
                            nbPompiersAjoutes++;
                        }
                    }
                }
            }

            // Ouvrir le formulaire de choix automatique avec le DataSet
            FrmChoixVehiculesPompierAutomatique frmAuto = new FrmChoixVehiculesPompierAutomatique(dsAuto);
            if (frmAuto.ShowDialog() == DialogResult.OK)
            {
                pompierVehiculeMission = frmAuto.DataSetMission;
            }
        }
    }
}
