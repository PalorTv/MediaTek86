using MediaTek86.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant le personnels
    /// </summary>
    public class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Récupère et retourne le personnels
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLePersonnels()
        {
            List<Personnel> lePersonnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "SELECT p.idpersonnel AS idpersonnel, p.nom AS nom, p.prenom AS prenom, p.tel AS tel, p.mail AS mail, p.idservice AS idservice, s.nom AS service ";
                req += "FROM personnel p JOIN service s ON (p.idservice = s.idservice)";
                req += "ORDER BY nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);
                            lePersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lePersonnels;
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object> { { "@idpersonnel", personnel.Idpersonnel } };
                try
                {
                    int rowsDeleted = access.Manager.ReqUpdateWithRowsAffected(req, parameters);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }
        }


        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice)";
                req += "values (@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur lors de la mise à jour : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
