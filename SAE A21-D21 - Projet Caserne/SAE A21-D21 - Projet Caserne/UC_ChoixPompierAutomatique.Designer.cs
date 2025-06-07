namespace SAE_A21_D21___Projet_Caserne
{
    partial class UC_ChoixPompierAutomatique
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGrade = new System.Windows.Forms.PictureBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGrade
            // 
            this.pbGrade.Location = new System.Drawing.Point(4, 6);
            this.pbGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbGrade.Name = "pbGrade";
            this.pbGrade.Size = new System.Drawing.Size(67, 62);
            this.pbGrade.TabIndex = 0;
            this.pbGrade.TabStop = false;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(79, 15);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(44, 16);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "label1";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(79, 46);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 16);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "label2";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_ChoixPompierAutomatique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.pbGrade);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_ChoixPompierAutomatique";
            this.Size = new System.Drawing.Size(360, 71);
            this.Load += new System.EventHandler(this.UC_ChoixPompierAutomatique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblNom;
    }
}
