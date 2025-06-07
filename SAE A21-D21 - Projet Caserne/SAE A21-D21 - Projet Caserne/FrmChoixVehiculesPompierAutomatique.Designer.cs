namespace SAE_A21_D21___Projet_Caserne
{
    partial class FrmChoixVehiculesPompierAutomatique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChoixVehiculesPompierAutomatique));
            this.pnlVehicule = new System.Windows.Forms.Panel();
            this.pnlPompier = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblVehicule = new System.Windows.Forms.Label();
            this.lblPompier = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVehicule
            // 
            this.pnlVehicule.AutoScroll = true;
            this.pnlVehicule.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlVehicule.Location = new System.Drawing.Point(13, 82);
            this.pnlVehicule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVehicule.Name = "pnlVehicule";
            this.pnlVehicule.Size = new System.Drawing.Size(381, 286);
            this.pnlVehicule.TabIndex = 0;
            // 
            // pnlPompier
            // 
            this.pnlPompier.AutoScroll = true;
            this.pnlPompier.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlPompier.Location = new System.Drawing.Point(405, 82);
            this.pnlPompier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPompier.Name = "pnlPompier";
            this.pnlPompier.Size = new System.Drawing.Size(381, 286);
            this.pnlPompier.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.lblPompier);
            this.panel3.Controls.Add(this.lblVehicule);
            this.panel3.Location = new System.Drawing.Point(13, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 63);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel4.Controls.Add(this.btnRetour);
            this.panel4.Controls.Add(this.btnValider);
            this.panel4.Location = new System.Drawing.Point(13, 374);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 70);
            this.panel4.TabIndex = 3;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Red;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(13, 14);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(157, 46);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(604, 14);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(157, 46);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblVehicule
            // 
            this.lblVehicule.AutoSize = true;
            this.lblVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicule.Location = new System.Drawing.Point(18, 19);
            this.lblVehicule.Name = "lblVehicule";
            this.lblVehicule.Size = new System.Drawing.Size(225, 25);
            this.lblVehicule.TabIndex = 0;
            this.lblVehicule.Text = "Véhicule(s) choisi(s) :";
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompier.Location = new System.Drawing.Point(420, 19);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(220, 25);
            this.lblPompier.TabIndex = 1;
            this.lblPompier.Text = "Pompier(s) choisi(s) :";
            // 
            // FrmChoixVehiculesPompierAutomatique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlPompier);
            this.Controls.Add(this.pnlVehicule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmChoixVehiculesPompierAutomatique";
            this.Load += new System.EventHandler(this.FrmChoixVehiculesPompierAutomatique_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVehicule;
        private System.Windows.Forms.Panel pnlPompier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.Label lblVehicule;
    }
}