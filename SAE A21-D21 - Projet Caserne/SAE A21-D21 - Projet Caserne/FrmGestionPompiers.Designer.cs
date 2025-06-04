namespace SAE_A21_D21___Projet_Caserne
{
    partial class FrmGestionPompiers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPompiers));
            this.pnlAffichagePompier = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.pnlSelectionPompier = new System.Windows.Forms.Panel();
            this.btnNouveauPompier = new System.Windows.Forms.Button();
            this.pnlConnexion = new System.Windows.Forms.Panel();
            this.lblSeConnecter = new System.Windows.Forms.Label();
            this.pcbAdmin = new System.Windows.Forms.PictureBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.cmbPompier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCaserne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSelectionPompier.SuspendLayout();
            this.pnlConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAffichagePompier
            // 
            this.pnlAffichagePompier.AutoScroll = true;
            this.pnlAffichagePompier.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlAffichagePompier.Location = new System.Drawing.Point(12, 137);
            this.pnlAffichagePompier.Name = "pnlAffichagePompier";
            this.pnlAffichagePompier.Size = new System.Drawing.Size(636, 548);
            this.pnlAffichagePompier.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(463, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 42);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Mettre à jour";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFermer.Location = new System.Drawing.Point(21, 26);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(150, 42);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pnlSelectionPompier
            // 
            this.pnlSelectionPompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.pnlSelectionPompier.Controls.Add(this.btnNouveauPompier);
            this.pnlSelectionPompier.Controls.Add(this.pnlConnexion);
            this.pnlSelectionPompier.Controls.Add(this.lblMode);
            this.pnlSelectionPompier.Controls.Add(this.cmbPompier);
            this.pnlSelectionPompier.Controls.Add(this.label2);
            this.pnlSelectionPompier.Controls.Add(this.cmbCaserne);
            this.pnlSelectionPompier.Controls.Add(this.label1);
            this.pnlSelectionPompier.Location = new System.Drawing.Point(12, 12);
            this.pnlSelectionPompier.Name = "pnlSelectionPompier";
            this.pnlSelectionPompier.Size = new System.Drawing.Size(636, 116);
            this.pnlSelectionPompier.TabIndex = 9;
            // 
            // btnNouveauPompier
            // 
            this.btnNouveauPompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNouveauPompier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveauPompier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouveauPompier.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauPompier.ForeColor = System.Drawing.Color.Black;
            this.btnNouveauPompier.Location = new System.Drawing.Point(476, 9);
            this.btnNouveauPompier.Name = "btnNouveauPompier";
            this.btnNouveauPompier.Size = new System.Drawing.Size(150, 40);
            this.btnNouveauPompier.TabIndex = 10;
            this.btnNouveauPompier.Text = "Ajouter pompier";
            this.btnNouveauPompier.UseVisualStyleBackColor = false;
            this.btnNouveauPompier.Visible = false;
            this.btnNouveauPompier.Click += new System.EventHandler(this.btnNouveauPompier_Click);
            // 
            // pnlConnexion
            // 
            this.pnlConnexion.Controls.Add(this.lblSeConnecter);
            this.pnlConnexion.Controls.Add(this.pcbAdmin);
            this.pnlConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlConnexion.Location = new System.Drawing.Point(11, 9);
            this.pnlConnexion.Name = "pnlConnexion";
            this.pnlConnexion.Size = new System.Drawing.Size(152, 42);
            this.pnlConnexion.TabIndex = 8;
            this.pnlConnexion.Click += new System.EventHandler(this.pnlConnexion_Click);
            // 
            // lblSeConnecter
            // 
            this.lblSeConnecter.AutoSize = true;
            this.lblSeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSeConnecter.ForeColor = System.Drawing.Color.White;
            this.lblSeConnecter.Location = new System.Drawing.Point(45, 11);
            this.lblSeConnecter.Name = "lblSeConnecter";
            this.lblSeConnecter.Size = new System.Drawing.Size(107, 20);
            this.lblSeConnecter.TabIndex = 6;
            this.lblSeConnecter.Text = "Se Connecter";
            this.lblSeConnecter.Click += new System.EventHandler(this.lblSeConnecter_Click);
            // 
            // pcbAdmin
            // 
            this.pcbAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pcbAdmin.Image")));
            this.pcbAdmin.Location = new System.Drawing.Point(1, 0);
            this.pcbAdmin.Name = "pcbAdmin";
            this.pcbAdmin.Size = new System.Drawing.Size(43, 43);
            this.pcbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAdmin.TabIndex = 4;
            this.pcbAdmin.TabStop = false;
            this.pcbAdmin.Click += new System.EventHandler(this.pcbAdmin_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMode.Location = new System.Drawing.Point(210, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(212, 29);
            this.lblMode.TabIndex = 5;
            this.lblMode.Text = "Mode visualisation";
            // 
            // cmbPompier
            // 
            this.cmbPompier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPompier.FormattingEnabled = true;
            this.cmbPompier.Location = new System.Drawing.Point(349, 87);
            this.cmbPompier.Name = "cmbPompier";
            this.cmbPompier.Size = new System.Drawing.Size(239, 21);
            this.cmbPompier.TabIndex = 3;
            this.cmbPompier.SelectedIndexChanged += new System.EventHandler(this.cmbPompier_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(350, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veuillez sélectionner un pompier";
            // 
            // cmbCaserne
            // 
            this.cmbCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaserne.FormattingEnabled = true;
            this.cmbCaserne.Location = new System.Drawing.Point(41, 87);
            this.cmbCaserne.Name = "cmbCaserne";
            this.cmbCaserne.Size = new System.Drawing.Size(239, 21);
            this.cmbCaserne.TabIndex = 1;
            this.cmbCaserne.SelectedIndexChanged += new System.EventHandler(this.cmbCaserne_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez sélectionner une caserne";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnFermer);
            this.panel1.Location = new System.Drawing.Point(12, 678);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 82);
            this.panel1.TabIndex = 9;
            // 
            // FrmGestionPompiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 772);
            this.Controls.Add(this.pnlSelectionPompier);
            this.Controls.Add(this.pnlAffichagePompier);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionPompiers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion du personnel";
            this.Load += new System.EventHandler(this.FrmGestionPompiers_Load);
            this.pnlSelectionPompier.ResumeLayout(false);
            this.pnlSelectionPompier.PerformLayout();
            this.pnlConnexion.ResumeLayout(false);
            this.pnlConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAffichagePompier;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlSelectionPompier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPompier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCaserne;
        private System.Windows.Forms.PictureBox pcbAdmin;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeConnecter;
        private System.Windows.Forms.Panel pnlConnexion;
        private System.Windows.Forms.Button btnNouveauPompier;
    }
}