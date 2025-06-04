namespace SAE_A21_D21___Projet_Caserne
{
    partial class UC_CreerPompier
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCarriere = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlRdbProVol = new System.Windows.Forms.Panel();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.cmbCaserneRattachement = new System.Windows.Forms.ComboBox();
            this.lblCaserneRattachement = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.sqLiteCommand2 = new System.Data.SQLite.SQLiteCommand();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.cmbHabilitation = new System.Windows.Forms.ComboBox();
            this.lblHabilitation = new System.Windows.Forms.Label();
            this.pnlRdbProVol.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 176);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 1);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // lblCarriere
            // 
            this.lblCarriere.AutoSize = true;
            this.lblCarriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarriere.Location = new System.Drawing.Point(194, 153);
            this.lblCarriere.Name = "lblCarriere";
            this.lblCarriere.Size = new System.Drawing.Size(69, 18);
            this.lblCarriere.TabIndex = 36;
            this.lblCarriere.Text = "Carrière";
            // 
            // cmbGrade
            // 
            this.cmbGrade.BackColor = System.Drawing.Color.White;
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(241, 260);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(191, 21);
            this.cmbGrade.TabIndex = 23;
            this.cmbGrade.SelectedValueChanged += new System.EventHandler(this.cmbGrade_SelectedValueChanged);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTelephone.Location = new System.Drawing.Point(297, 94);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(77, 18);
            this.lblTelephone.TabIndex = 32;
            this.lblTelephone.Text = "Téléphone";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblGrade.Location = new System.Drawing.Point(311, 239);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(49, 18);
            this.lblGrade.TabIndex = 31;
            this.lblGrade.Text = "Grade";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAge.Location = new System.Drawing.Point(125, 12);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(89, 18);
            this.lblAge.TabIndex = 29;
            this.lblAge.Text = "Age : 24 ans";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDateNaissance.Location = new System.Drawing.Point(275, 28);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(130, 18);
            this.lblDateNaissance.TabIndex = 28;
            this.lblDateNaissance.Text = "Date de naissance";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSexe.Location = new System.Drawing.Point(10, 114);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(49, 18);
            this.lblSexe.TabIndex = 27;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPrenom.Location = new System.Drawing.Point(10, 81);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(69, 18);
            this.lblPrenom.TabIndex = 26;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNom.Location = new System.Drawing.Point(10, 49);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 18);
            this.lblNom.TabIndex = 24;
            this.lblNom.Text = "Nom :";
            // 
            // pnlRdbProVol
            // 
            this.pnlRdbProVol.Controls.Add(this.rdbProfessionnel);
            this.pnlRdbProVol.Controls.Add(this.rdbVolontaire);
            this.pnlRdbProVol.Location = new System.Drawing.Point(46, 241);
            this.pnlRdbProVol.Name = "pnlRdbProVol";
            this.pnlRdbProVol.Size = new System.Drawing.Size(141, 56);
            this.pnlRdbProVol.TabIndex = 39;
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdbProfessionnel.Location = new System.Drawing.Point(9, 4);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(117, 22);
            this.rdbProfessionnel.TabIndex = 7;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdbVolontaire.Location = new System.Drawing.Point(9, 32);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(92, 22);
            this.rdbVolontaire.TabIndex = 8;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // cmbCaserneRattachement
            // 
            this.cmbCaserneRattachement.BackColor = System.Drawing.Color.White;
            this.cmbCaserneRattachement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaserneRattachement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbCaserneRattachement.FormattingEnabled = true;
            this.cmbCaserneRattachement.Location = new System.Drawing.Point(241, 211);
            this.cmbCaserneRattachement.Name = "cmbCaserneRattachement";
            this.cmbCaserneRattachement.Size = new System.Drawing.Size(190, 21);
            this.cmbCaserneRattachement.TabIndex = 41;
            // 
            // lblCaserneRattachement
            // 
            this.lblCaserneRattachement.AutoSize = true;
            this.lblCaserneRattachement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCaserneRattachement.Location = new System.Drawing.Point(249, 190);
            this.lblCaserneRattachement.Name = "lblCaserneRattachement";
            this.lblCaserneRattachement.Size = new System.Drawing.Size(174, 18);
            this.lblCaserneRattachement.TabIndex = 42;
            this.lblCaserneRattachement.Text = "Caserne de rattachement";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // sqLiteCommand2
            // 
            this.sqLiteCommand2.CommandText = null;
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(85, 50);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(139, 20);
            this.txbNom.TabIndex = 45;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(85, 82);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(139, 20);
            this.txbPrenom.TabIndex = 47;
            // 
            // cmbSexe
            // 
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Location = new System.Drawing.Point(85, 114);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(139, 21);
            this.cmbSexe.TabIndex = 48;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(242, 50);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(200, 20);
            this.dtpDateNaissance.TabIndex = 49;
            this.dtpDateNaissance.ValueChanged += new System.EventHandler(this.dtpDateNaissance_ValueChanged);
            this.dtpDateNaissance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateNaissance_KeyDown);
            this.dtpDateNaissance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDateNaissance_KeyPress);
            // 
            // txbTelephone
            // 
            this.txbTelephone.Location = new System.Drawing.Point(276, 115);
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(123, 20);
            this.txbTelephone.TabIndex = 50;
            this.txbTelephone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTelephone_KeyDown);
            this.txbTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTelephone_KeyPress);
            // 
            // cmbHabilitation
            // 
            this.cmbHabilitation.BackColor = System.Drawing.Color.White;
            this.cmbHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbHabilitation.FormattingEnabled = true;
            this.cmbHabilitation.Location = new System.Drawing.Point(26, 211);
            this.cmbHabilitation.Name = "cmbHabilitation";
            this.cmbHabilitation.Size = new System.Drawing.Size(191, 21);
            this.cmbHabilitation.TabIndex = 51;
            // 
            // lblHabilitation
            // 
            this.lblHabilitation.AutoSize = true;
            this.lblHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblHabilitation.Location = new System.Drawing.Point(82, 190);
            this.lblHabilitation.Name = "lblHabilitation";
            this.lblHabilitation.Size = new System.Drawing.Size(80, 18);
            this.lblHabilitation.TabIndex = 52;
            this.lblHabilitation.Text = "Habilitation";
            // 
            // UC_CreerPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblHabilitation);
            this.Controls.Add(this.cmbHabilitation);
            this.Controls.Add(this.txbTelephone);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.cmbSexe);
            this.Controls.Add(this.txbPrenom);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.cmbCaserneRattachement);
            this.Controls.Add(this.lblCaserneRattachement);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCarriere);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pnlRdbProVol);
            this.Name = "UC_CreerPompier";
            this.Size = new System.Drawing.Size(463, 304);
            this.Load += new System.EventHandler(this.UC_CreerPompier_Load);
            this.pnlRdbProVol.ResumeLayout(false);
            this.pnlRdbProVol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCarriere;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Panel pnlRdbProVol;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.ComboBox cmbCaserneRattachement;
        private System.Windows.Forms.Label lblCaserneRattachement;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand2;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.ComboBox cmbHabilitation;
        private System.Windows.Forms.Label lblHabilitation;
    }
}
