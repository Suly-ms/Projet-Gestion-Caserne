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
            this.SuspendLayout();
            // 
            // pnlChoixVehicule
            // 
            this.pnlChoixVehicule.AutoScroll = true;
            this.pnlChoixVehicule.Location = new System.Drawing.Point(13, 13);
            this.pnlChoixVehicule.Name = "pnlChoixVehicule";
            this.pnlChoixVehicule.Size = new System.Drawing.Size(551, 659);
            this.pnlChoixVehicule.TabIndex = 1;
            // 
            // frmChoixVehiculesPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1128, 684);
            this.Controls.Add(this.pnlChoixVehicule);
            this.Name = "frmChoixVehiculesPompier";
            this.Text = "frmChoixVehiculesPompier";
            this.Load += new System.EventHandler(this.frmChoixVehiculesPompier_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlChoixVehicule;
    }
}