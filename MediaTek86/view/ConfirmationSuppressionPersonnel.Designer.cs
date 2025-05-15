namespace MediaTek86.view
{
    partial class ConfirmationSuppressionPersonnel
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
            this.btnConfirmationSupr = new System.Windows.Forms.Button();
            this.btnAnnulationSupr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Souhaitez-vous vraiment supprimer se personnel ?";
            // 
            // btnConfirmationSupr
            // 
            this.btnConfirmationSupr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmationSupr.Location = new System.Drawing.Point(38, 59);
            this.btnConfirmationSupr.Name = "btnConfirmationSupr";
            this.btnConfirmationSupr.Size = new System.Drawing.Size(54, 39);
            this.btnConfirmationSupr.TabIndex = 1;
            this.btnConfirmationSupr.Text = "Oui";
            this.btnConfirmationSupr.UseVisualStyleBackColor = true;
            // 
            // btnAnnulationSupr
            // 
            this.btnAnnulationSupr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulationSupr.Location = new System.Drawing.Point(261, 59);
            this.btnAnnulationSupr.Name = "btnAnnulationSupr";
            this.btnAnnulationSupr.Size = new System.Drawing.Size(54, 39);
            this.btnAnnulationSupr.TabIndex = 2;
            this.btnAnnulationSupr.Text = "Non";
            this.btnAnnulationSupr.UseVisualStyleBackColor = true;
            // 
            // ConfirmationSuppressionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 121);
            this.Controls.Add(this.btnAnnulationSupr);
            this.Controls.Add(this.btnConfirmationSupr);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmationSuppressionPersonnel";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmationSupr;
        private System.Windows.Forms.Button btnAnnulationSupr;
    }
}