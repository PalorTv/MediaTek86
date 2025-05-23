using System;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre d'affichage de la confirmation de la suppression d'un personnel
    /// </summary>
    public partial class ConfirmSupprPersonnel : Form
    {
        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public ConfirmSupprPersonnel()
        {
            InitializeComponent();
            btnAnnulSupprPerso.Click += btnAnnulSupprPerso_Click;
        }

        /// <summary>
        /// Annule la suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulSupprPerso_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Confirme la suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmSuppr_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
