namespace MediaTek86.view
{
    /// <summary>
    /// Vue de GestionsPersonnels
    /// </summary>
    partial class GestionsPersonnels
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLePersonnels = new System.Windows.Forms.DataGridView();
            this.grbLePersonnels = new System.Windows.Forms.GroupBox();
            this.btnAjoutPerso = new System.Windows.Forms.Button();
            this.btnAbsencesPerso = new System.Windows.Forms.Button();
            this.btnModifPerso = new System.Windows.Forms.Button();
            this.btnSuprPerso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLePersonnels)).BeginInit();
            this.grbLePersonnels.SuspendLayout();
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
            // dgvLePersonnels
            // 
            this.dgvLePersonnels.AllowUserToAddRows = false;
            this.dgvLePersonnels.AllowUserToDeleteRows = false;
            this.dgvLePersonnels.AllowUserToResizeColumns = false;
            this.dgvLePersonnels.AllowUserToResizeRows = false;
            this.dgvLePersonnels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLePersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLePersonnels.Location = new System.Drawing.Point(6, 19);
            this.dgvLePersonnels.Name = "dgvLePersonnels";
            this.dgvLePersonnels.ReadOnly = true;
            this.dgvLePersonnels.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLePersonnels.Size = new System.Drawing.Size(711, 195);
            this.dgvLePersonnels.TabIndex = 1;
            // 
            // grbLePersonnels
            // 
            this.grbLePersonnels.Controls.Add(this.btnAjoutPerso);
            this.grbLePersonnels.Controls.Add(this.btnAbsencesPerso);
            this.grbLePersonnels.Controls.Add(this.btnModifPerso);
            this.grbLePersonnels.Controls.Add(this.btnSuprPerso);
            this.grbLePersonnels.Controls.Add(this.dgvLePersonnels);
            this.grbLePersonnels.Location = new System.Drawing.Point(12, 43);
            this.grbLePersonnels.Name = "grbLePersonnels";
            this.grbLePersonnels.Size = new System.Drawing.Size(723, 389);
            this.grbLePersonnels.TabIndex = 2;
            this.grbLePersonnels.TabStop = false;
            this.grbLePersonnels.Text = "le personnel";
            // 
            // btnAjoutPerso
            // 
            this.btnAjoutPerso.Location = new System.Drawing.Point(296, 242);
            this.btnAjoutPerso.Name = "btnAjoutPerso";
            this.btnAjoutPerso.Size = new System.Drawing.Size(132, 42);
            this.btnAjoutPerso.TabIndex = 5;
            this.btnAjoutPerso.Text = "Ajouter un personnel";
            this.btnAjoutPerso.UseVisualStyleBackColor = true;
            this.btnAjoutPerso.Click += new System.EventHandler(this.btnAjoutPerso_Click);
            // 
            // btnAbsencesPerso
            // 
            this.btnAbsencesPerso.Location = new System.Drawing.Point(296, 303);
            this.btnAbsencesPerso.Name = "btnAbsencesPerso";
            this.btnAbsencesPerso.Size = new System.Drawing.Size(132, 42);
            this.btnAbsencesPerso.TabIndex = 4;
            this.btnAbsencesPerso.Text = "Gestions des absences";
            this.btnAbsencesPerso.UseVisualStyleBackColor = true;
            this.btnAbsencesPerso.Click += new System.EventHandler(this.btnAbsencesPerso_Click);
            // 
            // btnModifPerso
            // 
            this.btnModifPerso.Location = new System.Drawing.Point(566, 242);
            this.btnModifPerso.Name = "btnModifPerso";
            this.btnModifPerso.Size = new System.Drawing.Size(132, 42);
            this.btnModifPerso.TabIndex = 3;
            this.btnModifPerso.Text = "Modifier un personnel";
            this.btnModifPerso.UseVisualStyleBackColor = true;
            this.btnModifPerso.Click += new System.EventHandler(this.btnModifPerso_Click);
            // 
            // btnSuprPerso
            // 
            this.btnSuprPerso.Location = new System.Drawing.Point(25, 242);
            this.btnSuprPerso.Name = "btnSuprPerso";
            this.btnSuprPerso.Size = new System.Drawing.Size(132, 42);
            this.btnSuprPerso.TabIndex = 2;
            this.btnSuprPerso.Text = "Supprimer un personnel";
            this.btnSuprPerso.UseVisualStyleBackColor = true;
            this.btnSuprPerso.Click += new System.EventHandler(this.btnSupprPerso_Click);
            // 
            // GestionsPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 444);
            this.Controls.Add(this.grbLePersonnels);
            this.Controls.Add(this.label1);
            this.Name = "GestionsPersonnels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionsPersonnels";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLePersonnels)).EndInit();
            this.grbLePersonnels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLePersonnels;
        private System.Windows.Forms.GroupBox grbLePersonnels;
        private System.Windows.Forms.Button btnSuprPerso;
        private System.Windows.Forms.Button btnAjoutPerso;
        private System.Windows.Forms.Button btnAbsencesPerso;
        private System.Windows.Forms.Button btnModifPerso;
    }
}