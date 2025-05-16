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
            this.cboService = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grbModifPerso.SuspendLayout();
            this.SuspendLayout();

            // 
            // grbModifPerso
            // 
            this.grbModifPerso.Controls.Add(this.lblService);
            this.grbModifPerso.Controls.Add(this.cboService);
            this.grbModifPerso.Controls.Add(this.lblMail);
            this.grbModifPerso.Controls.Add(this.txtMail);
            this.grbModifPerso.Controls.Add(this.lblTel);
            this.grbModifPerso.Controls.Add(this.txtTel);
            this.grbModifPerso.Controls.Add(this.lblPrenom);
            this.grbModifPerso.Controls.Add(this.txtPrenom);
            this.grbModifPerso.Controls.Add(this.lblNom);
            this.grbModifPerso.Controls.Add(this.txtNom);
            this.grbModifPerso.Controls.Add(this.lblTitre);
            this.grbModifPerso.Controls.Add(this.btnEnregistrer);
            this.grbModifPerso.Controls.Add(this.btnAnnuler);
            this.grbModifPerso.Location = new System.Drawing.Point(12, 12);
            this.grbModifPerso.Name = "grbModifPerso";
            this.grbModifPerso.Size = new System.Drawing.Size(412, 273);
            this.grbModifPerso.TabIndex = 0;
            this.grbModifPerso.TabStop = false;
            this.grbModifPerso.Text = "Modification de personnel";

            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitre.Location = new System.Drawing.Point(100, 16);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(220, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Modification du personnel";

            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(69, 64);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";

            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(110, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            this.txtNom.TabIndex = 2;

            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(54, 90);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(48, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom :";

            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(110, 87);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtPrenom.TabIndex = 4;

            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(78, 116);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(26, 13);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Tel :";

            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(110, 113);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 20);
            this.txtTel.TabIndex = 6;

            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(71, 142);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(31, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail :";

            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(110, 139);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 20);
            this.txtMail.TabIndex = 8;

            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(55, 168);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(47, 13);
            this.lblService.TabIndex = 9;
            this.lblService.Text = "Service :";

            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(110, 165);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(200, 21);
            this.cboService.TabIndex = 10;

            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(110, 213);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;

            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(235, 213);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;

            // 
            // ModifPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 297);
            this.Controls.Add(this.grbModifPerso);
            this.Name = "ModifPersonnel";
            this.Text = "Modification Personnel";
            this.grbModifPerso.ResumeLayout(false);
            this.grbModifPerso.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grbModifPerso;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}
