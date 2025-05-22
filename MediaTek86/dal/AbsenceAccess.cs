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
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences()
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "SELECT a.idpersonnel, a.datedebut, a.datefin, m.idmotif, m.libelle " +
                             "FROM absence a JOIN motif m ON a.idmotif = m.idmotif " +
                             "ORDER BY a.datedebut;";
                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (object[] record in records)
                        {
                            int idpersonnel = Convert.ToInt32(record[0]);
                            DateTime datedebut = Convert.ToDateTime(record[1]);
                            DateTime datefin = Convert.ToDateTime(record[2]);
                            int idmotif = Convert.ToInt32(record[3]);
                            string libelleMotif = record[4].ToString();

                            Motif motif = new Motif(idmotif, libelleMotif);
                            Absence absence = new Absence(idpersonnel, datedebut, datefin, motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur lors du chargement : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lesAbsences;
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut AND datefin = @datefin;";
                Dictionary<string, object> parameters = new Dictionary<string, object>         {
                { "@idpersonnel", absence.IdPersonnel },
                { "@datedebut", absence.DateDebut },
                { "@datefin", absence.DateFin }
            };
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
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) ";
                req += "VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.Motif.IdMotif }
                 };

                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur lors de l'ajout : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "WHERE idpersonnel = @idpersonnel AND datedebut = @anciennedatedebut;";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@datedebut", absence.DateDebut);
                parameters.Add("@datefin", absence.DateFin);
                parameters.Add("@idmotif", absence.Motif.IdMotif);
                parameters.Add("@idpersonnel", absence.IdPersonnel);
                parameters.Add("@anciennedatedebut", absence.AncienneDateDebut);

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