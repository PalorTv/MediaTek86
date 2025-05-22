namespace MediaTek86.view
{
    partial class ConfirmSupprPersonnel
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
            this.btnConfirmSuppr = new System.Windows.Forms.Button();
            this.btnAnnulSupprPerso = new System.Windows.Forms.Button();
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
            // btnConfirmSuppr
            // 
            this.btnConfirmSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSuppr.Location = new System.Drawing.Point(38, 59);
            this.btnConfirmSuppr.Name = "btnConfirmSuppr";
            this.btnConfirmSuppr.Size = new System.Drawing.Size(54, 39);
            this.btnConfirmSuppr.TabIndex = 1;
            this.btnConfirmSuppr.Text = "Oui";
            this.btnConfirmSuppr.UseVisualStyleBackColor = true;
            this.btnConfirmSuppr.Click += new System.EventHandler(this.btnConfirmSuppr_Click);
            // 
            // btnAnnulSupprPerso
            // 
            this.btnAnnulSupprPerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulSupprPerso.Location = new System.Drawing.Point(261, 59);
            this.btnAnnulSupprPerso.Name = "btnAnnulSupprPerso";
            this.btnAnnulSupprPerso.Size = new System.Drawing.Size(54, 39);
            this.btnAnnulSupprPerso.TabIndex = 2;
            this.btnAnnulSupprPerso.Text = "Non";
            this.btnAnnulSupprPerso.UseVisualStyleBackColor = true;
            this.btnAnnulSupprPerso.Click += new System.EventHandler(this.btnAnnulSupprPerso_Click);
            // 
            // ConfirmSupprPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 121);
            this.Controls.Add(this.btnAnnulSupprPerso);
            this.Controls.Add(this.btnConfirmSuppr);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmSupprPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmSuppr;
        private System.Windows.Forms.Button btnAnnulSupprPerso;
    }
}