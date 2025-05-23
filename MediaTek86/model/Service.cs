namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations du service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public int Idservice { get; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
