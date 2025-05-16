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
        /// <param name="iddeveloppeur"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public Absence(int iddeveloppeur, string dateDebut, string dateFin, Motif motif)
        {
            this.Iddeveloppeur = iddeveloppeur;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.motif = motif;
        }

        public int Iddeveloppeur { get; }
        public string dateDebut { get; set; }
        public string dateFin { get; set; }
        public Motif motif { get; set; }

    }
}
