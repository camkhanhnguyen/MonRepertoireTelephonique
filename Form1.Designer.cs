
namespace MonRepertoireTelephonique
{
    partial class frmMonReTe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonReTe));
            this.gpbContacts = new System.Windows.Forms.GroupBox();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.gpbAjouterContact = new System.Windows.Forms.GroupBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.rdbAmis = new System.Windows.Forms.RadioButton();
            this.rdbFamille = new System.Windows.Forms.RadioButton();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.ptbPhoto = new System.Windows.Forms.PictureBox();
            this.gpbRecherche = new System.Windows.Forms.GroupBox();
            this.txtRechercheTel = new System.Windows.Forms.TextBox();
            this.lblTelRecherche = new System.Windows.Forms.Label();
            this.txtRecherchePrenom = new System.Windows.Forms.TextBox();
            this.lblPrénomRecherche = new System.Windows.Forms.Label();
            this.lblNomRecherche = new System.Windows.Forms.Label();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.gpbContacts.SuspendLayout();
            this.gpbAjouterContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.gpbRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbContacts
            // 
            this.gpbContacts.Controls.Add(this.lstContacts);
            this.gpbContacts.Controls.Add(this.btnModifier);
            this.gpbContacts.Controls.Add(this.btnSupprimer);
            this.gpbContacts.Controls.Add(this.btnNouveauContact);
            this.gpbContacts.Location = new System.Drawing.Point(411, 24);
            this.gpbContacts.Name = "gpbContacts";
            this.gpbContacts.Size = new System.Drawing.Size(658, 694);
            this.gpbContacts.TabIndex = 5;
            this.gpbContacts.TabStop = false;
            this.gpbContacts.Text = "Contact";
            // 
            // lstContacts
            // 
            this.lstContacts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.HorizontalScrollbar = true;
            this.lstContacts.ItemHeight = 16;
            this.lstContacts.Location = new System.Drawing.Point(6, 24);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.ScrollAlwaysVisible = true;
            this.lstContacts.Size = new System.Drawing.Size(646, 596);
            this.lstContacts.TabIndex = 4;
            this.lstContacts.Click += new System.EventHandler(this.lstContacts_Click);
            this.lstContacts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstContacts_DrawItem);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(515, 638);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(54, 50);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Image")));
            this.btnSupprimer.Location = new System.Drawing.Point(597, 638);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(54, 50);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveauContact.Image")));
            this.btnNouveauContact.Location = new System.Drawing.Point(431, 639);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(52, 49);
            this.btnNouveauContact.TabIndex = 4;
            this.btnNouveauContact.UseVisualStyleBackColor = true;
            this.btnNouveauContact.Click += new System.EventHandler(this.btnNouveauContact_Click);
            // 
            // gpbAjouterContact
            // 
            this.gpbAjouterContact.Controls.Add(this.lblAdresse);
            this.gpbAjouterContact.Controls.Add(this.txtAdresse);
            this.gpbAjouterContact.Controls.Add(this.lblEmail);
            this.gpbAjouterContact.Controls.Add(this.txtEmail);
            this.gpbAjouterContact.Controls.Add(this.rdbProfessionnel);
            this.gpbAjouterContact.Controls.Add(this.btnAjouter);
            this.gpbAjouterContact.Controls.Add(this.btnAnnuler);
            this.gpbAjouterContact.Controls.Add(this.rdbAmis);
            this.gpbAjouterContact.Controls.Add(this.rdbFamille);
            this.gpbAjouterContact.Controls.Add(this.lblTel);
            this.gpbAjouterContact.Controls.Add(this.txtTel);
            this.gpbAjouterContact.Controls.Add(this.txtPrenom);
            this.gpbAjouterContact.Controls.Add(this.lblPrenom);
            this.gpbAjouterContact.Controls.Add(this.txtNom);
            this.gpbAjouterContact.Controls.Add(this.lblNom);
            this.gpbAjouterContact.Location = new System.Drawing.Point(26, 179);
            this.gpbAjouterContact.Name = "gpbAjouterContact";
            this.gpbAjouterContact.Size = new System.Drawing.Size(360, 354);
            this.gpbAjouterContact.TabIndex = 7;
            this.gpbAjouterContact.TabStop = false;
            this.gpbAjouterContact.Text = "Ajouter Contact";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(15, 256);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(60, 17);
            this.lblAdresse.TabIndex = 14;
            this.lblAdresse.Text = "Adresse";
            this.lblAdresse.Visible = false;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(75, 250);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(265, 27);
            this.txtAdresse.TabIndex = 13;
            this.txtAdresse.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 213);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(75, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 27);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Visible = false;
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbProfessionnel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rdbProfessionnel.Location = new System.Drawing.Point(212, 37);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(128, 21);
            this.rdbProfessionnel.TabIndex = 10;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            this.rdbProfessionnel.CheckedChanged += new System.EventHandler(this.rdbProfessionnel_CheckedChanged_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::MonRepertoireTelephonique.Properties.Resources.ajouter;
            this.btnAjouter.Location = new System.Drawing.Point(211, 293);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(54, 50);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::MonRepertoireTelephonique.Properties.Resources.annuler;
            this.btnAnnuler.Location = new System.Drawing.Point(286, 293);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(54, 50);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // rdbAmis
            // 
            this.rdbAmis.AutoSize = true;
            this.rdbAmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAmis.ForeColor = System.Drawing.Color.SeaGreen;
            this.rdbAmis.Location = new System.Drawing.Point(123, 37);
            this.rdbAmis.Name = "rdbAmis";
            this.rdbAmis.Size = new System.Drawing.Size(63, 21);
            this.rdbAmis.TabIndex = 9;
            this.rdbAmis.TabStop = true;
            this.rdbAmis.Text = "Amis";
            this.rdbAmis.UseVisualStyleBackColor = true;
            this.rdbAmis.CheckedChanged += new System.EventHandler(this.rdbAmis_CheckedChanged);
            // 
            // rdbFamille
            // 
            this.rdbFamille.AutoSize = true;
            this.rdbFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFamille.ForeColor = System.Drawing.Color.Purple;
            this.rdbFamille.Location = new System.Drawing.Point(18, 37);
            this.rdbFamille.Name = "rdbFamille";
            this.rdbFamille.Size = new System.Drawing.Size(80, 21);
            this.rdbFamille.TabIndex = 8;
            this.rdbFamille.TabStop = true;
            this.rdbFamille.Text = "Famille";
            this.rdbFamille.UseVisualStyleBackColor = true;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(15, 170);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 17);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Tel";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(75, 164);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(265, 27);
            this.txtTel.TabIndex = 6;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(75, 121);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(265, 27);
            this.txtPrenom.TabIndex = 5;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenom_KeyPress);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(15, 127);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(75, 77);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(265, 27);
            this.txtNom.TabIndex = 3;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(15, 83);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(146, 144);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(119, 17);
            this.lblPhoto.TabIndex = 8;
            this.lblPhoto.Text = "Choisir une photo";
            this.lblPhoto.Click += new System.EventHandler(this.lblPhoto_Click);
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.Location = new System.Drawing.Point(127, 25);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(164, 148);
            this.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPhoto.TabIndex = 6;
            this.ptbPhoto.TabStop = false;
            // 
            // gpbRecherche
            // 
            this.gpbRecherche.Controls.Add(this.txtRechercheTel);
            this.gpbRecherche.Controls.Add(this.lblTelRecherche);
            this.gpbRecherche.Controls.Add(this.txtRecherchePrenom);
            this.gpbRecherche.Controls.Add(this.lblPrénomRecherche);
            this.gpbRecherche.Controls.Add(this.lblNomRecherche);
            this.gpbRecherche.Controls.Add(this.txtRechercheNom);
            this.gpbRecherche.Location = new System.Drawing.Point(26, 550);
            this.gpbRecherche.Name = "gpbRecherche";
            this.gpbRecherche.Size = new System.Drawing.Size(360, 168);
            this.gpbRecherche.TabIndex = 9;
            this.gpbRecherche.TabStop = false;
            this.gpbRecherche.Text = "Recherche";
            // 
            // txtRechercheTel
            // 
            this.txtRechercheTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercheTel.Location = new System.Drawing.Point(75, 126);
            this.txtRechercheTel.Name = "txtRechercheTel";
            this.txtRechercheTel.Size = new System.Drawing.Size(265, 27);
            this.txtRechercheTel.TabIndex = 9;
            this.txtRechercheTel.TextChanged += new System.EventHandler(this.txtRechercheTel_TextChanged);
            this.txtRechercheTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRechercheTel_KeyPress);
            // 
            // lblTelRecherche
            // 
            this.lblTelRecherche.AutoSize = true;
            this.lblTelRecherche.Location = new System.Drawing.Point(15, 132);
            this.lblTelRecherche.Name = "lblTelRecherche";
            this.lblTelRecherche.Size = new System.Drawing.Size(28, 17);
            this.lblTelRecherche.TabIndex = 8;
            this.lblTelRecherche.Text = "Tel";
            // 
            // txtRecherchePrenom
            // 
            this.txtRecherchePrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherchePrenom.Location = new System.Drawing.Point(75, 83);
            this.txtRecherchePrenom.Name = "txtRecherchePrenom";
            this.txtRecherchePrenom.Size = new System.Drawing.Size(265, 27);
            this.txtRecherchePrenom.TabIndex = 3;
            this.txtRecherchePrenom.TextChanged += new System.EventHandler(this.txtRecherchePrenom_TextChanged);
            this.txtRecherchePrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecherchePrenom_KeyPress);
            // 
            // lblPrénomRecherche
            // 
            this.lblPrénomRecherche.AutoSize = true;
            this.lblPrénomRecherche.Location = new System.Drawing.Point(15, 89);
            this.lblPrénomRecherche.Name = "lblPrénomRecherche";
            this.lblPrénomRecherche.Size = new System.Drawing.Size(57, 17);
            this.lblPrénomRecherche.TabIndex = 2;
            this.lblPrénomRecherche.Text = "Prénom";
            // 
            // lblNomRecherche
            // 
            this.lblNomRecherche.AutoSize = true;
            this.lblNomRecherche.Location = new System.Drawing.Point(15, 47);
            this.lblNomRecherche.Name = "lblNomRecherche";
            this.lblNomRecherche.Size = new System.Drawing.Size(37, 17);
            this.lblNomRecherche.TabIndex = 1;
            this.lblNomRecherche.Text = "Nom";
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercheNom.Location = new System.Drawing.Point(75, 41);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(265, 27);
            this.txtRechercheNom.TabIndex = 0;
            this.txtRechercheNom.TextChanged += new System.EventHandler(this.txtRechercheNom_TextChanged);
            this.txtRechercheNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRechercheNom_KeyPress);
            // 
            // frmMonReTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1081, 735);
            this.Controls.Add(this.gpbRecherche);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.gpbAjouterContact);
            this.Controls.Add(this.ptbPhoto);
            this.Controls.Add(this.gpbContacts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMonReTe";
            this.Text = "Mon Répertoire Téléphonique";
            this.Load += new System.EventHandler(this.frmMonReTe_Load);
            this.gpbContacts.ResumeLayout(false);
            this.gpbAjouterContact.ResumeLayout(false);
            this.gpbAjouterContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).EndInit();
            this.gpbRecherche.ResumeLayout(false);
            this.gpbRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.GroupBox gpbContacts;
        private System.Windows.Forms.PictureBox ptbPhoto;
        private System.Windows.Forms.GroupBox gpbAjouterContact;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.RadioButton rdbAmis;
        private System.Windows.Forms.RadioButton rdbFamille;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.GroupBox gpbRecherche;
        private System.Windows.Forms.Label lblNomRecherche;
        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.TextBox txtRecherchePrenom;
        private System.Windows.Forms.Label lblPrénomRecherche;
        private System.Windows.Forms.TextBox txtRechercheTel;
        private System.Windows.Forms.Label lblTelRecherche;
    }
}

