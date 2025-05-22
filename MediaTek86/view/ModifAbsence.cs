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
    /// Fenêtre de modification d'une absence
    /// </summary>
    public partial class ModifAbsence : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        private Absence absence;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public ModifAbsence(Absence a, FrmMediaTek86Controller c)
        {
            InitializeComponent();
            controller = c;
            absence = a;
            this.Load += RemplirListeMotifs;
        }

        /// <summary>
        /// Affiche les motifs et pré-remplit les champs
        /// </summary>
        private void RemplirListeMotifs(object sender, EventArgs e)
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            cboModifMotifAbsence.DataSource = lesMotifs;
            cboModifMotifAbsence.DisplayMember = "libelle";
            // Pré-remplit les champs avec les infos de l'absence à modifier
            if (absence != null)
            {
                dtpModifDebut.Value = absence.DateDebut;
                dtpModifFin.Value = absence.DateFin;
                cboModifMotifAbsence.SelectedIndex = cboModifMotifAbsence.FindStringExact(absence.Motif.Libelle);
            }
        }

        /// <summary>
        /// Evènement de clique sur le bouton "Enregistrer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAbsenceEnregistrer_Click(object sender, EventArgs e)
        {
            // Vérifie que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(dtpModifDebut.Text) ||
                string.IsNullOrWhiteSpace(dtpModifFin.Text) ||
                cboModifMotifAbsence.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Empêche la fermeture du formulaire
                return;
            }

            // Si tout est bon, fermeture du formulaire
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Evènement de clique sur le bouton "Annuler"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAbsenceAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
