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
using Pinpon;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class FrmCreerPompier : Form
    {
        // Ouvre la connexion
        SQLiteConnection connec = Connexion.Connec;

        private UC_CreerPompier uc;
        public FrmCreerPompier()
        {
            InitializeComponent();

            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FrmCreerPompier_Load(object sender, EventArgs e)
        {
            DataTable tablePompiers = MesDatas.DsGlobal.Tables["Pompier"];
            DataRow[] pompiers = tablePompiers.Select();

            int matriculePompier = 0;
            int bipPompier = 0;

            foreach (DataRow pompier in pompiers)
            {
                int tmpMatricule = Convert.ToInt16(pompier["matricule"]);
                int tmpBip = Convert.ToInt16(pompier["bip"]);

                if (tmpMatricule > matriculePompier) matriculePompier = tmpMatricule;
                if (tmpBip > bipPompier) bipPompier = tmpBip;
            }
            matriculePompier++;
            bipPompier++;

            lblMatricule.Text = $"Matricule n°{matriculePompier}";
            lblBip.Text = $"Bip : {bipPompier}";

            uc = new UC_CreerPompier(matriculePompier, bipPompier);

            pnlAffichagePompier.Controls.Add(uc);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!uc.estRemplit())
            {
                MessageBox.Show("Veuillez saisir toutes les informations");
                return;
            }

            if (!uc.estMajeur()) 
            {
                MessageBox.Show("Le pompier doit être majeur.");
                return; 
            }

            try
            {
                DateTime maintenant = DateTime.Now;
                string nom = uc.getNom().Replace("\"", "''"); ;
                string prenom = uc.getPrenom().Replace("\"", "''"); ;
                string telephone = uc.getTelephone().Replace("\"", "''"); ;

                string requeteInsertPompier = $"INSERT INTO Pompier (matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche) " +
                                              $"VALUES ({uc.getMatricule()}, \"{nom}\", \"{prenom}\", \"{uc.getSexe()}\", \"{uc.getDateNaissance():yyyy-MM-dd}\", \"{uc.getType()}\", \"{telephone}\", {uc.getBip()}, 0, 0, \"{uc.getCodeGrade()}\", \"{maintenant:yyyy-MM-dd HH:mm:ss}\")";
                SQLiteCommand cdInsertPompier = new SQLiteCommand();
                cdInsertPompier.Connection = connec;
                cdInsertPompier.CommandType = CommandType.Text;
                cdInsertPompier.CommandText = requeteInsertPompier;
                cdInsertPompier.ExecuteNonQuery();


                string requeteInsertAffectation = $"INSERT INTO Affectation (matriculePompier, dateA, dateFin, idCaserne) " +
                                  $"VALUES ({uc.getMatricule()}, '{maintenant:yyyy-MM-dd HH:mm:ss}', NULL, {uc.getIdCaserne()})";
                SQLiteCommand cdInsertAffectation = new SQLiteCommand();
                cdInsertAffectation.Connection = connec;
                cdInsertAffectation.CommandText = requeteInsertAffectation;
                cdInsertAffectation.ExecuteNonQuery();

                // Recharger le dataSet
                DataTable schemaTable = connec.GetSchema("Tables");
                MesDatas.DsGlobal.Tables.Clear();

                string requete;
                foreach (DataRow ligne in schemaTable.Rows)
                {
                    requete = $"select * from {ligne[2].ToString()}";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(requete, connec);

                    da.Fill(MesDatas.DsGlobal, ligne[2].ToString());
                }

                MessageBox.Show($"Ajout du pompier {uc.getNom()} {uc.getPrenom()} a bien été effectué");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                DialogResult = DialogResult.OK;
            }
        }

        public int IndexCaserne
        {
            get { return uc.getIdCaserne(); }
        }
    }
}
