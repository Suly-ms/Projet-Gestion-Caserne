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
            this.label1 = new System.Windows.Forms.Label();
            this.ucChoixVehicule1 = new UserControlChoixVehicules.UCChoixVehicule();
            this.pnlChoixVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChoixVehicule
            // 
            this.pnlChoixVehicule.AutoScroll = true;
            this.pnlChoixVehicule.Controls.Add(this.ucChoixVehicule1);
            this.pnlChoixVehicule.Location = new System.Drawing.Point(10, 63);
            this.pnlChoixVehicule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlChoixVehicule.Name = "pnlChoixVehicule";
            this.pnlChoixVehicule.Size = new System.Drawing.Size(413, 483);
            this.pnlChoixVehicule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ucChoixVehicule1
            // 
            this.ucChoixVehicule1.BackColor = System.Drawing.Color.Transparent;
            this.ucChoixVehicule1.Location = new System.Drawing.Point(4, 4);
            this.ucChoixVehicule1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucChoixVehicule1.Name = "ucChoixVehicule1";
            this.ucChoixVehicule1.Size = new System.Drawing.Size(158, 115);
            this.ucChoixVehicule1.TabIndex = 0;
            // 
            // frmChoixVehiculesPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlChoixVehicule);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChoixVehiculesPompier";
            this.Text = "frmChoixVehiculesPompier";
            this.Load += new System.EventHandler(this.frmChoixVehiculesPompier_Load);
            this.pnlChoixVehicule.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlChoixVehicule;
        private System.Windows.Forms.Label label1;
        private UserControlChoixVehicules.UCChoixVehicule ucChoixVehicule1;
    }
}