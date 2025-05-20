using Org.BouncyCastle.Crypto.Digests;
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
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, string dateDebut, string dateFin, Motif motif)
        {
            this.IdPersonnel = idpersonnel;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.Motif = motif;
        }

        public int IdPersonnel { get; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public Motif Motif { get; set; }

    }
}
