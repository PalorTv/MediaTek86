using System.Security.Cryptography;
using System.Text;

namespace MediaTek86.outils 
{
    /// <summary>
    /// Outil permettant de récupérer le Hash du mot de passe pour le comparer
    /// avec le Hash du mot de passe dans la BDD
    /// </summary>
    public static class HashTools
    {
        /// <summary>
        /// Calcule le hash SHA-256 d’une chaîne de caractères (string).
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns> retourne une chaîne hexadécimale (qui représente le hash) </returns>
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}