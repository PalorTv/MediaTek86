namespace MediaTek86.view
{
    /// <summary>
    /// Vue de ModifPersonnel
    /// </summary>
    partial class ModifPersonnel
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grbModifPerso = new System.Windows.Forms.GroupBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cboModifService = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtModifMail = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtModifTel = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtModifPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtModifNom = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnModifEnregistrer = new System.Windows.Forms.Button();
            this.btnModifAnnuler = new System.Windows.Forms.Button();
            this.grbModifPerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbModifPerso
            // 
            this.grbModifPerso.Controls.Add(this.lblService);
            this.grbModifPerso.Controls.Add(this.cboModifService);
            this.grbModifPerso.Controls.Add(this.lblMail);
            this.grbModifPerso.Controls.Add(this.txtModifMail);
            this.grbModifPerso.Controls.Add(this.lblTel);
            this.grbModifPerso.Controls.Add(this.txtModifTel);
            this.grbModifPerso.Controls.Add(this.lblPrenom);
            this.grbModifPerso.Controls.Add(this.txtModifPrenom);
            this.grbModifPerso.Controls.Add(this.lblNom);
            this.grbModifPerso.Controls.Add(this.txtModifNom);
            this.grbModifPerso.Controls.Add(this.lblTitre);
            this.grbModifPerso.Controls.Add(this.btnModifEnregistrer);
            this.grbModifPerso.Controls.Add(this.btnModifAnnuler);
            this.grbModifPerso.Location = new System.Drawing.Point(12, 12);
            this.grbModifPerso.Name = "grbModifPerso";
            this.grbModifPerso.Size = new System.Drawing.Size(412, 273);
            this.grbModifPerso.TabIndex = 0;
            this.grbModifPerso.TabStop = false;
            this.grbModifPerso.Text = "Modification de personnel";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(55, 168);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 9;
            this.lblService.Text = "Service :";
            // 
            // cboModifService
            // 
            this.cboModifService.FormattingEnabled = true;
            this.cboModifService.Location = new System.Drawing.Point(110, 165);
            this.cboModifService.Name = "cboModifService";
            this.cboModifService.Size = new System.Drawing.Size(200, 21);
            this.cboModifService.TabIndex = 10;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(71, 142);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail :";
            // 
            // txtModifMail
            // 
            this.txtModifMail.Location = new System.Drawing.Point(110, 139);
            this.txtModifMail.Name = "txtModifMail";
            this.txtModifMail.Size = new System.Drawing.Size(200, 20);
            this.txtModifMail.TabIndex = 8;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(78, 116);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Tel :";
            // 
            // txtModifTel
            // 
            this.txtModifTel.Location = new System.Drawing.Point(110, 113);
            this.txtModifTel.Name = "txtModifTel";
            this.txtModifTel.Size = new System.Drawing.Size(200, 20);
            this.txtModifTel.TabIndex = 6;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(54, 90);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtModifPrenom
            // 
            this.txtModifPrenom.Location = new System.Drawing.Point(110, 87);
            this.txtModifPrenom.Name = "txtModifPrenom";
            this.txtModifPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtModifPrenom.TabIndex = 4;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(69, 64);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // txtModifNom
            // 
            this.txtModifNom.Location = new System.Drawing.Point(110, 61);
            this.txtModifNom.Name = "txtModifNom";
            this.txtModifNom.Size = new System.Drawing.Size(200, 20);
            this.txtModifNom.TabIndex = 2;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitre.Location = new System.Drawing.Point(100, 16);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(234, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Modification du personnel";
            // 
            // btnModifEnregistrer
            // 
            this.btnModifEnregistrer.Location = new System.Drawing.Point(235, 213);
            this.btnModifEnregistrer.Name = "btnModifEnregistrer";
            this.btnModifEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnModifEnregistrer.TabIndex = 12;
            this.btnModifEnregistrer.Text = "Enregistrer";
            this.btnModifEnregistrer.UseVisualStyleBackColor = true;
            this.btnModifEnregistrer.Click += new System.EventHandler(this.btnModifEnregistrer_Click);
            // 
            // btnModifAnnuler
            // 
            this.btnModifAnnuler.Location = new System.Drawing.Point(110, 213);
            this.btnModifAnnuler.Name = "btnModifAnnuler";
            this.btnModifAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnModifAnnuler.TabIndex = 11;
            this.btnModifAnnuler.Text = "Annuler";
            this.btnModifAnnuler.UseVisualStyleBackColor = true;
            this.btnModifAnnuler.Click += new System.EventHandler(this.btnModifAnnuler_Click);
            // 
            // ModifPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 297);
            this.Controls.Add(this.grbModifPerso);
            this.Name = "ModifPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification Personnel";
            this.grbModifPerso.ResumeLayout(false);
            this.grbModifPerso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbModifPerso;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;

        /// <summary>
        /// textbox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.TextBox txtModifNom;

        private System.Windows.Forms.Label lblPrenom;

        /// <summary>
        /// textbox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.TextBox txtModifPrenom;

        private System.Windows.Forms.Label lblTel;

        /// <summary>
        /// textbox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.TextBox txtModifTel;

        private System.Windows.Forms.Label lblMail;

        /// <summary>
        /// textbox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.TextBox txtModifMail;

        private System.Windows.Forms.Label lblService;

        /// <summary>
        /// combobox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.ComboBox cboModifService;

        /// <summary>
        /// bouton rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.Button btnModifAnnuler;

        /// <summary>
        /// bouton rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.Button btnModifEnregistrer;
    }
}
