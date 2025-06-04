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
            this.pnlVehicule = new System.Windows.Forms.Panel();
            this.pnlPompier = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVehicule
            // 
            this.pnlVehicule.AutoScroll = true;
            this.pnlVehicule.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlVehicule.Location = new System.Drawing.Point(10, 67);
            this.pnlVehicule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlVehicule.Name = "pnlVehicule";
            this.pnlVehicule.Size = new System.Drawing.Size(286, 232);
            this.pnlVehicule.TabIndex = 0;
            // 
            // pnlPompier
            // 
            this.pnlPompier.AutoScroll = true;
            this.pnlPompier.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlPompier.Location = new System.Drawing.Point(304, 67);
            this.pnlPompier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPompier.Name = "pnlPompier";
            this.pnlPompier.Size = new System.Drawing.Size(286, 232);
            this.pnlPompier.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panel3.Location = new System.Drawing.Point(10, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 51);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel4.Controls.Add(this.btnRetour);
            this.panel4.Controls.Add(this.btnValider);
            this.panel4.Location = new System.Drawing.Point(10, 304);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 57);
            this.panel4.TabIndex = 3;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Red;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(10, 11);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(118, 37);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(453, 11);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(118, 37);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // FrmChoixVehiculesPompierAutomatique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlPompier);
            this.Controls.Add(this.pnlVehicule);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmChoixVehiculesPompierAutomatique";
            this.Load += new System.EventHandler(this.FrmChoixVehiculesPompierAutomatique_Load);
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
    }
}