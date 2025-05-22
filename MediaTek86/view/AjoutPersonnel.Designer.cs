namespace MediaTek86.view
{
    /// <summary>
    /// Vue d'AjoutPersonnel
    /// </summary>
    public partial class AjoutPersonnel
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
            this.grbAjoutPerso = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAjoutMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAjoutTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAjoutPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAjoutNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAjoutService = new System.Windows.Forms.ComboBox();
            this.btnAjoutEnregistrer = new System.Windows.Forms.Button();
            this.btnAjoutAnnuler = new System.Windows.Forms.Button();
            this.grbAjoutPerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAjoutPerso
            // 
            this.grbAjoutPerso.Controls.Add(this.label6);
            this.grbAjoutPerso.Controls.Add(this.txtAjoutMail);
            this.grbAjoutPerso.Controls.Add(this.label5);
            this.grbAjoutPerso.Controls.Add(this.txtAjoutTel);
            this.grbAjoutPerso.Controls.Add(this.label4);
            this.grbAjoutPerso.Controls.Add(this.txtAjoutPrenom);
            this.grbAjoutPerso.Controls.Add(this.label3);
            this.grbAjoutPerso.Controls.Add(this.txtAjoutNom);
            this.grbAjoutPerso.Controls.Add(this.label2);
            this.grbAjoutPerso.Controls.Add(this.label1);
            this.grbAjoutPerso.Controls.Add(this.cboAjoutService);
            this.grbAjoutPerso.Controls.Add(this.btnAjoutEnregistrer);
            this.grbAjoutPerso.Controls.Add(this.btnAjoutAnnuler);
            this.grbAjoutPerso.Location = new System.Drawing.Point(12, 12);
            this.grbAjoutPerso.Name = "grbAjoutPerso";
            this.grbAjoutPerso.Size = new System.Drawing.Size(412, 273);
            this.grbAjoutPerso.TabIndex = 0;
            this.grbAjoutPerso.TabStop = false;
            this.grbAjoutPerso.Text = "ajout personnel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "service :";
            // 
            // txtAjoutMail
            // 
            this.txtAjoutMail.Location = new System.Drawing.Point(110, 139);
            this.txtAjoutMail.Name = "txtAjoutMail";
            this.txtAjoutMail.Size = new System.Drawing.Size(200, 20);
            this.txtAjoutMail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "mail :";
            // 
            // txtAjoutTel
            // 
            this.txtAjoutTel.Location = new System.Drawing.Point(110, 113);
            this.txtAjoutTel.Name = "txtAjoutTel";
            this.txtAjoutTel.Size = new System.Drawing.Size(200, 20);
            this.txtAjoutTel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "tel :";
            // 
            // txtAjoutPrenom
            // 
            this.txtAjoutPrenom.Location = new System.Drawing.Point(110, 87);
            this.txtAjoutPrenom.Name = "txtAjoutPrenom";
            this.txtAjoutPrenom.Size = new System.Drawing.Size(200, 20);
            this.txtAjoutPrenom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "prénom :";
            // 
            // txtAjoutNom
            // 
            this.txtAjoutNom.Location = new System.Drawing.Point(110, 61);
            this.txtAjoutNom.Name = "txtAjoutNom";
            this.txtAjoutNom.Size = new System.Drawing.Size(200, 20);
            this.txtAjoutNom.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajout d\'un personnel";
            // 
            // cboAjoutService
            // 
            this.cboAjoutService.FormattingEnabled = true;
            this.cboAjoutService.Location = new System.Drawing.Point(110, 165);
            this.cboAjoutService.Name = "cboAjoutService";
            this.cboAjoutService.Size = new System.Drawing.Size(200, 21);
            this.cboAjoutService.TabIndex = 2;
            // 
            // btnAjoutEnregistrer
            // 
            this.btnAjoutEnregistrer.Location = new System.Drawing.Point(235, 213);
            this.btnAjoutEnregistrer.Name = "btnAjoutEnregistrer";
            this.btnAjoutEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutEnregistrer.TabIndex = 1;
            this.btnAjoutEnregistrer.Text = "Enregistrer";
            this.btnAjoutEnregistrer.UseVisualStyleBackColor = true;
            this.btnAjoutEnregistrer.Click += new System.EventHandler(this.btnAjoutEnregistrer_Click);
            // 
            // btnAjoutAnnuler
            // 
            this.btnAjoutAnnuler.Location = new System.Drawing.Point(110, 213);
            this.btnAjoutAnnuler.Name = "btnAjoutAnnuler";
            this.btnAjoutAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutAnnuler.TabIndex = 0;
            this.btnAjoutAnnuler.Text = "Annuler";
            this.btnAjoutAnnuler.UseVisualStyleBackColor = true;
            this.btnAjoutAnnuler.Click += new System.EventHandler(this.btnAjoutAnnuler_Click);
            // 
            // AjoutPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 297);
            this.Controls.Add(this.grbAjoutPerso);
            this.Name = "AjoutPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutPersonnel";
            this.grbAjoutPerso.ResumeLayout(false);
            this.grbAjoutPerso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAjoutPerso;

        /// <summary>
        /// textbox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.TextBox txtAjoutNom;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// combobox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.ComboBox cboAjoutService;

        private System.Windows.Forms.Button btnAjoutEnregistrer;
        private System.Windows.Forms.Button btnAjoutAnnuler;
        private System.Windows.Forms.Label label6;

        /// <summary>
        /// textbox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.TextBox txtAjoutMail;

        private System.Windows.Forms.Label label5;

        /// <summary>
        /// textbox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.TextBox txtAjoutTel;

        private System.Windows.Forms.Label label4;

        /// <summary>
        /// textbox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.TextBox txtAjoutPrenom;

        private System.Windows.Forms.Label label3;
    }
}