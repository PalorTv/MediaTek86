namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations du personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel,
            string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public int Idpersonnel { get; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public Service Service { get; set; }
    }
}
