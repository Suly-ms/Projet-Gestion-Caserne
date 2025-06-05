using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pinpon;
using static System.Net.WebRequestMethods;

namespace SAE_A21_D21___Projet_Caserne
{
    public partial class FrmHabilitations : Form
    {
        // Ouvre la connexion
        SQLiteConnection connec = Connexion.Connec;

        private int m_matricule;

        private string m_requete = "SELECT 1";

        private DateTime m_aujourdHui = DateTime.Today;

        public FrmHabilitations(int matricule)
        {
            InitializeComponent();

            m_matricule = matricule;

            // Empeche de mettre en pleine ecran
            this.MaximizeBox = false;

            // Empeche le redimensionnement
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FrmHabilitations_Load(object sender, EventArgs e)
        {
            DataTable tableHabilitations = MesDatas.DsGlobal.Tables["Habilitation"];
            DataRow[] habilitations = tableHabilitations.Select();

            int hauteur = 30;
            foreach (DataRow habilitation in habilitations) 
            {
                CheckBox cbx = new CheckBox();
                cbx.Tag = Convert.ToInt16(habilitation["id"]);
                cbx.Text = Convert.ToString(habilitation["libelle"]);

                cbx.Location = new Point(8, hauteur);
                cbx.AutoSize = true;

                pnlHabilitations.Controls.Add(cbx);

                // Création du DateTimePicker caché associé
                DateTimePicker dtp = new DateTimePicker();

                // A droit du checkedBox
                dtp.Location = new Point(274, hauteur + 3);
                dtp.Tag = cbx.Tag;

                dtp.Size = new Size(13, 8);
                dtp.Font = new Font(FontFamily.GenericSansSerif, 2, FontStyle.Regular);

                dtp.MaxDate = DateTime.Today;
                dtp.Value = m_aujourdHui;

                pnlHabilitations.Controls.Add(dtp);


                hauteur += 20;
            }

            CheckBox osef = new CheckBox();

            // Permet d'afficher le checkBox caché par le pannel du bas (avec les bouton valider et fermer) (ce checkbox on le verra pas car caché)
            osef.Location = new Point(4, hauteur + 5);

            pnlHabilitations.Controls.Add(osef);
        }

        private void clbHabilitations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;

                foreach (Control ctrl in pnlHabilitations.Controls)
                {
                    if (ctrl is CheckBox cbx && cbx.Checked)
                    {
                        int idHabilitation = Convert.ToInt16(cbx.Tag);

                        // Chercher le DateTimePicker associé (avec le même Tag)
                        DateTime dateHabilitation = new DateTime();

                        foreach (Control ctrl2 in pnlHabilitations.Controls)
                        {
                            if (ctrl2 is DateTimePicker dtp && dtp.Tag != null && dtp.Tag == cbx.Tag)
                            {
                                dateHabilitation = dtp.Value;
                                break;
                            }
                        }

                        if (dateHabilitation == m_aujourdHui)
                        {
                            MessageBox.Show("Veuillez selectionner la date d'obtention des habilitations");
                            return;
                        }

                        else if (count == 0)
                        {
                            m_requete = $"INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention) " +
                                        $"VALUES ({m_matricule}, {idHabilitation}, '{dateHabilitation:yyyy-MM-dd}')";
                        }
                        else
                        {
                            m_requete += $", ({m_matricule}, {idHabilitation}, '{dateHabilitation:yyyy-MM-dd}')";
                        }
                        count++;
                    }
                }

                this.DialogResult = DialogResult.OK;
            } 
            catch (Exception)
            {
                MessageBox.Show("L'ajout du pompier a échoué");
            }
            
        }

        public string RequeteSQL
        {
            get { return m_requete; }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
