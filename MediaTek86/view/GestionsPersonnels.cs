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
    /// Fenêtre d'affichage du personnel
    /// </summary>
    public partial class GestionsPersonnels : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;

        private bool colonnesCachees = false;

        /// <summary>
        /// Objet pour gérer la liste du personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste du personnels
        /// </summary>
        private BindingSource bdgServices = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public GestionsPersonnels()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediaTek86Controller();
            RemplirListePersonnels();
            dgvLePersonnels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLePersonnels.MultiSelect = false;
            dgvLePersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLePersonnels.Width = this.ClientSize.Width - 40;
            dgvLePersonnels.Left = 20;
            grbLePersonnels.Text = "";
        }

        /// <summary>
        /// Centre le DataGridView
        /// </summary>
        private void CentrerDgvPersonnels()
        {
            dgvLePersonnels.Left = (this.ClientSize.Width - dgvLePersonnels.Width) / 2; dgvLePersonnels.Left = (this.ClientSize.Width - dgvLePersonnels.Width) / 2;
        }

        /// <summary>
        /// Affiche le personnels et gère l'affichage
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetLePersonnels();
            bdgPersonnels.DataSource = null;
            bdgPersonnels.DataSource = lesPersonnels;
            dgvLePersonnels.DataSource = bdgPersonnels;

            // Cache la colonne idpersonnel à chaque remplissage
            if (dgvLePersonnels.Columns["idpersonnel"] != null)
            {
                dgvLePersonnels.Columns["idpersonnel"].Visible = false;
            }

            dgvLePersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CentrerDgvPersonnels();
        }

        private void btnSupprPerso_Click(object sender, EventArgs e)
        {
            if (dgvLePersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)dgvLePersonnels.SelectedRows[0].DataBoundItem;
                ConfirmSupprPersonnel confirmSupprPersonnel = new ConfirmSupprPersonnel();
                var result = confirmSupprPersonnel.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Le personnel" + " " + personnel.Nom + " " + personnel.Prenom + " " + "a été supprimé.");
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnels();
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

        private void btnAjoutPerso_Click(object sender, EventArgs e)
        {
            // Crée une instance du formulaire AjoutPersonnel
            AjoutPersonnel ajoutPersonnel = new AjoutPersonnel();

            // Affiche le formulaire 
            var result = ajoutPersonnel.ShowDialog();

            // Si l'utilisateur a cliqué sur "Enregistrer"
            if (result == DialogResult.OK)
            {
                // Récupéres les valeurs après la fermeture du formulaire
                string nom = ajoutPersonnel.txtAjoutNom.Text;
                string prenom = ajoutPersonnel.txtAjoutPrenom.Text;
                string tel = ajoutPersonnel.txtAjoutTel.Text;
                string mail = ajoutPersonnel.txtAjoutMail.Text;
                Service service = (Service)ajoutPersonnel.cboAjoutService.SelectedItem;

                // Vérifie que tous les champs sont remplis
                if (!string.IsNullOrEmpty(nom) && !string.IsNullOrEmpty(prenom) && !string.IsNullOrEmpty(tel) && !string.IsNullOrEmpty(mail) && service != null)
                {
                    MessageBox.Show("Le personnel " + nom + " " + prenom + " a été correctement ajouté.");

                    // Crée un objet Absence et l'ajoute
                    Personnel personnel = new Personnel(0, nom, prenom, tel, mail, service);
                    controller.AddPersonnel(personnel);  // Ajout à la BDD

                    // Met à jour la liste du personnels dans l'interface
                    RemplirListePersonnels();
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            }
        }

        private void btnModifPerso_Click(object sender, EventArgs e)
        {
            if (dgvLePersonnels.Rows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];

                // Passer l'objet personnel et le controller au formulaire
                ModifPersonnel modifPersonnel = new ModifPersonnel(personnel, controller);

                var result = modifPersonnel.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Récupérer les valeurs modifiées
                    string nom = modifPersonnel.txtModifNom.Text;
                    string prenom = modifPersonnel.txtModifPrenom.Text;
                    string tel = modifPersonnel.txtModifTel.Text;
                    string mail = modifPersonnel.txtModifMail.Text;
                    Service service = (Service)modifPersonnel.cboModifService.SelectedItem;

                    // Mettre à jour l'objet personnel existant
                    personnel.Nom = nom;
                    personnel.Prenom = prenom;
                    personnel.Tel = tel;
                    personnel.Mail = mail;
                    personnel.Service = service;

                    // Mise à jour en base de données
                    controller.UpdatePersonnel(personnel);

                    MessageBox.Show("Le personnel " + nom + " " + prenom + " a été correctement modifié.");

                    // Actualiser la liste affichée
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnAbsencesPerso_Click(object sender, EventArgs e)
        {
            if (dgvLePersonnels.SelectedRows.Count > 0)
            {
                // Récupérer le personnel sélectionné
                Personnel personnel = (Personnel)dgvLePersonnels.SelectedRows[0].DataBoundItem;

                // Créer l'instance du formulaire en passant le personnel
                GestionsAbsences gestionsAbsences = new GestionsAbsences(personnel);

                // Affiche le formulaire
                gestionsAbsences.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Information");
            }
        }
    }
}
