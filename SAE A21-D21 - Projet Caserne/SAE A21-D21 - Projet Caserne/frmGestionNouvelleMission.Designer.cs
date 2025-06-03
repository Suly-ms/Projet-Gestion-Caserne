namespace SAE_A21_D21___Projet_Caserne
{
    partial class FrmGestionNouvelleMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionNouvelleMission));
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.lblNouvelleMission = new System.Windows.Forms.Label();
            this.lblDateDelenchement = new System.Windows.Forms.Label();
            this.lblMax6Caracteres = new System.Windows.Forms.Label();
            this.txbVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txbCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.txbRue = new System.Windows.Forms.TextBox();
            this.lblRue = new System.Windows.Forms.Label();
            this.txbMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnConstituer = new System.Windows.Forms.Button();
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.cbxNatureSinistre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblChampsIncomplets = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.lblNouvelleMission.BackColor = System.Drawing.Color.Transparent;
            this.lblNouvelleMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNouvelleMission.ForeColor = System.Drawing.Color.Black;
            this.lblNouvelleMission.Location = new System.Drawing.Point(204, 10);
            this.lblNouvelleMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNouvelleMission.Name = "lblNouvelleMission";
            this.lblNouvelleMission.Size = new System.Drawing.Size(140, 29);
            this.lblNouvelleMission.TabIndex = 0;
            this.lblNouvelleMission.Text = "Mission n° ";
            // 
            // lblDateDelenchement
            // 
            this.lblDateDelenchement.AutoSize = true;
            this.lblDateDelenchement.BackColor = System.Drawing.Color.Transparent;
            this.lblDateDelenchement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDelenchement.ForeColor = System.Drawing.Color.Black;
            this.lblDateDelenchement.Location = new System.Drawing.Point(204, 39);
            this.lblDateDelenchement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDelenchement.Name = "lblDateDelenchement";
            this.lblDateDelenchement.Size = new System.Drawing.Size(187, 29);
            this.lblDateDelenchement.TabIndex = 1;
            this.lblDateDelenchement.Text = "Déclenché le : ";
            // 
            // lblMax6Caracteres
            // 
            this.lblMax6Caracteres.AutoSize = true;
            this.lblMax6Caracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax6Caracteres.Location = new System.Drawing.Point(255, 205);
            this.lblMax6Caracteres.Name = "lblMax6Caracteres";
            this.lblMax6Caracteres.Size = new System.Drawing.Size(244, 20);
            this.lblMax6Caracteres.TabIndex = 18;
            this.lblMax6Caracteres.Text = "Maximum de 6 nombres entiers";
            // 
            // txbVille
            // 
            this.txbVille.Location = new System.Drawing.Point(147, 245);
            this.txbVille.Name = "txbVille";
            this.txbVille.Size = new System.Drawing.Size(391, 27);
            this.txbVille.TabIndex = 11;
            this.txbVille.TextChanged += new System.EventHandler(this.txbVille_TextChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.Color.Black;
            this.lblVille.Location = new System.Drawing.Point(22, 245);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(54, 22);
            this.lblVille.TabIndex = 10;
            this.lblVille.Text = "Ville :";
            // 
            // txbCodePostal
            // 
            this.txbCodePostal.Location = new System.Drawing.Point(147, 202);
            this.txbCodePostal.Name = "txbCodePostal";
            this.txbCodePostal.Size = new System.Drawing.Size(102, 27);
            this.txbCodePostal.TabIndex = 9;
            this.txbCodePostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCodePostal_KeyPress);
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostale.ForeColor = System.Drawing.Color.Black;
            this.lblCodePostale.Location = new System.Drawing.Point(22, 202);
            this.lblCodePostale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(118, 22);
            this.lblCodePostale.TabIndex = 8;
            this.lblCodePostale.Text = "Code Postal :";
            // 
            // txbRue
            // 
            this.txbRue.Location = new System.Drawing.Point(147, 159);
            this.txbRue.Name = "txbRue";
            this.txbRue.Size = new System.Drawing.Size(391, 27);
            this.txbRue.TabIndex = 7;
            this.txbRue.TextChanged += new System.EventHandler(this.txbRue_TextChanged);
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.ForeColor = System.Drawing.Color.Black;
            this.lblRue.Location = new System.Drawing.Point(22, 159);
            this.lblRue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(53, 22);
            this.lblRue.TabIndex = 6;
            this.lblRue.Text = "Rue :";
            // 
            // txbMotif
            // 
            this.txbMotif.Location = new System.Drawing.Point(24, 41);
            this.txbMotif.Multiline = true;
            this.txbMotif.Name = "txbMotif";
            this.txbMotif.Size = new System.Drawing.Size(514, 102);
            this.txbMotif.TabIndex = 4;
            this.txbMotif.TextChanged += new System.EventHandler(this.txbMotif_TextChanged);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.ForeColor = System.Drawing.Color.Black;
            this.lblMotif.Location = new System.Drawing.Point(253, 16);
            this.lblMotif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(58, 22);
            this.lblMotif.TabIndex = 3;
            this.lblMotif.Text = "Motif :";
            // 
            // btnConstituer
            // 
            this.btnConstituer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstituer.ForeColor = System.Drawing.Color.Red;
            this.btnConstituer.Location = new System.Drawing.Point(190, 108);
            this.btnConstituer.Name = "btnConstituer";
            this.btnConstituer.Size = new System.Drawing.Size(180, 69);
            this.btnConstituer.TabIndex = 16;
            this.btnConstituer.Text = "Choisir Véhicule(s) et Pompier(s)";
            this.btnConstituer.UseVisualStyleBackColor = true;
            this.btnConstituer.Click += new System.EventHandler(this.btnConstituer_Click);
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(190, 60);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(348, 28);
            this.cbxCaserne.TabIndex = 15;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.ForeColor = System.Drawing.Color.Black;
            this.lblCaserne.Location = new System.Drawing.Point(22, 60);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(88, 22);
            this.lblCaserne.TabIndex = 14;
            this.lblCaserne.Text = "Caserne :";
            // 
            // cbxNatureSinistre
            // 
            this.cbxNatureSinistre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNatureSinistre.FormattingEnabled = true;
            this.cbxNatureSinistre.Location = new System.Drawing.Point(190, 19);
            this.cbxNatureSinistre.Name = "cbxNatureSinistre";
            this.cbxNatureSinistre.Size = new System.Drawing.Size(348, 28);
            this.cbxNatureSinistre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nature du sinistre :";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Red;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(14, 602);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(150, 42);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(430, 602);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(150, 42);
            this.btnValider.TabIndex = 19;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblChampsIncomplets
            // 
            this.lblChampsIncomplets.AutoSize = true;
            this.lblChampsIncomplets.BackColor = System.Drawing.Color.Red;
            this.lblChampsIncomplets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChampsIncomplets.Location = new System.Drawing.Point(182, 608);
            this.lblChampsIncomplets.Name = "lblChampsIncomplets";
            this.lblChampsIncomplets.Size = new System.Drawing.Size(242, 29);
            this.lblChampsIncomplets.TabIndex = 20;
            this.lblChampsIncomplets.Text = "Champs Incomplets";
            this.lblChampsIncomplets.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.lblNouvelleMission);
            this.panel1.Controls.Add(this.lblDateDelenchement);
            this.panel1.Location = new System.Drawing.Point(16, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 73);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.lblMax6Caracteres);
            this.panel2.Controls.Add(this.txbVille);
            this.panel2.Controls.Add(this.lblMotif);
            this.panel2.Controls.Add(this.txbMotif);
            this.panel2.Controls.Add(this.lblVille);
            this.panel2.Controls.Add(this.txbCodePostal);
            this.panel2.Controls.Add(this.lblRue);
            this.panel2.Controls.Add(this.lblCodePostale);
            this.panel2.Controls.Add(this.txbRue);
            this.panel2.Location = new System.Drawing.Point(16, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 292);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.btnConstituer);
            this.panel3.Controls.Add(this.cbxCaserne);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblCaserne);
            this.panel3.Controls.Add(this.cbxNatureSinistre);
            this.panel3.Location = new System.Drawing.Point(16, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 192);
            this.panel3.TabIndex = 23;
            // 
            // FrmGestionNouvelleMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(597, 654);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblChampsIncomplets);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmGestionNouvelleMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des nouvelles missions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label lblNouvelleMission;
        private System.Windows.Forms.Label lblDateDelenchement;
        private System.Windows.Forms.TextBox txbMotif;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txbRue;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.TextBox txbVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txbCodePostal;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.ComboBox cbxNatureSinistre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Button btnConstituer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblChampsIncomplets;
        private System.Windows.Forms.Label lblMax6Caracteres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

