using MediaTek86.model;
using MediaTek86.outils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant le responsable
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Contrôle de l'authentification du responsable
        /// </summary>
        /// <param name="responsable">Objet Responsable contenant login et mot de passe</param>
        /// <returns>true si l'utilisateur est reconnu, false sinon</returns>
        public bool ControleAuthentification(Responsable responsable)
        {
            string req = "SELECT pwd FROM responsable WHERE login = @login";
            Dictionary<string, object> param = new Dictionary<string, object>
             {
                 { "@login", responsable.Login }
             };

            try
            {
                List<Object[]> result = access.Manager.ReqSelect(req, param);
                if (result.Count == 1)
                {
                    string PwdHash = result[0][0].ToString();
                    string PwdUserHash = HashTools.ComputeSha256Hash(responsable.Pwd);

                    return PwdHash == PwdUserHash;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur d'authentification : " + e.Message, "Erreur");
            }

            return false;
        }
    }
}