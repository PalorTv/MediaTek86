using MediaTek86.model;
using MediaTek86.controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.view
{

    /// <summary>
    /// Fenêtre de modification du personnel
    /// </summary>
    public partial class ModifPersonnel : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        private Personnel personnel;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public ModifPersonnel(Personnel p, FrmMediaTek86Controller c)
        {
            InitializeComponent();
            controller = c;
            personnel = p;
            this.Load += RemplirListeServices;
        }

        /// <summary>
        /// Affiche les services et pré-remplit les champs
        /// </summary>
        private void RemplirListeServices(object sender, EventArgs e)
        {
            List<Service> lesServices = controller.GetLesServices();
            cboModifService.DataSource = lesServices;
            cboModifService.DisplayMember = "Nom";
            // Pré-remplir les champs avec les infos du personnel à modifier
            if (personnel != null)
            {
                txtModifNom.Text = personnel.Nom;
                txtModifPrenom.Text = personnel.Prenom;
                txtModifTel.Text = personnel.Tel;
                txtModifMail.Text = personnel.Mail;
                cboModifService.SelectedIndex = cboModifService.FindStringExact(personnel.Service.Nom);
            }
        }

        private void btnModifEnregistrer_Click(object sender, EventArgs e)
        {
            // Vérifie que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(txtModifNom.Text) ||
                string.IsNullOrWhiteSpace(txtModifPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtModifTel.Text) ||
                string.IsNullOrWhiteSpace(txtModifMail.Text) ||
                cboModifService.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Empêche la fermeture du formulaire
                return;
            }

            // Si tout est bon, fermeture du formulaire
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnModifAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
