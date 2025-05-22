namespace MediaTek86.view
{
    partial class AjoutAbsence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAjoutAbsence = new System.Windows.Forms.GroupBox();
            this.dtpAjoutFin = new System.Windows.Forms.DateTimePicker();
            this.dtpAjoutDebut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMotifAbsence = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerAjoutAbsence = new System.Windows.Forms.Button();
            this.btnAnnulAjoutAbsence = new System.Windows.Forms.Button();
            this.grbAjoutAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAjoutAbsence
            // 
            this.grbAjoutAbsence.Controls.Add(this.dtpAjoutFin);
            this.grbAjoutAbsence.Controls.Add(this.dtpAjoutDebut);
            this.grbAjoutAbsence.Controls.Add(this.label6);
            this.grbAjoutAbsence.Controls.Add(this.label3);
            this.grbAjoutAbsence.Controls.Add(this.label2);
            this.grbAjoutAbsence.Controls.Add(this.label1);
            this.grbAjoutAbsence.Controls.Add(this.cboMotifAbsence);
            this.grbAjoutAbsence.Controls.Add(this.btnEnregistrerAjoutAbsence);
            this.grbAjoutAbsence.Controls.Add(this.btnAnnulAjoutAbsence);
            this.grbAjoutAbsence.Location = new System.Drawing.Point(12, 12);
            this.grbAjoutAbsence.Name = "grbAjoutAbsence";
            this.grbAjoutAbsence.Size = new System.Drawing.Size(412, 206);
            this.grbAjoutAbsence.TabIndex = 0;
            this.grbAjoutAbsence.TabStop = false;
            this.grbAjoutAbsence.Text = "ajout absence";
            // 
            // dtpAjoutFin
            // 
            this.dtpAjoutFin.Location = new System.Drawing.Point(108, 87);
            this.dtpAjoutFin.Name = "dtpAjoutFin";
            this.dtpAjoutFin.Size = new System.Drawing.Size(200, 20);
            this.dtpAjoutFin.TabIndex = 18;
            // 
            // dtpAjoutDebut
            // 
            this.dtpAjoutDebut.Location = new System.Drawing.Point(108, 61);
            this.dtpAjoutDebut.Name = "dtpAjoutDebut";
            this.dtpAjoutDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpAjoutDebut.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "motif :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "date de fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "date de début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajout d\'une absence";
            // 
            // cboMotifAbsence
            // 
            this.cboMotifAbsence.FormattingEnabled = true;
            this.cboMotifAbsence.Location = new System.Drawing.Point(108, 113);
            this.cboMotifAbsence.Name = "cboMotifAbsence";
            this.cboMotifAbsence.Size = new System.Drawing.Size(200, 21);
            this.cboMotifAbsence.TabIndex = 2;
            // 
            // btnEnregistrerAjoutAbsence
            // 
            this.btnEnregistrerAjoutAbsence.Location = new System.Drawing.Point(235, 152);
            this.btnEnregistrerAjoutAbsence.Name = "btnEnregistrerAjoutAbsence";
            this.btnEnregistrerAjoutAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerAjoutAbsence.TabIndex = 1;
            this.btnEnregistrerAjoutAbsence.Text = "Enregistrer";
            this.btnEnregistrerAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnEnregistrerAjoutAbsence.Click += new System.EventHandler(this.btnEnregistrerAjoutAbsence_Click);
            // 
            // btnAnnulAjoutAbsence
            // 
            this.btnAnnulAjoutAbsence.Location = new System.Drawing.Point(108, 152);
            this.btnAnnulAjoutAbsence.Name = "btnAnnulAjoutAbsence";
            this.btnAnnulAjoutAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulAjoutAbsence.TabIndex = 0;
            this.btnAnnulAjoutAbsence.Text = "Annuler";
            this.btnAnnulAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulAjoutAbsence.Click += new System.EventHandler(this.btnAnnulAjoutAbsence_Click);
            // 
            // AjoutAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 226);
            this.Controls.Add(this.grbAjoutAbsence);
            this.Name = "AjoutAbsence";
            this.Text = "AjoutAbsence";
            this.grbAjoutAbsence.ResumeLayout(false);
            this.grbAjoutAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAjoutAbsence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// combobox rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.ComboBox cboMotifAbsence;

        private System.Windows.Forms.Button btnEnregistrerAjoutAbsence;
        private System.Windows.Forms.Button btnAnnulAjoutAbsence;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;

        /// <summary>
        /// datetimepicker rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.DateTimePicker dtpAjoutFin;

        /// <summary>
        /// datetimepicker rendu public pour faciliter la communication
        /// </summary>
        public System.Windows.Forms.DateTimePicker dtpAjoutDebut;
    }
}