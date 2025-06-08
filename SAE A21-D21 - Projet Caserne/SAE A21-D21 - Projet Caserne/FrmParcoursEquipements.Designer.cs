namespace SAE_A21_D21___Projet_Caserne
{
    partial class FrmParcoursEquipements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcoursEquipements));
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.btnDroite = new System.Windows.Forms.Button();
            this.btnGauche = new System.Windows.Forms.Button();
            this.btnFullDroite = new System.Windows.Forms.Button();
            this.btnFullGauche = new System.Windows.Forms.Button();
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxEngin = new System.Windows.Forms.PictureBox();
            this.lblStatutDisponible = new System.Windows.Forms.Label();
            this.lblStatutPanne = new System.Windows.Forms.Label();
            this.lblStatutMission = new System.Windows.Forms.Label();
            this.lblDateReception = new System.Windows.Forms.Label();
            this.lblNumeroEngin = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.pnlEngin = new System.Windows.Forms.Panel();
            this.pnlStatCaserneTete = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngin)).BeginInit();
            this.pnlEngin.SuspendLayout();
            this.pnlStatCaserneTete.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // btnDroite
            // 
            this.btnDroite.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDroite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDroite.Location = new System.Drawing.Point(324, 316);
            this.btnDroite.Margin = new System.Windows.Forms.Padding(2);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(74, 27);
            this.btnDroite.TabIndex = 7;
            this.btnDroite.Text = ">";
            this.btnDroite.UseVisualStyleBackColor = false;
            this.btnDroite.Click += new System.EventHandler(this.btnDroite_Click);
            // 
            // btnGauche
            // 
            this.btnGauche.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGauche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGauche.Location = new System.Drawing.Point(225, 316);
            this.btnGauche.Margin = new System.Windows.Forms.Padding(2);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(74, 27);
            this.btnGauche.TabIndex = 6;
            this.btnGauche.Text = "<";
            this.btnGauche.UseVisualStyleBackColor = false;
            this.btnGauche.Click += new System.EventHandler(this.btnGauche_Click);
            // 
            // btnFullDroite
            // 
            this.btnFullDroite.BackColor = System.Drawing.Color.LawnGreen;
            this.btnFullDroite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullDroite.Location = new System.Drawing.Point(402, 316);
            this.btnFullDroite.Margin = new System.Windows.Forms.Padding(2);
            this.btnFullDroite.Name = "btnFullDroite";
            this.btnFullDroite.Size = new System.Drawing.Size(74, 27);
            this.btnFullDroite.TabIndex = 5;
            this.btnFullDroite.Text = ">>";
            this.btnFullDroite.UseVisualStyleBackColor = false;
            this.btnFullDroite.Click += new System.EventHandler(this.btnFullDroite_Click);
            // 
            // btnFullGauche
            // 
            this.btnFullGauche.BackColor = System.Drawing.Color.LawnGreen;
            this.btnFullGauche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullGauche.Location = new System.Drawing.Point(137, 317);
            this.btnFullGauche.Margin = new System.Windows.Forms.Padding(2);
            this.btnFullGauche.Name = "btnFullGauche";
            this.btnFullGauche.Size = new System.Drawing.Size(74, 27);
            this.btnFullGauche.TabIndex = 4;
            this.btnFullGauche.Text = "<<";
            this.btnFullGauche.UseVisualStyleBackColor = false;
            this.btnFullGauche.Click += new System.EventHandler(this.btnFullGauche_Click);
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(54, 46);
            this.cbxCaserne.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(394, 21);
            this.cbxCaserne.TabIndex = 0;
            this.cbxCaserne.SelectedIndexChanged += new System.EventHandler(this.cbxCaserne_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.pictureBoxEngin);
            this.groupBox2.Controls.Add(this.lblStatutDisponible);
            this.groupBox2.Controls.Add(this.lblStatutPanne);
            this.groupBox2.Controls.Add(this.lblStatutMission);
            this.groupBox2.Controls.Add(this.lblDateReception);
            this.groupBox2.Controls.Add(this.lblNumeroEngin);
            this.groupBox2.Controls.Add(this.lblStatut);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.lblNum);
            this.groupBox2.Location = new System.Drawing.Point(42, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(441, 207);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxEngin
            // 
            this.pictureBoxEngin.Location = new System.Drawing.Point(204, 37);
            this.pictureBoxEngin.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEngin.Name = "pictureBoxEngin";
            this.pictureBoxEngin.Size = new System.Drawing.Size(226, 136);
            this.pictureBoxEngin.TabIndex = 8;
            this.pictureBoxEngin.TabStop = false;
            // 
            // lblStatutDisponible
            // 
            this.lblStatutDisponible.AutoSize = true;
            this.lblStatutDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatutDisponible.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatutDisponible.Location = new System.Drawing.Point(62, 162);
            this.lblStatutDisponible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatutDisponible.Name = "lblStatutDisponible";
            this.lblStatutDisponible.Size = new System.Drawing.Size(66, 13);
            this.lblStatutDisponible.TabIndex = 7;
            this.lblStatutDisponible.Text = "Disponible";
            // 
            // lblStatutPanne
            // 
            this.lblStatutPanne.AutoSize = true;
            this.lblStatutPanne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatutPanne.Location = new System.Drawing.Point(62, 162);
            this.lblStatutPanne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatutPanne.Name = "lblStatutPanne";
            this.lblStatutPanne.Size = new System.Drawing.Size(61, 13);
            this.lblStatutPanne.TabIndex = 6;
            this.lblStatutPanne.Text = "En panne";
            // 
            // lblStatutMission
            // 
            this.lblStatutMission.AutoSize = true;
            this.lblStatutMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatutMission.Location = new System.Drawing.Point(62, 162);
            this.lblStatutMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatutMission.Name = "lblStatutMission";
            this.lblStatutMission.Size = new System.Drawing.Size(67, 13);
            this.lblStatutMission.TabIndex = 5;
            this.lblStatutMission.Text = "En mission";
            // 
            // lblDateReception
            // 
            this.lblDateReception.AutoSize = true;
            this.lblDateReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReception.Location = new System.Drawing.Point(113, 91);
            this.lblDateReception.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReception.Name = "lblDateReception";
            this.lblDateReception.Size = new System.Drawing.Size(71, 13);
            this.lblDateReception.TabIndex = 4;
            this.lblDateReception.Text = "01-01-1900";
            // 
            // lblNumeroEngin
            // 
            this.lblNumeroEngin.AutoSize = true;
            this.lblNumeroEngin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEngin.Location = new System.Drawing.Point(68, 28);
            this.lblNumeroEngin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroEngin.Name = "lblNumeroEngin";
            this.lblNumeroEngin.Size = new System.Drawing.Size(53, 13);
            this.lblNumeroEngin.TabIndex = 3;
            this.lblNumeroEngin.Text = "1-ABC-0";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(16, 162);
            this.lblStatut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(41, 13);
            this.lblStatut.TabIndex = 2;
            this.lblStatut.Text = "Statut :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 91);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date de réception :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(18, 28);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(50, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numéro :";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(11, 341);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(99, 31);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // pnlEngin
            // 
            this.pnlEngin.AutoScroll = true;
            this.pnlEngin.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlEngin.Controls.Add(this.panel3);
            this.pnlEngin.Controls.Add(this.btnFermer);
            this.pnlEngin.Controls.Add(this.btnDroite);
            this.pnlEngin.Controls.Add(this.btnFullDroite);
            this.pnlEngin.Controls.Add(this.btnFullGauche);
            this.pnlEngin.Controls.Add(this.btnGauche);
            this.pnlEngin.Location = new System.Drawing.Point(12, 18);
            this.pnlEngin.Name = "pnlEngin";
            this.pnlEngin.Size = new System.Drawing.Size(496, 381);
            this.pnlEngin.TabIndex = 11;
            this.pnlEngin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEngin_Paint);
            // 
            // pnlStatCaserneTete
            // 
            this.pnlStatCaserneTete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.pnlStatCaserneTete.Controls.Add(this.cbxCaserne);
            this.pnlStatCaserneTete.Controls.Add(this.label1);
            this.pnlStatCaserneTete.Location = new System.Drawing.Point(12, 18);
            this.pnlStatCaserneTete.Name = "pnlStatCaserneTete";
            this.pnlStatCaserneTete.Size = new System.Drawing.Size(496, 82);
            this.pnlStatCaserneTete.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez sélectionner une caserne";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(311, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 11;
            // 
            // FrmParcoursEquipements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(520, 411);
            this.Controls.Add(this.pnlStatCaserneTete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlEngin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmParcoursEquipements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualisation des engins";
            this.Load += new System.EventHandler(this.FrmParcoursEquipements_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngin)).EndInit();
            this.pnlEngin.ResumeLayout(false);
            this.pnlStatCaserneTete.ResumeLayout(false);
            this.pnlStatCaserneTete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Button btnDroite;
        private System.Windows.Forms.Button btnGauche;
        private System.Windows.Forms.Button btnFullDroite;
        private System.Windows.Forms.Button btnFullGauche;
        private System.Windows.Forms.ComboBox cbxCaserne;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblNumeroEngin;
        private System.Windows.Forms.Label lblDateReception;
        private System.Windows.Forms.Label lblStatutDisponible;
        private System.Windows.Forms.Label lblStatutPanne;
        private System.Windows.Forms.Label lblStatutMission;
        private System.Windows.Forms.PictureBox pictureBoxEngin;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel pnlEngin;
        private System.Windows.Forms.Panel pnlStatCaserneTete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}

