namespace MediaTek86.view
{
    partial class ConfirmationSuppressionAbsence
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
            this.btnConfirmationSupprAbsence = new System.Windows.Forms.Button();
            this.btnAnnulationSuprAbsence = new System.Windows.Forms.Button();
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
            // btnConfirmationSupprAbsence
            // 
            this.btnConfirmationSupprAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmationSupprAbsence.Location = new System.Drawing.Point(42, 60);
            this.btnConfirmationSupprAbsence.Name = "btnConfirmationSupprAbsence";
            this.btnConfirmationSupprAbsence.Size = new System.Drawing.Size(54, 39);
            this.btnConfirmationSupprAbsence.TabIndex = 1;
            this.btnConfirmationSupprAbsence.Text = "Oui";
            this.btnConfirmationSupprAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAnnulationSuprAbsence
            // 
            this.btnAnnulationSuprAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulationSuprAbsence.Location = new System.Drawing.Point(265, 60);
            this.btnAnnulationSuprAbsence.Name = "btnAnnulationSuprAbsence";
            this.btnAnnulationSuprAbsence.Size = new System.Drawing.Size(54, 39);
            this.btnAnnulationSuprAbsence.TabIndex = 2;
            this.btnAnnulationSuprAbsence.Text = "Non";
            this.btnAnnulationSuprAbsence.UseVisualStyleBackColor = true;
            // 
            // ConfirmationSuppressionAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 121);
            this.Controls.Add(this.btnAnnulationSuprAbsence);
            this.Controls.Add(this.btnConfirmationSupprAbsence);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmationSuppressionAbsence";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmationSupprAbsence;
        private System.Windows.Forms.Button btnAnnulationSuprAbsence;
    }
}