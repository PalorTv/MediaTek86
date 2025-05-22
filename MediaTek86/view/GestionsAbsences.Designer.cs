namespace MediaTek86.view
{
    partial class GestionsAbsences
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
            this.dgvLesAbsences = new System.Windows.Forms.DataGridView();
            this.grbLesAbsences = new System.Windows.Forms.GroupBox();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnSupprAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesAbsences)).BeginInit();
            this.grbLesAbsences.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestions des absences";
            // 
            // dgvLesAbsences
            // 
            this.dgvLesAbsences.AllowUserToAddRows = false;
            this.dgvLesAbsences.AllowUserToDeleteRows = false;
            this.dgvLesAbsences.AllowUserToResizeColumns = false;
            this.dgvLesAbsences.AllowUserToResizeRows = false;
            this.dgvLesAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvLesAbsences.Name = "dgvLesAbsences";
            this.dgvLesAbsences.ReadOnly = true;
            this.dgvLesAbsences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLesAbsences.Size = new System.Drawing.Size(711, 195);
            this.dgvLesAbsences.TabIndex = 1;
            // 
            // grbLesAbsences
            // 
            this.grbLesAbsences.Controls.Add(this.btnAjoutAbsence);
            this.grbLesAbsences.Controls.Add(this.btnRetour);
            this.grbLesAbsences.Controls.Add(this.btnModifAbsence);
            this.grbLesAbsences.Controls.Add(this.btnSupprAbsence);
            this.grbLesAbsences.Controls.Add(this.dgvLesAbsences);
            this.grbLesAbsences.Location = new System.Drawing.Point(12, 43);
            this.grbLesAbsences.Name = "grbLesAbsences";
            this.grbLesAbsences.Size = new System.Drawing.Size(723, 389);
            this.grbLesAbsences.TabIndex = 2;
            this.grbLesAbsences.TabStop = false;
            this.grbLesAbsences.Text = "les absences";
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(296, 242);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(132, 42);
            this.btnAjoutAbsence.TabIndex = 5;
            this.btnAjoutAbsence.Text = "Ajouter une absence";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnAjoutAbsence.Click += new System.EventHandler(this.btnAjoutAbsence_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(296, 303);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(132, 42);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(566, 242);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(132, 42);
            this.btnModifAbsence.TabIndex = 3;
            this.btnModifAbsence.Text = "Modifier une absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            this.btnModifAbsence.Click += new System.EventHandler(this.btnModifAbsence_Click);
            // 
            // btnSupprAbsence
            // 
            this.btnSupprAbsence.Location = new System.Drawing.Point(25, 242);
            this.btnSupprAbsence.Name = "btnSupprAbsence";
            this.btnSupprAbsence.Size = new System.Drawing.Size(132, 42);
            this.btnSupprAbsence.TabIndex = 2;
            this.btnSupprAbsence.Text = "Supprimer une absence";
            this.btnSupprAbsence.UseVisualStyleBackColor = true;
            this.btnSupprAbsence.Click += new System.EventHandler(this.btnSupprAbsence_Click);
            // 
            // GestionsAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 444);
            this.Controls.Add(this.grbLesAbsences);
            this.Controls.Add(this.label1);
            this.Name = "GestionsAbsences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionsAbsences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesAbsences)).EndInit();
            this.grbLesAbsences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLesAbsences;
        private System.Windows.Forms.GroupBox grbLesAbsences;
        private System.Windows.Forms.Button btnSupprAbsence;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModifAbsence;
    }
}