namespace SAE_A21_D21___Projet_Caserne
{
    partial class frmGestionNouvelleMission
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.lblNouvelleMission = new System.Windows.Forms.Label();
            this.lblDateDelenchement = new System.Windows.Forms.Label();
            this.gbxInformationUsager = new System.Windows.Forms.GroupBox();
            this.txbVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txbCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.txbRue = new System.Windows.Forms.TextBox();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblAdresseSinistre = new System.Windows.Forms.Label();
            this.txbMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.gbxDecisionRegul = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConstituer = new System.Windows.Forms.Button();
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.cbxNatureSinistre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.gbxMobilisation = new System.Windows.Forms.GroupBox();
            this.lblEnginsMobilises = new System.Windows.Forms.Label();
            this.lblPompiersMobilises = new System.Windows.Forms.Label();
            this.dgvPompiersMobilises = new System.Windows.Forms.DataGridView();
            this.dgvEnginsMobilises = new System.Windows.Forms.DataGridView();
            this.gbxInformationUsager.SuspendLayout();
            this.gbxDecisionRegul.SuspendLayout();
            this.gbxMobilisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiersMobilises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginsMobilises)).BeginInit();
            this.SuspendLayout();
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // lblNouvelleMission
            // 
            this.lblNouvelleMission.AutoSize = true;
            this.lblNouvelleMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNouvelleMission.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNouvelleMission.Location = new System.Drawing.Point(255, 27);
            this.lblNouvelleMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNouvelleMission.Name = "lblNouvelleMission";
            this.lblNouvelleMission.Size = new System.Drawing.Size(129, 29);
            this.lblNouvelleMission.TabIndex = 0;
            this.lblNouvelleMission.Text = "Mission n° ";
            // 
            // lblDateDelenchement
            // 
            this.lblDateDelenchement.AutoSize = true;
            this.lblDateDelenchement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDelenchement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateDelenchement.Location = new System.Drawing.Point(732, 27);
            this.lblDateDelenchement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDelenchement.Name = "lblDateDelenchement";
            this.lblDateDelenchement.Size = new System.Drawing.Size(172, 29);
            this.lblDateDelenchement.TabIndex = 1;
            this.lblDateDelenchement.Text = "Déclenché le : ";
            // 
            // gbxInformationUsager
            // 
            this.gbxInformationUsager.Controls.Add(this.txbVille);
            this.gbxInformationUsager.Controls.Add(this.lblVille);
            this.gbxInformationUsager.Controls.Add(this.txbCodePostal);
            this.gbxInformationUsager.Controls.Add(this.lblCodePostale);
            this.gbxInformationUsager.Controls.Add(this.txbRue);
            this.gbxInformationUsager.Controls.Add(this.lblRue);
            this.gbxInformationUsager.Controls.Add(this.lblAdresseSinistre);
            this.gbxInformationUsager.Controls.Add(this.txbMotif);
            this.gbxInformationUsager.Controls.Add(this.lblMotif);
            this.gbxInformationUsager.Location = new System.Drawing.Point(47, 80);
            this.gbxInformationUsager.Name = "gbxInformationUsager";
            this.gbxInformationUsager.Size = new System.Drawing.Size(1051, 242);
            this.gbxInformationUsager.TabIndex = 2;
            this.gbxInformationUsager.TabStop = false;
            this.gbxInformationUsager.Text = "Information usager";
            // 
            // txbVille
            // 
            this.txbVille.Location = new System.Drawing.Point(582, 162);
            this.txbVille.Name = "txbVille";
            this.txbVille.Size = new System.Drawing.Size(452, 27);
            this.txbVille.TabIndex = 11;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVille.Location = new System.Drawing.Point(507, 163);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(44, 22);
            this.lblVille.TabIndex = 10;
            this.lblVille.Text = "Ville";
            // 
            // txbCodePostal
            // 
            this.txbCodePostal.Location = new System.Drawing.Point(622, 119);
            this.txbCodePostal.Name = "txbCodePostal";
            this.txbCodePostal.Size = new System.Drawing.Size(102, 27);
            this.txbCodePostal.TabIndex = 9;
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodePostale.Location = new System.Drawing.Point(507, 120);
            this.lblCodePostale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(108, 22);
            this.lblCodePostale.TabIndex = 8;
            this.lblCodePostale.Text = "Code Postal";
            // 
            // txbRue
            // 
            this.txbRue.Location = new System.Drawing.Point(582, 76);
            this.txbRue.Name = "txbRue";
            this.txbRue.Size = new System.Drawing.Size(452, 27);
            this.txbRue.TabIndex = 7;
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRue.Location = new System.Drawing.Point(507, 77);
            this.lblRue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(53, 22);
            this.lblRue.TabIndex = 6;
            this.lblRue.Text = "Rue :";
            // 
            // lblAdresseSinistre
            // 
            this.lblAdresseSinistre.AutoSize = true;
            this.lblAdresseSinistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresseSinistre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdresseSinistre.Location = new System.Drawing.Point(736, 34);
            this.lblAdresseSinistre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresseSinistre.Name = "lblAdresseSinistre";
            this.lblAdresseSinistre.Size = new System.Drawing.Size(58, 22);
            this.lblAdresseSinistre.TabIndex = 5;
            this.lblAdresseSinistre.Text = "Motif :";
            // 
            // txbMotif
            // 
            this.txbMotif.Location = new System.Drawing.Point(77, 33);
            this.txbMotif.Multiline = true;
            this.txbMotif.Name = "txbMotif";
            this.txbMotif.Size = new System.Drawing.Size(423, 187);
            this.txbMotif.TabIndex = 4;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMotif.Location = new System.Drawing.Point(12, 33);
            this.lblMotif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(58, 22);
            this.lblMotif.TabIndex = 3;
            this.lblMotif.Text = "Motif :";
            // 
            // gbxDecisionRegul
            // 
            this.gbxDecisionRegul.Controls.Add(this.btnAnnuler);
            this.gbxDecisionRegul.Controls.Add(this.btnConstituer);
            this.gbxDecisionRegul.Controls.Add(this.cbxCaserne);
            this.gbxDecisionRegul.Controls.Add(this.lblCaserne);
            this.gbxDecisionRegul.Controls.Add(this.cbxNatureSinistre);
            this.gbxDecisionRegul.Controls.Add(this.label1);
            this.gbxDecisionRegul.Location = new System.Drawing.Point(47, 343);
            this.gbxDecisionRegul.Name = "gbxDecisionRegul";
            this.gbxDecisionRegul.Size = new System.Drawing.Size(1051, 148);
            this.gbxDecisionRegul.TabIndex = 3;
            this.gbxDecisionRegul.TabStop = false;
            this.gbxDecisionRegul.Text = "Décisions régulateur";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(727, 81);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(115, 42);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnConstituer
            // 
            this.btnConstituer.Location = new System.Drawing.Point(848, 81);
            this.btnConstituer.Name = "btnConstituer";
            this.btnConstituer.Size = new System.Drawing.Size(180, 42);
            this.btnConstituer.TabIndex = 16;
            this.btnConstituer.Text = "Constituer Equipe";
            this.btnConstituer.UseVisualStyleBackColor = true;
            this.btnConstituer.Click += new System.EventHandler(this.btnConstituer_Click);
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(616, 35);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(412, 28);
            this.cbxCaserne.TabIndex = 15;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCaserne.Location = new System.Drawing.Point(521, 35);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(88, 22);
            this.lblCaserne.TabIndex = 14;
            this.lblCaserne.Text = "Caserne :";
            // 
            // cbxNatureSinistre
            // 
            this.cbxNatureSinistre.FormattingEnabled = true;
            this.cbxNatureSinistre.Location = new System.Drawing.Point(180, 34);
            this.cbxNatureSinistre.Name = "cbxNatureSinistre";
            this.cbxNatureSinistre.Size = new System.Drawing.Size(329, 28);
            this.cbxNatureSinistre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nature du sinistre :";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(953, 737);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(180, 42);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // gbxMobilisation
            // 
            this.gbxMobilisation.Controls.Add(this.dgvEnginsMobilises);
            this.gbxMobilisation.Controls.Add(this.dgvPompiersMobilises);
            this.gbxMobilisation.Controls.Add(this.lblPompiersMobilises);
            this.gbxMobilisation.Controls.Add(this.lblEnginsMobilises);
            this.gbxMobilisation.Location = new System.Drawing.Point(47, 497);
            this.gbxMobilisation.Name = "gbxMobilisation";
            this.gbxMobilisation.Size = new System.Drawing.Size(1051, 234);
            this.gbxMobilisation.TabIndex = 18;
            this.gbxMobilisation.TabStop = false;
            this.gbxMobilisation.Text = "Mobilisation des engins et des pompiers";
            this.gbxMobilisation.Visible = false;
            // 
            // lblEnginsMobilises
            // 
            this.lblEnginsMobilises.AutoSize = true;
            this.lblEnginsMobilises.Location = new System.Drawing.Point(201, 30);
            this.lblEnginsMobilises.Name = "lblEnginsMobilises";
            this.lblEnginsMobilises.Size = new System.Drawing.Size(136, 20);
            this.lblEnginsMobilises.TabIndex = 0;
            this.lblEnginsMobilises.Text = "Engins Mobilisés";
            // 
            // lblPompiersMobilises
            // 
            this.lblPompiersMobilises.AutoSize = true;
            this.lblPompiersMobilises.Location = new System.Drawing.Point(723, 30);
            this.lblPompiersMobilises.Name = "lblPompiersMobilises";
            this.lblPompiersMobilises.Size = new System.Drawing.Size(156, 20);
            this.lblPompiersMobilises.TabIndex = 1;
            this.lblPompiersMobilises.Text = "Pompiers Mobilisés";
            // 
            // dgvPompiersMobilises
            // 
            this.dgvPompiersMobilises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompiersMobilises.Location = new System.Drawing.Point(549, 63);
            this.dgvPompiersMobilises.Name = "dgvPompiersMobilises";
            this.dgvPompiersMobilises.RowHeadersWidth = 51;
            this.dgvPompiersMobilises.RowTemplate.Height = 24;
            this.dgvPompiersMobilises.Size = new System.Drawing.Size(479, 155);
            this.dgvPompiersMobilises.TabIndex = 3;
            // 
            // dgvEnginsMobilises
            // 
            this.dgvEnginsMobilises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnginsMobilises.Location = new System.Drawing.Point(29, 63);
            this.dgvEnginsMobilises.Name = "dgvEnginsMobilises";
            this.dgvEnginsMobilises.RowHeadersWidth = 51;
            this.dgvEnginsMobilises.RowTemplate.Height = 24;
            this.dgvEnginsMobilises.Size = new System.Drawing.Size(492, 155);
            this.dgvEnginsMobilises.TabIndex = 4;
            // 
            // frmGestionNouvelleMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1145, 791);
            this.Controls.Add(this.gbxMobilisation);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.gbxDecisionRegul);
            this.Controls.Add(this.gbxInformationUsager);
            this.Controls.Add(this.lblDateDelenchement);
            this.Controls.Add(this.lblNouvelleMission);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmGestionNouvelleMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des nouvelles missions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxInformationUsager.ResumeLayout(false);
            this.gbxInformationUsager.PerformLayout();
            this.gbxDecisionRegul.ResumeLayout(false);
            this.gbxDecisionRegul.PerformLayout();
            this.gbxMobilisation.ResumeLayout(false);
            this.gbxMobilisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiersMobilises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnginsMobilises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label lblNouvelleMission;
        private System.Windows.Forms.Label lblDateDelenchement;
        private System.Windows.Forms.GroupBox gbxInformationUsager;
        private System.Windows.Forms.TextBox txbMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txbRue;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblAdresseSinistre;
        private System.Windows.Forms.TextBox txbVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txbCodePostal;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.GroupBox gbxDecisionRegul;
        private System.Windows.Forms.ComboBox cbxNatureSinistre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Button btnConstituer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox gbxMobilisation;
        private System.Windows.Forms.Label lblPompiersMobilises;
        private System.Windows.Forms.Label lblEnginsMobilises;
        private System.Windows.Forms.DataGridView dgvPompiersMobilises;
        private System.Windows.Forms.DataGridView dgvEnginsMobilises;
    }
}

