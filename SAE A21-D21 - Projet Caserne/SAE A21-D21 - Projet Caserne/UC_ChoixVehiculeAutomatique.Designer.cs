namespace SAE_A21_D21___Projet_Caserne
{
    partial class UC_ChoixVehiculeAutomatique
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
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pbVehicule = new System.Windows.Forms.PictureBox();
            this.lblNumero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(248, 27);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(44, 16);
            this.lblCaserne.TabIndex = 5;
            this.lblCaserne.Text = "label2";
            this.lblCaserne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(104, 27);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 16);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "label1";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbVehicule
            // 
            this.pbVehicule.Location = new System.Drawing.Point(4, 4);
            this.pbVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.pbVehicule.Name = "pbVehicule";
            this.pbVehicule.Size = new System.Drawing.Size(67, 62);
            this.pbVehicule.TabIndex = 3;
            this.pbVehicule.TabStop = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(177, 27);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 16);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "label1";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_ChoixVehiculeAutomatique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCaserne);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.pbVehicule);
            this.Name = "UC_ChoixVehiculeAutomatique";
            this.Size = new System.Drawing.Size(360, 71);
            this.Load += new System.EventHandler(this.UC_ChoixVehiculeAutomatique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVehicule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pbVehicule;
        private System.Windows.Forms.Label lblNumero;
    }
}
