namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations du motif
    /// </summary>
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

        /// <summary>
        /// Valorisateur
        /// </summary>
        public int IdMotif { get; }

        /// <summary>
        /// Valorisateur
        /// </summary>
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
