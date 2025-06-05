namespace SAE_A21_D21___Projet_Caserne
{
    partial class FrmDommageEngin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDommageEngin));
            this.lblReparation = new System.Windows.Forms.Label();
            this.txbReparation = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReparation
            // 
            this.lblReparation.AutoSize = true;
            this.lblReparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparation.ForeColor = System.Drawing.Color.Black;
            this.lblReparation.Location = new System.Drawing.Point(16, 9);
            this.lblReparation.Name = "lblReparation";
            this.lblReparation.Size = new System.Drawing.Size(397, 20);
            this.lblReparation.TabIndex = 5;
            this.lblReparation.Text = "Veuillez specifier les dégâts subis sur l\'engin 0-ABCD-0";
            this.lblReparation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbReparation
            // 
            this.txbReparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txbReparation.Location = new System.Drawing.Point(35, 34);
            this.txbReparation.Multiline = true;
            this.txbReparation.Name = "txbReparation";
            this.txbReparation.Size = new System.Drawing.Size(357, 93);
            this.txbReparation.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnValider.Location = new System.Drawing.Point(295, 139);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(97, 34);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.Location = new System.Drawing.Point(35, 139);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(97, 34);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FrmDommageEngin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 179);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblReparation);
            this.Controls.Add(this.txbReparation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDommageEngin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dégâts";
            this.Load += new System.EventHandler(this.FrmDommageEngin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReparation;
        private System.Windows.Forms.TextBox txbReparation;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}