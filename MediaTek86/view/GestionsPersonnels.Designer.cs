namespace MediaTek86.view
{
    partial class GestionsPersonnels
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
            this.dgvLePersonnel = new System.Windows.Forms.DataGridView();
            this.grbLePersonnel = new System.Windows.Forms.GroupBox();
            this.btnSuprPerso = new System.Windows.Forms.Button();
            this.btnModifPerso = new System.Windows.Forms.Button();
            this.btnAbsencesPerso = new System.Windows.Forms.Button();
            this.btnAjoutPerso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLePersonnel)).BeginInit();
            this.grbLePersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestions du personnels";
            // 
            // dgvLePersonnel
            // 
            this.dgvLePersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLePersonnel.Location = new System.Drawing.Point(6, 19);
            this.dgvLePersonnel.Name = "dgvLePersonnel";
            this.dgvLePersonnel.Size = new System.Drawing.Size(711, 195);
            this.dgvLePersonnel.TabIndex = 1;
            // 
            // grbLePersonnel
            // 
            this.grbLePersonnel.Controls.Add(this.btnAjoutPerso);
            this.grbLePersonnel.Controls.Add(this.btnAbsencesPerso);
            this.grbLePersonnel.Controls.Add(this.btnModifPerso);
            this.grbLePersonnel.Controls.Add(this.btnSuprPerso);
            this.grbLePersonnel.Controls.Add(this.dgvLePersonnel);
            this.grbLePersonnel.Location = new System.Drawing.Point(12, 43);
            this.grbLePersonnel.Name = "grbLePersonnel";
            this.grbLePersonnel.Size = new System.Drawing.Size(723, 389);
            this.grbLePersonnel.TabIndex = 2;
            this.grbLePersonnel.TabStop = false;
            this.grbLePersonnel.Text = "le personnel";
            // 
            // btnSuprPerso
            // 
            this.btnSuprPerso.Location = new System.Drawing.Point(25, 242);
            this.btnSuprPerso.Name = "btnSuprPerso";
            this.btnSuprPerso.Size = new System.Drawing.Size(132, 42);
            this.btnSuprPerso.TabIndex = 2;
            this.btnSuprPerso.Text = "Supprimer un personnel";
            this.btnSuprPerso.UseVisualStyleBackColor = true;
            // 
            // btnModifPerso
            // 
            this.btnModifPerso.Location = new System.Drawing.Point(566, 242);
            this.btnModifPerso.Name = "btnModifPerso";
            this.btnModifPerso.Size = new System.Drawing.Size(132, 42);
            this.btnModifPerso.TabIndex = 3;
            this.btnModifPerso.Text = "Modifier un personnel";
            this.btnModifPerso.UseVisualStyleBackColor = true;
            // 
            // btnAbsencesPerso
            // 
            this.btnAbsencesPerso.Location = new System.Drawing.Point(296, 303);
            this.btnAbsencesPerso.Name = "btnAbsencesPerso";
            this.btnAbsencesPerso.Size = new System.Drawing.Size(132, 42);
            this.btnAbsencesPerso.TabIndex = 4;
            this.btnAbsencesPerso.Text = "Gestions des absences";
            this.btnAbsencesPerso.UseVisualStyleBackColor = true;
            // 
            // btnAjoutPerso
            // 
            this.btnAjoutPerso.Location = new System.Drawing.Point(296, 242);
            this.btnAjoutPerso.Name = "btnAjoutPerso";
            this.btnAjoutPerso.Size = new System.Drawing.Size(132, 42);
            this.btnAjoutPerso.TabIndex = 5;
            this.btnAjoutPerso.Text = "Ajouter un personnel";
            this.btnAjoutPerso.UseVisualStyleBackColor = true;
            // 
            // GestionsPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 444);
            this.Controls.Add(this.grbLePersonnel);
            this.Controls.Add(this.label1);
            this.Name = "GestionsPersonnels";
            this.Text = "GestionsPersonnels";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLePersonnel)).EndInit();
            this.grbLePersonnel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLePersonnel;
        private System.Windows.Forms.GroupBox grbLePersonnel;
        private System.Windows.Forms.Button btnSuprPerso;
        private System.Windows.Forms.Button btnAjoutPerso;
        private System.Windows.Forms.Button btnAbsencesPerso;
        private System.Windows.Forms.Button btnModifPerso;
    }
}