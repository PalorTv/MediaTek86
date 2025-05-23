using MediaTek86.controller;
using MediaTek86.model;
using MediaTek86.view;
using System;
using System.Windows.Forms;

namespace MediaTek86
{
    /// <summary>
    /// Fenêtre d'authentification (seuls le responsable peut accéder à l'application)
    /// </summary>
    public partial class Connexion : Form
    {

        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmMediaTek86Controller controller;

        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public Connexion()
        {
            InitializeComponent();
            Init();
            txtPwd.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmMediaTek86Controller();
        }
        
        /// <summary>
        /// Clique sur le bouton de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ControleAuthentification(responsable))
                {
                    this.Hide();
                    GestionsPersonnels gestionspersonnels = new GestionsPersonnels();
                    gestionspersonnels.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas responsable", "Alerte");
                }
            }
        }
    }
}
