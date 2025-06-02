namespace SAE_A21_D21___Projet_Caserne
{
    partial class UC_AffichagePompier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AffichagePompier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbCarriere = new System.Windows.Forms.GroupBox();
            this.pcbEditGrade = new System.Windows.Forms.PictureBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.pcbGrade = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblBip = new System.Windows.Forms.Label();
            this.pcbEditRdb = new System.Windows.Forms.PictureBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.pnlCacherCmbGrade = new System.Windows.Forms.Panel();
            this.lblCodeGrade = new System.Windows.Forms.Label();
            this.lblInfoCarriere = new System.Windows.Forms.Label();
            this.lblCaserneRattachement = new System.Windows.Forms.Label();
            this.pnlCacherCmbCaserne = new System.Windows.Forms.Panel();
            this.cmbCaserneRattachement = new System.Windows.Forms.ComboBox();
            this.lblHabilitation = new System.Windows.Forms.Label();
            this.lsbHabilitation = new System.Windows.Forms.ListBox();
            this.lsbAffectations = new System.Windows.Forms.ListBox();
            this.lblAffectations = new System.Windows.Forms.Label();
            this.ckbEnConge = new System.Windows.Forms.CheckBox();
            this.pcbEditCaserne = new System.Windows.Forms.PictureBox();
            this.pcbEditConge = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gpbCarriere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrade)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditRdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditCaserne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditConge)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCodeGrade);
            this.panel1.Controls.Add(this.pcbEditRdb);
            this.panel1.Controls.Add(this.gpbCarriere);
            this.panel1.Controls.Add(this.lblDateEmbauche);
            this.panel1.Controls.Add(this.rdbVolontaire);
            this.panel1.Controls.Add(this.rdbProfessionnel);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblDateNaissance);
            this.panel1.Controls.Add(this.lblSexe);
            this.panel1.Controls.Add(this.lblPrenom);
            this.panel1.Controls.Add(this.pcbGrade);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.lblMatricule);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 500);
            this.panel1.TabIndex = 0;
            // 
            // gpbCarriere
            // 
            this.gpbCarriere.Controls.Add(this.pnlCacherCmbGrade);
            this.gpbCarriere.Controls.Add(this.cmbGrade);
            this.gpbCarriere.Controls.Add(this.lblBip);
            this.gpbCarriere.Controls.Add(this.lblTelephone);
            this.gpbCarriere.Controls.Add(this.pcbEditGrade);
            this.gpbCarriere.Controls.Add(this.lblGrade);
            this.gpbCarriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.gpbCarriere.Location = new System.Drawing.Point(23, 331);
            this.gpbCarriere.Name = "gpbCarriere";
            this.gpbCarriere.Size = new System.Drawing.Size(247, 146);
            this.gpbCarriere.TabIndex = 10;
            this.gpbCarriere.TabStop = false;
            this.gpbCarriere.Text = "Carrière";
            // 
            // pcbEditGrade
            // 
            this.pcbEditGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEditGrade.Image = ((System.Drawing.Image)(resources.GetObject("pcbEditGrade.Image")));
            this.pcbEditGrade.Location = new System.Drawing.Point(214, 33);
            this.pcbEditGrade.Name = "pcbEditGrade";
            this.pcbEditGrade.Size = new System.Drawing.Size(20, 20);
            this.pcbEditGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEditGrade.TabIndex = 13;
            this.pcbEditGrade.TabStop = false;
            this.pcbEditGrade.Visible = false;
            this.pcbEditGrade.Click += new System.EventHandler(this.pcbEditGrade_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblGrade.Location = new System.Drawing.Point(20, 32);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(57, 18);
            this.lblGrade.TabIndex = 11;
            this.lblGrade.Text = "Grade :";
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDateEmbauche.Location = new System.Drawing.Point(20, 294);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(207, 18);
            this.lblDateEmbauche.TabIndex = 9;
            this.lblDateEmbauche.Text = "Date d\'embauche : 01/01/2025";
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Enabled = false;
            this.rdbVolontaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdbVolontaire.Location = new System.Drawing.Point(30, 253);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(92, 22);
            this.rdbVolontaire.TabIndex = 8;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Enabled = false;
            this.rdbProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rdbProfessionnel.Location = new System.Drawing.Point(30, 226);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(117, 22);
            this.rdbProfessionnel.TabIndex = 7;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAge.Location = new System.Drawing.Point(20, 189);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(89, 18);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age : 24 ans";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDateNaissance.Location = new System.Drawing.Point(20, 154);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(214, 18);
            this.lblDateNaissance.TabIndex = 5;
            this.lblDateNaissance.Text = "Date de naissance : 01/01/2001";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSexe.Location = new System.Drawing.Point(20, 120);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(112, 18);
            this.lblSexe.TabIndex = 4;
            this.lblSexe.Text = "Sexe : Masculin";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPrenom.Location = new System.Drawing.Point(20, 88);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(106, 18);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom : John";
            // 
            // pcbGrade
            // 
            this.pcbGrade.Image = ((System.Drawing.Image)(resources.GetObject("pcbGrade.Image")));
            this.pcbGrade.InitialImage = null;
            this.pcbGrade.Location = new System.Drawing.Point(209, 11);
            this.pcbGrade.Name = "pcbGrade";
            this.pcbGrade.Size = new System.Drawing.Size(70, 70);
            this.pcbGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGrade.TabIndex = 2;
            this.pcbGrade.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNom.Location = new System.Drawing.Point(20, 56);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(81, 18);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom : Doe";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(17, 11);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(145, 24);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule 0000";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pcbEditConge);
            this.panel2.Controls.Add(this.pcbEditCaserne);
            this.panel2.Controls.Add(this.ckbEnConge);
            this.panel2.Controls.Add(this.lsbAffectations);
            this.panel2.Controls.Add(this.lblAffectations);
            this.panel2.Controls.Add(this.lsbHabilitation);
            this.panel2.Controls.Add(this.lblHabilitation);
            this.panel2.Controls.Add(this.pnlCacherCmbCaserne);
            this.panel2.Controls.Add(this.cmbCaserneRattachement);
            this.panel2.Controls.Add(this.lblCaserneRattachement);
            this.panel2.Controls.Add(this.lblInfoCarriere);
            this.panel2.Location = new System.Drawing.Point(310, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 500);
            this.panel2.TabIndex = 2;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTelephone.Location = new System.Drawing.Point(21, 68);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(169, 18);
            this.lblTelephone.TabIndex = 14;
            this.lblTelephone.Text = "Téléphone : 0712345678";
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBip.Location = new System.Drawing.Point(22, 100);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(73, 18);
            this.lblBip.TabIndex = 15;
            this.lblBip.Text = "Bip : 1234";
            // 
            // pcbEditRdb
            // 
            this.pcbEditRdb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEditRdb.Image = ((System.Drawing.Image)(resources.GetObject("pcbEditRdb.Image")));
            this.pcbEditRdb.Location = new System.Drawing.Point(177, 247);
            this.pcbEditRdb.Name = "pcbEditRdb";
            this.pcbEditRdb.Size = new System.Drawing.Size(20, 20);
            this.pcbEditRdb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEditRdb.TabIndex = 16;
            this.pcbEditRdb.TabStop = false;
            this.pcbEditRdb.Visible = false;
            this.pcbEditRdb.Click += new System.EventHandler(this.pcbEditRdb_Click);
            // 
            // cmbGrade
            // 
            this.cmbGrade.BackColor = System.Drawing.Color.White;
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.Enabled = false;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(78, 30);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(128, 26);
            this.cmbGrade.TabIndex = 0;
            // 
            // pnlCacherCmbGrade
            // 
            this.pnlCacherCmbGrade.BackColor = System.Drawing.Color.White;
            this.pnlCacherCmbGrade.Location = new System.Drawing.Point(183, 32);
            this.pnlCacherCmbGrade.Name = "pnlCacherCmbGrade";
            this.pnlCacherCmbGrade.Size = new System.Drawing.Size(20, 22);
            this.pnlCacherCmbGrade.TabIndex = 16;
            // 
            // lblCodeGrade
            // 
            this.lblCodeGrade.AutoSize = true;
            this.lblCodeGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblCodeGrade.Location = new System.Drawing.Point(225, 82);
            this.lblCodeGrade.Name = "lblCodeGrade";
            this.lblCodeGrade.Size = new System.Drawing.Size(39, 17);
            this.lblCodeGrade.TabIndex = 17;
            this.lblCodeGrade.Text = "CCH";
            // 
            // lblInfoCarriere
            // 
            this.lblInfoCarriere.AutoSize = true;
            this.lblInfoCarriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCarriere.Location = new System.Drawing.Point(46, 10);
            this.lblInfoCarriere.Name = "lblInfoCarriere";
            this.lblInfoCarriere.Size = new System.Drawing.Size(201, 24);
            this.lblInfoCarriere.TabIndex = 18;
            this.lblInfoCarriere.Text = "Informations carrière";
            // 
            // lblCaserneRattachement
            // 
            this.lblCaserneRattachement.AutoSize = true;
            this.lblCaserneRattachement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCaserneRattachement.Location = new System.Drawing.Point(17, 56);
            this.lblCaserneRattachement.Name = "lblCaserneRattachement";
            this.lblCaserneRattachement.Size = new System.Drawing.Size(174, 18);
            this.lblCaserneRattachement.TabIndex = 17;
            this.lblCaserneRattachement.Text = "Caserne de rattachement";
            // 
            // pnlCacherCmbCaserne
            // 
            this.pnlCacherCmbCaserne.BackColor = System.Drawing.Color.White;
            this.pnlCacherCmbCaserne.Location = new System.Drawing.Point(209, 81);
            this.pnlCacherCmbCaserne.Name = "pnlCacherCmbCaserne";
            this.pnlCacherCmbCaserne.Size = new System.Drawing.Size(20, 22);
            this.pnlCacherCmbCaserne.TabIndex = 18;
            // 
            // cmbCaserneRattachement
            // 
            this.cmbCaserneRattachement.BackColor = System.Drawing.Color.White;
            this.cmbCaserneRattachement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaserneRattachement.Enabled = false;
            this.cmbCaserneRattachement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbCaserneRattachement.FormattingEnabled = true;
            this.cmbCaserneRattachement.Location = new System.Drawing.Point(20, 79);
            this.cmbCaserneRattachement.Name = "cmbCaserneRattachement";
            this.cmbCaserneRattachement.Size = new System.Drawing.Size(212, 26);
            this.cmbCaserneRattachement.TabIndex = 17;
            // 
            // lblHabilitation
            // 
            this.lblHabilitation.AutoSize = true;
            this.lblHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblHabilitation.Location = new System.Drawing.Point(17, 141);
            this.lblHabilitation.Name = "lblHabilitation";
            this.lblHabilitation.Size = new System.Drawing.Size(174, 18);
            this.lblHabilitation.TabIndex = 19;
            this.lblHabilitation.Text = "Caserne de rattachement";
            // 
            // lsbHabilitation
            // 
            this.lsbHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lsbHabilitation.FormattingEnabled = true;
            this.lsbHabilitation.ItemHeight = 17;
            this.lsbHabilitation.Location = new System.Drawing.Point(20, 165);
            this.lsbHabilitation.Name = "lsbHabilitation";
            this.lsbHabilitation.Size = new System.Drawing.Size(250, 89);
            this.lsbHabilitation.TabIndex = 20;
            // 
            // lsbAffectations
            // 
            this.lsbAffectations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lsbAffectations.FormattingEnabled = true;
            this.lsbAffectations.ItemHeight = 17;
            this.lsbAffectations.Location = new System.Drawing.Point(20, 312);
            this.lsbAffectations.Name = "lsbAffectations";
            this.lsbAffectations.Size = new System.Drawing.Size(250, 89);
            this.lsbAffectations.TabIndex = 22;
            // 
            // lblAffectations
            // 
            this.lblAffectations.AutoSize = true;
            this.lblAffectations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAffectations.Location = new System.Drawing.Point(17, 288);
            this.lblAffectations.Name = "lblAffectations";
            this.lblAffectations.Size = new System.Drawing.Size(145, 18);
            this.lblAffectations.TabIndex = 21;
            this.lblAffectations.Text = "Affectations passées";
            // 
            // ckbEnConge
            // 
            this.ckbEnConge.AutoSize = true;
            this.ckbEnConge.Enabled = false;
            this.ckbEnConge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ckbEnConge.Location = new System.Drawing.Point(20, 427);
            this.ckbEnConge.Name = "ckbEnConge";
            this.ckbEnConge.Size = new System.Drawing.Size(90, 22);
            this.ckbEnConge.TabIndex = 23;
            this.ckbEnConge.Text = "En congé";
            this.ckbEnConge.UseVisualStyleBackColor = true;
            // 
            // pcbEditCaserne
            // 
            this.pcbEditCaserne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEditCaserne.Image = ((System.Drawing.Image)(resources.GetObject("pcbEditCaserne.Image")));
            this.pcbEditCaserne.Location = new System.Drawing.Point(239, 82);
            this.pcbEditCaserne.Name = "pcbEditCaserne";
            this.pcbEditCaserne.Size = new System.Drawing.Size(20, 20);
            this.pcbEditCaserne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEditCaserne.TabIndex = 17;
            this.pcbEditCaserne.TabStop = false;
            this.pcbEditCaserne.Visible = false;
            this.pcbEditCaserne.Click += new System.EventHandler(this.pcbEditCaserne_Click);
            // 
            // pcbEditConge
            // 
            this.pcbEditConge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbEditConge.Image = ((System.Drawing.Image)(resources.GetObject("pcbEditConge.Image")));
            this.pcbEditConge.Location = new System.Drawing.Point(116, 429);
            this.pcbEditConge.Name = "pcbEditConge";
            this.pcbEditConge.Size = new System.Drawing.Size(20, 20);
            this.pcbEditConge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEditConge.TabIndex = 24;
            this.pcbEditConge.TabStop = false;
            this.pcbEditConge.Visible = false;
            this.pcbEditConge.Click += new System.EventHandler(this.pcbEditConge_Click);
            // 
            // UC_AffichagePompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_AffichagePompier";
            this.Size = new System.Drawing.Size(606, 503);
            this.Load += new System.EventHandler(this.UC_AffichagePompier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbCarriere.ResumeLayout(false);
            this.gpbCarriere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrade)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditRdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditCaserne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEditConge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbGrade;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.GroupBox gpbCarriere;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.PictureBox pcbEditGrade;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.PictureBox pcbEditRdb;
        private System.Windows.Forms.Panel pnlCacherCmbGrade;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label lblCodeGrade;
        private System.Windows.Forms.Panel pnlCacherCmbCaserne;
        private System.Windows.Forms.ComboBox cmbCaserneRattachement;
        private System.Windows.Forms.Label lblCaserneRattachement;
        private System.Windows.Forms.Label lblInfoCarriere;
        private System.Windows.Forms.Label lblHabilitation;
        private System.Windows.Forms.ListBox lsbHabilitation;
        private System.Windows.Forms.CheckBox ckbEnConge;
        private System.Windows.Forms.ListBox lsbAffectations;
        private System.Windows.Forms.Label lblAffectations;
        private System.Windows.Forms.PictureBox pcbEditConge;
        private System.Windows.Forms.PictureBox pcbEditCaserne;
    }
}
