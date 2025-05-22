using System;
using MediaTek86.model;
using MediaTek86.controller;
using MediaTek86.view;
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
    /// Fenêtre d'affichage des absences
    /// </summary>
    public partial class GestionsAbsences : Form
    {
        /// <summary>
        /// Objet pour gérer la liste du personnels
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        /// <summary>
        /// 
        /// </summary>
        private Personnel personnel;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
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

            // Filtrage selon le personnel sélectionné
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

            // Formater les colonnes date pour ne pas afficher l'heure
            if (dgvLesAbsences.Columns["datedebut"] != null)
                dgvLesAbsences.Columns["datedebut"].DefaultCellStyle.Format = "yyyy-MM-dd";

            if (dgvLesAbsences.Columns["datefin"] != null)
                dgvLesAbsences.Columns["datefin"].DefaultCellStyle.Format = "yyyy-MM-dd";

            dgvLesAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CentrerDgvAbsences();
        }

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
                    MessageBox.Show("L'absence du personnel " + personnel.Nom 
                    + " " + personnel.Prenom + " " + "datant du" + " " + absence.DateDebut 
                    + " " + "au" + " " + absence.DateFin + " " + "a été supprimé.", "Information");
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

                    // Ajout à la BDD
                    controller.AddAbsence(absence);

                    // Met à jour la liste du personnels dans l'interface
                    RemplirListeAbsences();

                    MessageBox.Show("L'absence du personnel " + personnel.Nom
                    + " " + personnel.Prenom + " " + "datant du" + " " + datedebut
                    + " " + "au" + " " + datefin + " " + "a été ajouté.", "Information");
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            }
        }

        private void btnModifAbsence_Click(object sender, EventArgs e)
        {
            if (dgvLesAbsences.Rows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];

                // Passer l'objet absence et le controller au formulaire
                ModifAbsence modifAbsence = new ModifAbsence(absence, controller);

                var result = modifAbsence.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Récupérer les valeurs modifiées
                    DateTime datedebut = modifAbsence.dtpModifDebut.Value;
                    DateTime datefin = modifAbsence.dtpModifFin.Value;
                    Motif motif = (Motif)modifAbsence.cboModifMotifAbsence.SelectedItem;

                    // Stocke de l'ancienne date de début
                    absence.AncienneDateDebut = absence.DateDebut;

                    // Mettre à jour l'objet absence existant
                    absence.DateDebut = datedebut;
                    absence.DateFin = datefin;
                    absence.Motif = motif;

                    // Mise à jour en base de données
                    controller.UpdateAbsence(absence);

                    MessageBox.Show("L'absence du personnel " + personnel.Nom
                    + " " + personnel.Prenom + " " + "datant du" + " " + datedebut
                    + " " + "au" + " " + datefin + " " + "a été modifié.", "Information");

                    // Actualiser la liste affichée
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            GestionsAbsences.ActiveForm.Close();
        }
    }
}