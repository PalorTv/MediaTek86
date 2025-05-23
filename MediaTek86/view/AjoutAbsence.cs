﻿using MediaTek86.model;
using MediaTek86.controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre d'affichage de l'ajout d'une absence
    /// </summary>
    public partial class AjoutAbsence : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        private Personnel personnel;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public AjoutAbsence(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            controller = new FrmMediaTek86Controller();
            this.Load += RemplirListeMotifs;
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs(object sender, EventArgs e)
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            cboMotifAbsence.DataSource = lesMotifs;
            cboMotifAbsence.DisplayMember = "libelle";
        }

        /// <summary>
        /// Clique sur le bouton d'annulation de l'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulAjoutAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        /// <summary>
        /// Clique sur le bouton d'enregistrement de l'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAjoutAbsence_Click(object sender, EventArgs e)
        {
            // Vérifie que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(dtpAjoutDebut.Text) ||
                string.IsNullOrWhiteSpace(dtpAjoutFin.Text) ||
                cboMotifAbsence.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Empêche la fermeture du formulaire
                return;
            }

            // Si tout est bon, fermeture du formulaire
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
