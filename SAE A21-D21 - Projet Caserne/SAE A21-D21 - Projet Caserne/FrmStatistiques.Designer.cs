namespace SAE_A21_D21___Projet_Caserne
{
    partial class FrmStatistiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistiques));
            this.pnlGlobal = new System.Windows.Forms.Panel();
            this.pnlCaserne = new System.Windows.Forms.Panel();
            this.cbxTypeSinistre = new System.Windows.Forms.ComboBox();
            this.cbxHabilitation = new System.Windows.Forms.ComboBox();
            this.cbxStatGlobal = new System.Windows.Forms.ComboBox();
            this.cbxRequeteParCaserne = new System.Windows.Forms.ComboBox();
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.pnlStatCaserne = new System.Windows.Forms.Panel();
            this.pnlStatCaserneTete = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlStatCaserne.SuspendLayout();
            this.pnlStatCaserneTete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGlobal
            // 
            this.pnlGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGlobal.Location = new System.Drawing.Point(27, 127);
            this.pnlGlobal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGlobal.Name = "pnlGlobal";
            this.pnlGlobal.Size = new System.Drawing.Size(581, 185);
            this.pnlGlobal.TabIndex = 17;
            // 
            // pnlCaserne
            // 
            this.pnlCaserne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCaserne.Location = new System.Drawing.Point(27, 128);
            this.pnlCaserne.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCaserne.Name = "pnlCaserne";
            this.pnlCaserne.Size = new System.Drawing.Size(581, 185);
            this.pnlCaserne.TabIndex = 16;
            // 
            // cbxTypeSinistre
            // 
            this.cbxTypeSinistre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeSinistre.FormattingEnabled = true;
            this.cbxTypeSinistre.Location = new System.Drawing.Point(351, 77);
            this.cbxTypeSinistre.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTypeSinistre.Name = "cbxTypeSinistre";
            this.cbxTypeSinistre.Size = new System.Drawing.Size(239, 21);
            this.cbxTypeSinistre.TabIndex = 15;
            this.cbxTypeSinistre.SelectedIndexChanged += new System.EventHandler(this.cbxTypeSinistre_SelectedIndexChanged);
            // 
            // cbxHabilitation
            // 
            this.cbxHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHabilitation.FormattingEnabled = true;
            this.cbxHabilitation.Location = new System.Drawing.Point(351, 77);
            this.cbxHabilitation.Margin = new System.Windows.Forms.Padding(2);
            this.cbxHabilitation.Name = "cbxHabilitation";
            this.cbxHabilitation.Size = new System.Drawing.Size(239, 21);
            this.cbxHabilitation.TabIndex = 14;
            this.cbxHabilitation.SelectedIndexChanged += new System.EventHandler(this.cbxHabilitation_SelectedIndexChanged);
            // 
            // cbxStatGlobal
            // 
            this.cbxStatGlobal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatGlobal.FormattingEnabled = true;
            this.cbxStatGlobal.Location = new System.Drawing.Point(41, 77);
            this.cbxStatGlobal.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStatGlobal.Name = "cbxStatGlobal";
            this.cbxStatGlobal.Size = new System.Drawing.Size(242, 21);
            this.cbxStatGlobal.TabIndex = 13;
            this.cbxStatGlobal.SelectedIndexChanged += new System.EventHandler(this.cbxStatGlobal_SelectedIndexChanged);
            // 
            // cbxRequeteParCaserne
            // 
            this.cbxRequeteParCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRequeteParCaserne.FormattingEnabled = true;
            this.cbxRequeteParCaserne.Location = new System.Drawing.Point(351, 76);
            this.cbxRequeteParCaserne.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRequeteParCaserne.Name = "cbxRequeteParCaserne";
            this.cbxRequeteParCaserne.Size = new System.Drawing.Size(239, 21);
            this.cbxRequeteParCaserne.TabIndex = 11;
            this.cbxRequeteParCaserne.SelectedIndexChanged += new System.EventHandler(this.cbxRequeteParCaserne_SelectedIndexChanged);
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(41, 76);
            this.cbxCaserne.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(242, 21);
            this.cbxCaserne.TabIndex = 10;
            this.cbxCaserne.SelectedIndexChanged += new System.EventHandler(this.cbxCaserne_SelectedIndexChanged);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFermer.Location = new System.Drawing.Point(15, 336);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(150, 42);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // pnlStatCaserne
            // 
            this.pnlStatCaserne.AutoScroll = true;
            this.pnlStatCaserne.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlStatCaserne.Controls.Add(this.pnlCaserne);
            this.pnlStatCaserne.Location = new System.Drawing.Point(12, 14);
            this.pnlStatCaserne.Name = "pnlStatCaserne";
            this.pnlStatCaserne.Size = new System.Drawing.Size(636, 335);
            this.pnlStatCaserne.TabIndex = 19;
            // 
            // pnlStatCaserneTete
            // 
            this.pnlStatCaserneTete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.pnlStatCaserneTete.Controls.Add(this.lblMode);
            this.pnlStatCaserneTete.Controls.Add(this.label2);
            this.pnlStatCaserneTete.Controls.Add(this.label1);
            this.pnlStatCaserneTete.Controls.Add(this.cbxCaserne);
            this.pnlStatCaserneTete.Controls.Add(this.cbxRequeteParCaserne);
            this.pnlStatCaserneTete.Location = new System.Drawing.Point(12, 14);
            this.pnlStatCaserneTete.Name = "pnlStatCaserneTete";
            this.pnlStatCaserneTete.Size = new System.Drawing.Size(636, 107);
            this.pnlStatCaserneTete.TabIndex = 18;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMode.Location = new System.Drawing.Point(177, 11);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(288, 29);
            this.lblMode.TabIndex = 5;
            this.lblMode.Text = "Statistiques de la caserne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(403, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type de statistiques";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez sélectionner une caserne";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxTypeSinistre);
            this.panel1.Controls.Add(this.cbxHabilitation);
            this.panel1.Controls.Add(this.cbxStatGlobal);
            this.panel1.Location = new System.Drawing.Point(12, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 107);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(203, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Statistiques globales";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.btnFermer);
            this.panel2.Controls.Add(this.pnlGlobal);
            this.panel2.Location = new System.Drawing.Point(12, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 392);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(32, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Veuillez sélectionner une statistique";
            // 
            // FrmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(660, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlStatCaserneTete);
            this.Controls.Add(this.pnlStatCaserne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStatistiques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.FrmStatistiques_Load);
            this.pnlStatCaserne.ResumeLayout(false);
            this.pnlStatCaserneTete.ResumeLayout(false);
            this.pnlStatCaserneTete.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGlobal;
        private System.Windows.Forms.Panel pnlCaserne;
        private System.Windows.Forms.ComboBox cbxTypeSinistre;
        private System.Windows.Forms.ComboBox cbxHabilitation;
        private System.Windows.Forms.ComboBox cbxStatGlobal;
        private System.Windows.Forms.ComboBox cbxRequeteParCaserne;
        private System.Windows.Forms.ComboBox cbxCaserne;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel pnlStatCaserne;
        private System.Windows.Forms.Panel pnlStatCaserneTete;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}