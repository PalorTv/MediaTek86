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
            this.cmbMotifAbsence = new System.Windows.Forms.ComboBox();
            this.btnAjoutAbsenceEnregistrer = new System.Windows.Forms.Button();
            this.btnAjoutAbsenceAnnuler = new System.Windows.Forms.Button();
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
            this.grbAjoutAbsence.Controls.Add(this.cmbMotifAbsence);
            this.grbAjoutAbsence.Controls.Add(this.btnAjoutAbsenceEnregistrer);
            this.grbAjoutAbsence.Controls.Add(this.btnAjoutAbsenceAnnuler);
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
            // cmbMotifAbsence
            // 
            this.cmbMotifAbsence.FormattingEnabled = true;
            this.cmbMotifAbsence.Location = new System.Drawing.Point(108, 113);
            this.cmbMotifAbsence.Name = "cmbMotifAbsence";
            this.cmbMotifAbsence.Size = new System.Drawing.Size(200, 21);
            this.cmbMotifAbsence.TabIndex = 2;
            // 
            // btnAjoutAbsenceEnregistrer
            // 
            this.btnAjoutAbsenceEnregistrer.Location = new System.Drawing.Point(235, 152);
            this.btnAjoutAbsenceEnregistrer.Name = "btnAjoutAbsenceEnregistrer";
            this.btnAjoutAbsenceEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutAbsenceEnregistrer.TabIndex = 1;
            this.btnAjoutAbsenceEnregistrer.Text = "Enregistrer";
            this.btnAjoutAbsenceEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnAjoutAbsenceAnnuler
            // 
            this.btnAjoutAbsenceAnnuler.Location = new System.Drawing.Point(108, 152);
            this.btnAjoutAbsenceAnnuler.Name = "btnAjoutAbsenceAnnuler";
            this.btnAjoutAbsenceAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutAbsenceAnnuler.TabIndex = 0;
            this.btnAjoutAbsenceAnnuler.Text = "Annuler";
            this.btnAjoutAbsenceAnnuler.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ComboBox cmbMotifAbsence;
        private System.Windows.Forms.Button btnAjoutAbsenceEnregistrer;
        private System.Windows.Forms.Button btnAjoutAbsenceAnnuler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAjoutFin;
        private System.Windows.Forms.DateTimePicker dtpAjoutDebut;
    }
}