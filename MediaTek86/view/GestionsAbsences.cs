using MediaTek86.controller;
using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre d'affichage des absences
    /// </summary>
    public partial class GestionsAbsences : Form
    {
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        /// <summary>
        /// Conserve en mémoire l'objet représentant le personnel sélectionné
        /// </summary>
        private Personnel personnel;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public GestionsAbsences(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediaTek86Controller();
            RemplirListeAbsences();
            dgvLesAbsences.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLesAbsences.MultiSelect = false;
            dgvLesAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLesAbsences.Width = this.ClientSize.Width - 40;
            dgvLesAbsences.Left = 20;
            grbLesAbsences.Text = "";
        }

        /// <summary>
        /// Centre le DataGridView
        /// </summary>
        private void CentrerDgvAbsences()
        {
            dgvLesAbsences.Left = (this.ClientSize.Width - dgvLesAbsences.Width) / 2; dgvLesAbsences.Left = (this.ClientSize.Width - dgvLesAbsences.Width) / 2;
        }

        /// <summary>
        /// Affiche les absences et gère l'affichage
        /// </summary>
        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetLesAbsences();

            // Filtre selon le personnel sélectionné
            List<Absence> lesAbsencesDuPersonnel = lesAbsences.Where(a => a.IdPersonnel == personnel.Idpersonnel).ToList();
            bdgAbsences.DataSource = null;
            bdgAbsences.DataSource = lesAbsencesDuPersonnel;
            dgvLesAbsences.DataSource = bdgAbsences;

            // Cache la colonne idpersonnel à chaque remplissage
            if (dgvLesAbsences.Columns["idpersonnel"] != null)
            {
                dgvLesAbsences.Columns["idpersonnel"].Visible = false;
            }

            // Cache la colonne AncienneDateDebut à chaque remplissage
            if (dgvLesAbsences.Columns["AncienneDateDebut"] != null)
            {
                dgvLesAbsences.Columns["AncienneDateDebut"].Visible = false;
            }

            // Formate les colonnes date pour ne pas afficher l'heure
            if (dgvLesAbsences.Columns["datedebut"] != null)
                dgvLesAbsences.Columns["datedebut"].DefaultCellStyle.Format = "yyyy-MM-dd";

            if (dgvLesAbsences.Columns["datefin"] != null)
                dgvLesAbsences.Columns["datefin"].DefaultCellStyle.Format = "yyyy-MM-dd";

            dgvLesAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CentrerDgvAbsences();
        }

        /// <summary>
        /// Vérifie si une absence existe déjà pour ce personnel à cette date
        /// </summary>
        private bool AbsenceExisteDeja(DateTime debut, DateTime fin)
        {
            var absences = controller.GetLesAbsences(personnel.Idpersonnel);

            foreach (var absence in absences)
            {
                // Si les périodes se chevauchent
                if (debut < absence.DateFin && fin > absence.DateDebut)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Clique sur le bouton de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprAbsence_Click(object sender, EventArgs e)
        {
            if (dgvLesAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)dgvLesAbsences.SelectedRows[0].DataBoundItem;
                Personnel personnel = this.personnel;
                ConfirmSupprAbsence confirmSupprAbsence = new ConfirmSupprAbsence();
                var result = confirmSupprAbsence.ShowDialog();

                if (result == DialogResult.OK)
                {
                    AfficherMessageAbsence("supprimée", absence.DateDebut, absence.DateFin);
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
                else
                { 

                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Clique sur le bouton d'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutAbsence_Click(object sender, EventArgs e)
        {
            // Crée une instance du formulaire AjoutPersonnel
            AjoutAbsence ajoutAbsence = new AjoutAbsence(personnel);

            // Affiche le formulaire 
            var result = ajoutAbsence.ShowDialog();

            // Si l'utilisateur a cliqué sur "Enregistrer"
            if (result == DialogResult.OK)
            {
                // Récupéres les valeurs après la fermeture du formulaire
                DateTime datedebut = ajoutAbsence.dtpAjoutDebut.Value;
                DateTime datefin = ajoutAbsence.dtpAjoutFin.Value;
                Motif motif = (Motif)ajoutAbsence.cboMotifAbsence.SelectedItem;

                // Vérifie que tous les champs sont remplis
                if (datedebut != null && datefin != null && motif != null)
                {
                    // Crée un objet Absence et l'ajoute
                    Absence absence = new Absence(personnel.Idpersonnel, datedebut, datefin, motif);

                    // Vérifie qu'aucune autre absence ne chevauche ces dates
                    if (controller.AbsenceExisteDejaPourAjout(personnel.Idpersonnel, datedebut, datefin))
                    {
                        MessageBox.Show("Ce personnel a déjà une absence à cette date.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Vérifie que la date de fin n'est pas antérieure à la date de début
                    if (datefin < datedebut)
                    {
                        MessageBox.Show("La date de fin ne peut pas être antérieure ou égale à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Ajout à la BDD
                    controller.AddAbsence(absence);

                    // Met à jour la liste des absences dans l'interface
                    RemplirListeAbsences();
                    AfficherMessageAbsence("ajoutée", datedebut, datefin);
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            }
        }

        /// <summary>
        /// Clique sur le bouton de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAbsence_Click(object sender, EventArgs e)
        {
            if (dgvLesAbsences.Rows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];

                // Passe l'objet absence et le controller au formulaire
                ModifAbsence modifAbsence = new ModifAbsence(absence, controller);

                var result = modifAbsence.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Récupère les nouvelles valeurs depuis le formulaire
                    DateTime nouvelleDateDebut = modifAbsence.NouvelleDateDebut.Date;
                    DateTime nouvelleDateFin = modifAbsence.NouvelleDateFin.Date;
                    Motif nouveauMotif = modifAbsence.NouveauMotif;

                    // Sauvegarde des anciennes dates
                    DateTime ancienneDateDebut = absence.DateDebut.Date;
                    DateTime ancienneDateFin = absence.DateFin.Date;

                    // Vérifie qu'aucune autre absence ne chevauche ces dates
                    if (controller.AbsenceExisteDejaPourModif(absence.IdPersonnel, nouvelleDateDebut, nouvelleDateFin, ancienneDateDebut, ancienneDateFin))
                    {
                        MessageBox.Show("Une autre absence existe déjà dans ce créneau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Vérifie que la date de fin n'est pas antérieure à la date de début
                    if (nouvelleDateFin < nouvelleDateDebut)
                    {
                        MessageBox.Show("La date de fin ne peut pas être antérieure ou égale à la date de début.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Met à jour l'objet absence
                    absence.AncienneDateDebut = ancienneDateDebut;
                    absence.DateDebut = nouvelleDateDebut;
                    absence.DateFin = nouvelleDateFin;
                    absence.Motif = nouveauMotif;

                    // Met à jour dans la base de données
                    controller.UpdateAbsence(absence);
                    AfficherMessageAbsence("modifiée", nouvelleDateDebut, nouvelleDateFin);

                    // Rafraîchit l'affichage
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Clique sur le bouton de retour en arrière
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            GestionsAbsences.ActiveForm.Close();
        }

        /// <summary>
        /// Affiche un message d'information concernant une absence
        /// </summary>
        /// <param name="action">"ajoutée", "modifiée" ou "supprimée"</param>
        /// <param name="datedebut">Date de début</param>
        /// <param name="datefin">Date de fin</param>
        private void AfficherMessageAbsence(string action, DateTime datedebut, DateTime datefin)
        {
            string message = $"L'absence du personnel {personnel.Nom} {personnel.Prenom} " +
                             $"datant du {datedebut:dd/MM/yyyy} au {datefin:dd/MM/yyyy} a été {action}.";
            MessageBox.Show(message, "Information");
        }

    }
}