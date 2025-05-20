namespace SAE_A21_D21___Projet_Caserne
{
    partial class frmChoixVehiculesPompier
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
            this.pnlChoixVehicule = new System.Windows.Forms.Panel();
            this.lblVehiculeValide = new System.Windows.Forms.Label();
            this.lblHabilitationPompier = new System.Windows.Forms.Label();
            this.pnlChoixHabilitation = new System.Windows.Forms.Panel();
            this.lblPompierValide = new System.Windows.Forms.Label();
            this.pnlChoixPompier = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlChoixVehicule
            // 
            this.pnlChoixVehicule.AutoScroll = true;
            this.pnlChoixVehicule.Location = new System.Drawing.Point(13, 78);
            this.pnlChoixVehicule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChoixVehicule.Name = "pnlChoixVehicule";
            this.pnlChoixVehicule.Size = new System.Drawing.Size(329, 594);
            this.pnlChoixVehicule.TabIndex = 1;
            // 
            // lblVehiculeValide
            // 
            this.lblVehiculeValide.AutoSize = true;
            this.lblVehiculeValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculeValide.Location = new System.Drawing.Point(37, 37);
            this.lblVehiculeValide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculeValide.Name = "lblVehiculeValide";
            this.lblVehiculeValide.Size = new System.Drawing.Size(278, 25);
            this.lblVehiculeValide.TabIndex = 2;
            this.lblVehiculeValide.Text = "Véhicules validés (Si vert) :";
            // 
            // lblHabilitationPompier
            // 
            this.lblHabilitationPompier.AutoSize = true;
            this.lblHabilitationPompier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitationPompier.Location = new System.Drawing.Point(425, 38);
            this.lblHabilitationPompier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabilitationPompier.Name = "lblHabilitationPompier";
            this.lblHabilitationPompier.Size = new System.Drawing.Size(218, 25);
            this.lblHabilitationPompier.TabIndex = 4;
            this.lblHabilitationPompier.Text = "Choix de l\'habilitation";
            // 
            // pnlChoixHabilitation
            // 
            this.pnlChoixHabilitation.AutoScroll = true;
            this.pnlChoixHabilitation.Location = new System.Drawing.Point(370, 78);
            this.pnlChoixHabilitation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChoixHabilitation.Name = "pnlChoixHabilitation";
            this.pnlChoixHabilitation.Size = new System.Drawing.Size(329, 594);
            this.pnlChoixHabilitation.TabIndex = 3;
            // 
            // lblPompierValide
            // 
            this.lblPompierValide.AutoSize = true;
            this.lblPompierValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPompierValide.Location = new System.Drawing.Point(742, 38);
            this.lblPompierValide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPompierValide.Name = "lblPompierValide";
            this.lblPompierValide.Size = new System.Drawing.Size(273, 25);
            this.lblPompierValide.TabIndex = 6;
            this.lblPompierValide.Text = "Pompiers validés (Si vert) :";
            // 
            // pnlChoixPompier
            // 
            this.pnlChoixPompier.AutoScroll = true;
            this.pnlChoixPompier.Location = new System.Drawing.Point(718, 79);
            this.pnlChoixPompier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChoixPompier.Name = "pnlChoixPompier";
            this.pnlChoixPompier.Size = new System.Drawing.Size(329, 594);
            this.pnlChoixPompier.TabIndex = 5;
            // 
            // frmChoixVehiculesPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1059, 684);
            this.Controls.Add(this.lblPompierValide);
            this.Controls.Add(this.lblHabilitationPompier);
            this.Controls.Add(this.pnlChoixPompier);
            this.Controls.Add(this.lblVehiculeValide);
            this.Controls.Add(this.pnlChoixHabilitation);
            this.Controls.Add(this.pnlChoixVehicule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChoixVehiculesPompier";
            this.Text = "frmChoixVehiculesPompier";
            this.Load += new System.EventHandler(this.frmChoixVehiculesPompier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlChoixVehicule;
        private System.Windows.Forms.Label lblVehiculeValide;
        private System.Windows.Forms.Label lblHabilitationPompier;
        private System.Windows.Forms.Panel pnlChoixHabilitation;
        private System.Windows.Forms.Label lblPompierValide;
        private System.Windows.Forms.Panel pnlChoixPompier;
    }
}