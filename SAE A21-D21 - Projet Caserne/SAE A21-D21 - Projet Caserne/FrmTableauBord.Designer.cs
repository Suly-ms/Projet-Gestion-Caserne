namespace SAE_A21_D21___Projet_Caserne
{
    partial class FrmTableauDeBord
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableauDeBord));
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.pnlTableauBord = new System.Windows.Forms.Panel();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckbEnCours = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnGestionPersonnel = new System.Windows.Forms.Button();
            this.btnGestionEngins = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pnlMission = new System.Windows.Forms.Panel();
            this.pnlFond = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTableauBord.SuspendLayout();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFond.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // pnlTableauBord
            // 
            this.pnlTableauBord.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlTableauBord.Controls.Add(this.btnNouvelleMission);
            this.pnlTableauBord.Controls.Add(this.panel3);
            this.pnlTableauBord.Controls.Add(this.ckbEnCours);
            this.pnlTableauBord.Controls.Add(this.label1);
            this.pnlTableauBord.Location = new System.Drawing.Point(248, 19);
            this.pnlTableauBord.Name = "pnlTableauBord";
            this.pnlTableauBord.Size = new System.Drawing.Size(875, 82);
            this.pnlTableauBord.TabIndex = 2;
            this.pnlTableauBord.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTableauBord_Paint);
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNouvelleMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouvelleMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelleMission.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.White;
            this.btnNouvelleMission.Location = new System.Drawing.Point(662, 11);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(163, 40);
            this.btnNouvelleMission.TabIndex = 9;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(80, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 4);
            this.panel3.TabIndex = 4;
            // 
            // ckbEnCours
            // 
            this.ckbEnCours.AutoSize = true;
            this.ckbEnCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEnCours.ForeColor = System.Drawing.Color.Firebrick;
            this.ckbEnCours.Location = new System.Drawing.Point(116, 22);
            this.ckbEnCours.Name = "ckbEnCours";
            this.ckbEnCours.Size = new System.Drawing.Size(95, 22);
            this.ckbEnCours.TabIndex = 3;
            this.ckbEnCours.Text = "En cours";
            this.ckbEnCours.UseVisualStyleBackColor = true;
            this.ckbEnCours.CheckedChanged += new System.EventHandler(this.ckbEnCours_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(326, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tableau de bord";
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.pnlNavBar.Controls.Add(this.label2);
            this.pnlNavBar.Controls.Add(this.pictureBox1);
            this.pnlNavBar.Location = new System.Drawing.Point(12, 19);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(222, 224);
            this.pnlNavBar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fire Helmets";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnStatistiques.Location = new System.Drawing.Point(16, 161);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(189, 40);
            this.btnStatistiques.TabIndex = 12;
            this.btnStatistiques.Text = "Statistiques";
            this.btnStatistiques.UseVisualStyleBackColor = true;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnGestionPersonnel
            // 
            this.btnGestionPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnGestionPersonnel.Location = new System.Drawing.Point(16, 21);
            this.btnGestionPersonnel.Name = "btnGestionPersonnel";
            this.btnGestionPersonnel.Size = new System.Drawing.Size(189, 40);
            this.btnGestionPersonnel.TabIndex = 11;
            this.btnGestionPersonnel.Text = "Gestion du personnel";
            this.btnGestionPersonnel.UseVisualStyleBackColor = true;
            this.btnGestionPersonnel.Click += new System.EventHandler(this.btnGestionPersonnel_Click);
            // 
            // btnGestionEngins
            // 
            this.btnGestionEngins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionEngins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnGestionEngins.Location = new System.Drawing.Point(16, 91);
            this.btnGestionEngins.Name = "btnGestionEngins";
            this.btnGestionEngins.Size = new System.Drawing.Size(189, 40);
            this.btnGestionEngins.TabIndex = 10;
            this.btnGestionEngins.Text = "Afficher les engins";
            this.btnGestionEngins.UseVisualStyleBackColor = true;
            this.btnGestionEngins.Click += new System.EventHandler(this.btnGestionEngins_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(16, 327);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(189, 40);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pnlMission
            // 
            this.pnlMission.AutoScroll = true;
            this.pnlMission.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlMission.Location = new System.Drawing.Point(245, 19);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(908, 629);
            this.pnlMission.TabIndex = 7;
            // 
            // pnlFond
            // 
            this.pnlFond.AutoScroll = true;
            this.pnlFond.BackColor = System.Drawing.Color.Transparent;
            this.pnlFond.Controls.Add(this.panel1);
            this.pnlFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFond.Location = new System.Drawing.Point(0, 0);
            this.pnlFond.Name = "pnlFond";
            this.pnlFond.Size = new System.Drawing.Size(1165, 662);
            this.pnlFond.TabIndex = 8;
            this.pnlFond.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnGestionEngins);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Controls.Add(this.btnGestionPersonnel);
            this.panel1.Controls.Add(this.btnStatistiques);
            this.panel1.Location = new System.Drawing.Point(12, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 390);
            this.panel1.TabIndex = 15;
            // 
            // FrmTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1165, 662);
            this.Controls.Add(this.pnlTableauBord);
            this.Controls.Add(this.pnlMission);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.pnlFond);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTableauDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.FrmTableauDeBord_Load);
            this.pnlTableauBord.ResumeLayout(false);
            this.pnlTableauBord.PerformLayout();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFond.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Panel pnlTableauBord;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ckbEnCours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMission;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Panel pnlFond;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnGestionPersonnel;
        private System.Windows.Forms.Button btnGestionEngins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

