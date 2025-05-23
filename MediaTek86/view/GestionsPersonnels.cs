using System;
using MediaTek86.model;
using MediaTek86.controller;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre d'affichage du personnel
    /// </summary>
    public partial class GestionsPersonnels : Form
    {
        /// <summary>
        /// Objet pour gérer la liste du personnels
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();

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

        /// <summary>
        /// Clique sur le bouton de suppression du personnel sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprPerso_Click(object sender, EventArgs e)
        {
            if (dgvLePersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)dgvLePersonnels.SelectedRows[0].DataBoundItem;
                ConfirmSupprPersonnel confirmSupprPersonnel = new ConfirmSupprPersonnel();
                var result = confirmSupprPersonnel.ShowDialog();

                if (result == DialogResult.OK)
                {
                    controller.DelPersonnel(personnel);

                    AfficherMessagePersonnel("supprimé", personnel);

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

        /// <summary>
        /// Clique sur le bouton de l'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutPerso_Click(object sender, EventArgs e)
        {
            // Crée une instance du formulaire AjoutPersonnel
            AjoutPersonnel ajoutPersonnel = new AjoutPersonnel();

            // Affiche le formulaire 
            var result = ajoutPersonnel.ShowDialog();

            // Si l'utilisateur a cliqué sur "Enregistrer"
            if (result == DialogResult.OK)
            {
                // Récupères les valeurs après la fermeture du formulaire
                string nom = ajoutPersonnel.txtAjoutNom.Text;
                string prenom = ajoutPersonnel.txtAjoutPrenom.Text;
                string tel = ajoutPersonnel.txtAjoutTel.Text;
                string mail = ajoutPersonnel.txtAjoutMail.Text;
                Service service = (Service)ajoutPersonnel.cboAjoutService.SelectedItem;

                // Vérifie que tous les champs sont remplis
                if (!string.IsNullOrEmpty(nom) && !string.IsNullOrEmpty(prenom) && !string.IsNullOrEmpty(tel) && !string.IsNullOrEmpty(mail) && service != null)
                {
                    // Crée un objet Personnel et l'ajoute
                    Personnel personnel = new Personnel(0, nom, prenom, tel, mail, service);
                    controller.AddPersonnel(personnel);

                    AfficherMessagePersonnel("ajouté", personnel);

                    // Met à jour la liste du personnels dans l'interface
                    RemplirListePersonnels();
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            }
        }

        /// <summary>
        /// Clique sur le bouton de modification du personnel sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifPerso_Click(object sender, EventArgs e)
        {
            if (dgvLePersonnels.Rows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];

                // Passe l'objet personnel et le controller au formulaire
                ModifPersonnel modifPersonnel = new ModifPersonnel(personnel, controller);

                var result = modifPersonnel.ShowDialog();

                // Si l'utilisateur a cliqué sur "Enregistrer" 
                if (result == DialogResult.OK)
                {
                    // Récupères les valeurs modifiées
                    string nom = modifPersonnel.txtModifNom.Text;
                    string prenom = modifPersonnel.txtModifPrenom.Text;
                    string tel = modifPersonnel.txtModifTel.Text;
                    string mail = modifPersonnel.txtModifMail.Text;
                    Service service = (Service)modifPersonnel.cboModifService.SelectedItem;

                    // Met à jour l'objet personnel existant
                    personnel.Nom = nom;
                    personnel.Prenom = prenom;
                    personnel.Tel = tel;
                    personnel.Mail = mail;
                    personnel.Service = service;

                    // Met à jour la base de données
                    controller.UpdatePersonnel(personnel);

                    AfficherMessagePersonnel("modifié", personnel);

                    // Actualise la liste affichée
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Clique sur le bouton affichant les absences correspondant au personnel sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbsencesPerso_Click(object sender, EventArgs e)
        {
            if (dgvLePersonnels.SelectedRows.Count > 0)
            {
                // Récupère le personnel sélectionné
                Personnel personnel = (Personnel)dgvLePersonnels.SelectedRows[0].DataBoundItem;

                // Crée l'instance du formulaire en passant le personnel
                GestionsAbsences gestionsAbsences = new GestionsAbsences(personnel);

                // Affiche le formulaire
                gestionsAbsences.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Information");
            }
        }

        /// <summary>
        /// Affiche un message d'information concernant un personnel
        /// </summary>
        /// <param name="action">"ajouté", "modifié" ou "supprimé"</param>
        /// <param name="personnel">L'objet Personnel concerné</param>
        private void AfficherMessagePersonnel(string action, Personnel personnel)
        {
            string message = $"Le personnel {personnel.Nom} {personnel.Prenom} a été {action}.";
            MessageBox.Show(message, "Information");
        }

    }
}
