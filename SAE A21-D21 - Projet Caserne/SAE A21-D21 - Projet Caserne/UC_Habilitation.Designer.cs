namespace SAE_A21_D21___Projet_Caserne
{
    partial class UC_Habilitation
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
            this.cbxHabilitation = new System.Windows.Forms.CheckBox();
            this.dtpDateHabilitation = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbxHabilitation
            // 
            this.cbxHabilitation.AutoSize = true;
            this.cbxHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxHabilitation.Location = new System.Drawing.Point(3, 6);
            this.cbxHabilitation.Name = "cbxHabilitation";
            this.cbxHabilitation.Size = new System.Drawing.Size(243, 17);
            this.cbxHabilitation.TabIndex = 0;
            this.cbxHabilitation.Text = "COD2-Conducteur d\'engin à échelle pivotante";
            this.cbxHabilitation.UseVisualStyleBackColor = true;
            this.cbxHabilitation.CheckedChanged += new System.EventHandler(this.cbxHabilitation_CheckedChanged);
            // 
            // dtpDateHabilitation
            // 
            this.dtpDateHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F);
            this.dtpDateHabilitation.Location = new System.Drawing.Point(273, 9);
            this.dtpDateHabilitation.Name = "dtpDateHabilitation";
            this.dtpDateHabilitation.Size = new System.Drawing.Size(17, 11);
            this.dtpDateHabilitation.TabIndex = 1;
            this.dtpDateHabilitation.Visible = false;
            // 
            // UC_Habilitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDateHabilitation);
            this.Controls.Add(this.cbxHabilitation);
            this.Name = "UC_Habilitation";
            this.Size = new System.Drawing.Size(362, 28);
            this.Load += new System.EventHandler(this.UC_Habilitation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxHabilitation;
        private System.Windows.Forms.DateTimePicker dtpDateHabilitation;
    }
}
