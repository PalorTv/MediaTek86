namespace MediaTek86.view
{
    partial class ConfirmSupprAbsence
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmaSupprAbsence = new System.Windows.Forms.Button();
            this.btnAnnulSupprAbsence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Souhaitez-vous vraiment supprimer cette absence ?";
            // 
            // btnConfirmaSupprAbsence
            // 
            this.btnConfirmaSupprAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaSupprAbsence.Location = new System.Drawing.Point(42, 60);
            this.btnConfirmaSupprAbsence.Name = "btnConfirmaSupprAbsence";
            this.btnConfirmaSupprAbsence.Size = new System.Drawing.Size(54, 39);
            this.btnConfirmaSupprAbsence.TabIndex = 1;
            this.btnConfirmaSupprAbsence.Text = "Oui";
            this.btnConfirmaSupprAbsence.UseVisualStyleBackColor = true;
            this.btnConfirmaSupprAbsence.Click += new System.EventHandler(this.btnConfirmSupprAbsence_Click);
            // 
            // btnAnnulSupprAbsence
            // 
            this.btnAnnulSupprAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulSupprAbsence.Location = new System.Drawing.Point(265, 60);
            this.btnAnnulSupprAbsence.Name = "btnAnnulSupprAbsence";
            this.btnAnnulSupprAbsence.Size = new System.Drawing.Size(54, 39);
            this.btnAnnulSupprAbsence.TabIndex = 2;
            this.btnAnnulSupprAbsence.Text = "Non";
            this.btnAnnulSupprAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulSupprAbsence.Click += new System.EventHandler(this.btnAnnulSupprAbsence_Click);
            // 
            // ConfirmSupprAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 121);
            this.Controls.Add(this.btnAnnulSupprAbsence);
            this.Controls.Add(this.btnConfirmaSupprAbsence);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmSupprAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmaSupprAbsence;
        private System.Windows.Forms.Button btnAnnulSupprAbsence;
    }
}