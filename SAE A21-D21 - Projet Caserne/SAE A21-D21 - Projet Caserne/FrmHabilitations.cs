using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
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
                UC_Habilitation uc = new UC_Habilitation(Convert.ToInt16(habilitation["id"]));
                uc.Location = new Point(4, hauteur);

                pnlHabilitations.Controls.Add(uc);

                hauteur += 30;
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
                foreach (Control ctrl in pnlHabilitations.Controls)
                {
                    if (ctrl is UC_Habilitation uc)
                    {
                        if (uc.estCheck())
                        {
                            if (!uc.dateChange())
                            {
                                MessageBox.Show("Veuillez selectionner la date d'obtention des habilitations");
                                return;
                            }

                            // Si c'est le premier uc check qu'on traite
                            else if (m_requete == "SELECT 1")
                            {
                                // Initialise avec un insert into
                                m_requete = $"INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention) " +
                                            $"VALUES ({m_matricule}, {uc.getIdHabilitation()}, '{uc.getDateHabilitation():yyyy-MM-dd}')";
                            }

                            // Si c'est pas le premier
                            else
                            {
                                // Ajoute une autre ligne au insert into, syntaxe : INSERT INTO xx (xx, xx,xx), (xx,xx,xx), ... Rajoute plusieurs lignes en une commande
                                m_requete += $", ({m_matricule}, {uc.getIdHabilitation()}, '{uc.getDateHabilitation():yyyy-MM-dd}')";
                            }
                        }
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
