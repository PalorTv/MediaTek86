using MediaTek86.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                Dictionary<string, object> parameters = new Dictionary<string, object>         
                {
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
                // Enlever l'heure pour éviter les doublons sur le même jour
                DateTime dateDebutTronquee = absence.DateDebut.Date;
                DateTime dateFinTronquee = absence.DateFin.Date;

                string req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) ";
                req += "VALUES (@idpersonnel, @datedebut, @datefin, @idmotif);";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", dateDebutTronquee },
                    { "@datefin", dateFinTronquee },
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
                // Tronquer les heures ici pour ne garder que la date
                DateTime dateDebutTronquee = absence.DateDebut.Date;
                DateTime dateFinTronquee = absence.DateFin.Date;
                DateTime ancienneDateDebutTronquee = absence.AncienneDateDebut.Date;

                string req = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "WHERE idpersonnel = @idpersonnel AND datedebut = @anciennedatedebut;";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@datedebut", dateDebutTronquee);
                parameters.Add("@datefin", dateFinTronquee);
                parameters.Add("@idmotif", absence.Motif.IdMotif);
                parameters.Add("@idpersonnel", absence.IdPersonnel);
                parameters.Add("@anciennedatedebut", ancienneDateDebutTronquee);

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

        /// <summary>
        /// Vérifie si une absence existe déjà pour ce personnel dans la période donnée
        /// </summary>
        /// <param name="idPersonnel">ID du personnel</param>
        /// <param name="datedebut">Date de début de la période</param>
        /// <param name="datefin">Date de fin de la période</param>
        /// <returns>True si chevauchement, False sinon</returns>
        public bool AbsenceExisteDejaPourAjout(int idPersonnel, DateTime datedebut, DateTime datefin)
        {
            if (access.Manager != null)
            {
                string req = "SELECT COUNT(*) FROM absence " +
                             "WHERE idpersonnel = @idpersonnel " +
                             "AND (" +
                             "DATE(datedebut) BETWEEN DATE(@dateDebut) AND DATE(@dateFin) OR " +
                             "DATE(datefin) BETWEEN DATE(@dateDebut) AND DATE(@dateFin) OR " +
                             "DATE(@dateDebut) BETWEEN DATE(datedebut) AND DATE(datefin) OR " +
                             "DATE(@dateFin) BETWEEN DATE(datedebut) AND DATE(datefin)" +
                             ");";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", idPersonnel },
                    { "@dateDebut", datedebut.Date },
                    { "@dateFin", datefin.Date }
                };

                object result = access.Manager.ReqScalar(req, parameters);
                int count = Convert.ToInt32(result);
                return count > 0;
            }
            return false;
        }

        /// <summary>
        /// Récupère et retourne les absences d'un personnel précis
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(int idPersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "SELECT a.idpersonnel, a.datedebut, a.datefin, m.idmotif, m.libelle " +
                             "FROM absence a JOIN motif m ON a.idmotif = m.idmotif " +
                             "WHERE a.idpersonnel = @idpersonnel " +
                             "ORDER BY a.datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            { "@idpersonnel", idPersonnel }
        };
                try
                {
                    List<object[]> records = access.Manager.ReqSelect(req, parameters);
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
        /// Vérifie si une absence existe déjà pour ce personnel dans la période donnée
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel</param>
        /// <param name="nouvelleDateDebut">Nouvelle date de début</param>
        /// <param name="nouvelleDateFin">Nouvelle date de fin</param>
        /// <param name="ancienneDateDebut">Ancienne date de début de l’absence modifiée</param>
        /// <param name="ancienneDateFin">Ancienne date de fin de l'absence modifiée</param>
        /// <returns>true si chevauchement, false sinon</returns>
        public bool AbsenceExisteDejaPourModif(int idPersonnel, DateTime nouvelleDateDebut, DateTime nouvelleDateFin, DateTime ancienneDateDebut, DateTime ancienneDateFin)
        {
            if (access.Manager != null)
            {
                string req = "SELECT COUNT(*) FROM absence " +
                             "WHERE idpersonnel = @idpersonnel " +
                             "AND NOT (DATE(datedebut) = DATE(@ancienneDateDebut) AND DATE(datefin) = DATE(@ancienneDateFin)) " +
                             "AND (" +
                             "DATE(datedebut) BETWEEN DATE(@nouvelleDateDebut) AND DATE(@nouvelleDateFin) OR " +
                             "DATE(datefin) BETWEEN DATE(@nouvelleDateDebut) AND DATE(@nouvelleDateFin) OR " +
                             "DATE(@nouvelleDateDebut) BETWEEN DATE(datedebut) AND DATE(datefin) OR " +
                             "DATE(@nouvelleDateFin) BETWEEN DATE(datedebut) AND DATE(datefin)" +
                             ");";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", idPersonnel },
                    { "@nouvelleDateDebut", nouvelleDateDebut.Date },
                    { "@nouvelleDateFin", nouvelleDateFin.Date },
                    { "@ancienneDateDebut", ancienneDateDebut.Date },
                    { "@ancienneDateFin", ancienneDateFin.Date }
                };

                object result = access.Manager.ReqScalar(req, parameters);
                int count = Convert.ToInt32(result);
                return count > 0;
            }
            return false;
        }
    }
}