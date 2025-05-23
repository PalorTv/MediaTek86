namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations d'authentification
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public string Login { get; }

        /// <summary>
        /// Valorisateur
        /// </summary>
        public string Pwd { get; }
    }
}
