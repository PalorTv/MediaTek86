using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
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

        public int IdPersonnel { get; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public DateTime AncienneDateDebut { get; set; }
        public Motif Motif { get; set; }

    }
}
