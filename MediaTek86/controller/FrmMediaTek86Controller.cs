using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.controller
{
     /// <summary>
     /// Contrôleur de FrmMediaTek86
     /// </summary>
     public class FrmMediaTek86Controller
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// objet d'accès aux opérations possible sur Motif
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmMediaTek86Controller()
        {
            personnelAccess = new PersonnelAccess();
            responsableAccess = new ResponsableAccess();
            serviceAccess = new ServiceAccess();
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnels
        /// </summary>
        /// <returns>liste du personnels</returns>
        public List<Personnel> GetLePersonnels()
        {
            return personnelAccess.GetLePersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des Services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne les infos des Motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }


        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des absences
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences()
        {
            return absenceAccess.GetLesAbsences();
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }


        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }

        /// <summary>
        /// Vérifie si L'absence existe déjà lors de l'ajout
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        public bool AbsenceExisteDejaPourAjout(int idPersonnel, DateTime debut, DateTime fin)
        {
            return absenceAccess.AbsenceExisteDejaPourAjout(idPersonnel, debut, fin);
        }

        /// <summary>
        /// Récupère et retourne les absences DU personnel
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <returns></returns>
        public List<Absence> GetLesAbsences(int idPersonnel)
        {
            return absenceAccess.GetLesAbsences(idPersonnel);
        }

        /// <summary>
        /// Vérifie si l'absence existe déjà lors de la modification
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="nouvelleDateDebut"></param>
        /// <param name="nouvelleDateFin"></param>
        /// <param name="ancienneDateDebut"></param>
        /// <param name="ancienneDateFin"></param>
        /// <returns></returns>
        public bool AbsenceExisteDejaPourModif(int idPersonnel, DateTime nouvelleDateDebut, DateTime nouvelleDateFin, DateTime ancienneDateDebut, DateTime ancienneDateFin)
        {
            return absenceAccess.AbsenceExisteDejaPourModif(idPersonnel, nouvelleDateDebut, nouvelleDateFin, ancienneDateDebut, ancienneDateFin);
        }
    }
}