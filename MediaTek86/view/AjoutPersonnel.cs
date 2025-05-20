using MediaTek86.model;
using MediaTek86.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// fenêtre d'affichage de l'ajout d'un personnel
    /// </summary>
    public partial class AjoutPersonnel : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public AjoutPersonnel()
        {
            InitializeComponent();
            controller = new FrmMediaTek86Controller();
            this.Load += RemplirListeServices;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeServices(object sender, EventArgs e)
        {
            List<Service> lesServices = controller.GetLesServices();
            cboAjoutService.DataSource = lesServices;
            cboAjoutService.DisplayMember = "Nom";
        }

        private void btnAjoutEnregistrer_Click(object sender, EventArgs e)
        {
            // Vérifie que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(txtAjoutNom.Text) ||
                string.IsNullOrWhiteSpace(txtAjoutPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtAjoutTel.Text) ||
                string.IsNullOrWhiteSpace(txtAjoutMail.Text) ||
                cboAjoutService.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Empêche la fermeture du formulaire
                return; 
            }

            // Si tout est bon, fermeture du formulaire
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAjoutAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
