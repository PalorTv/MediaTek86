using System;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations de l'absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les
        /// propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.IdPersonnel = idpersonnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.AncienneDateDebut = datedebut;
            this.Motif = motif;
        }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public int IdPersonnel { get; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public DateTime AncienneDateDebut { get; set; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public Motif Motif { get; set; }

    }
}
