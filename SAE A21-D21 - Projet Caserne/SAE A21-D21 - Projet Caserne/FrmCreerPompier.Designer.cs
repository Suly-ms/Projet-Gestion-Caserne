namespace SAE_A21_D21___Projet_Caserne
{
    partial class FrmCreerPompier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreerPompier));
            this.pnlSelectionPompier = new System.Windows.Forms.Panel();
            this.pnlAffichagePompier = new System.Windows.Forms.Panel();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblBip = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.pnlSelectionPompier.SuspendLayout();
            this.pnlAffichagePompier.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSelectionPompier
            // 
            this.pnlSelectionPompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.pnlSelectionPompier.Controls.Add(this.lblBip);
            this.pnlSelectionPompier.Controls.Add(this.lblMatricule);
            this.pnlSelectionPompier.Location = new System.Drawing.Point(11, 11);
            this.pnlSelectionPompier.Name = "pnlSelectionPompier";
            this.pnlSelectionPompier.Size = new System.Drawing.Size(463, 100);
            this.pnlSelectionPompier.TabIndex = 11;
            // 
            // pnlAffichagePompier
            // 
            this.pnlAffichagePompier.AutoScroll = true;
            this.pnlAffichagePompier.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlAffichagePompier.Controls.Add(this.btnAjouter);
            this.pnlAffichagePompier.Controls.Add(this.btnFermer);
            this.pnlAffichagePompier.Location = new System.Drawing.Point(11, 119);
            this.pnlAffichagePompier.Name = "pnlAffichagePompier";
            this.pnlAffichagePompier.Size = new System.Drawing.Size(463, 385);
            this.pnlAffichagePompier.TabIndex = 10;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblMatricule.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMatricule.Location = new System.Drawing.Point(124, 15);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(217, 31);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule n°0000";
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBip.Location = new System.Drawing.Point(378, 15);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(73, 18);
            this.lblBip.TabIndex = 35;
            this.lblBip.Text = "Bip : 1234";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Lime;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(301, 335);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 42);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFermer.Location = new System.Drawing.Point(11, 335);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(150, 42);
            this.btnFermer.TabIndex = 21;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmCreerPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.pnlSelectionPompier);
            this.Controls.Add(this.pnlAffichagePompier);
            this.Name = "FrmCreerPompier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un pompier";
            this.Load += new System.EventHandler(this.FrmCreerPompier_Load);
            this.pnlSelectionPompier.ResumeLayout(false);
            this.pnlSelectionPompier.PerformLayout();
            this.pnlAffichagePompier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSelectionPompier;
        private System.Windows.Forms.Panel pnlAffichagePompier;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFermer;
    }
}