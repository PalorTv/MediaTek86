using System;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre d'affichage de la confirmation de la suppression d'une absence
    /// </summary>
    public partial class ConfirmSupprAbsence : Form
    {
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public ConfirmSupprAbsence()
        {
            InitializeComponent();
            btnAnnulSupprAbsence.Click += btnAnnulSupprAbsence_Click;
        }

        /// <summary>
        /// Annule la suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulSupprAbsence_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Confirme la suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmSupprAbsence_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
