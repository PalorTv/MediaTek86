using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Motif
    {
        /// <summary>
        /// Valorise les
        /// propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }

        public int IdMotif { get; }
        public string Libelle { get; set; }

        /// <summary>
        /// Définit l'information à afficher (juste le libelle)
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return Libelle;
        }

    }
}
