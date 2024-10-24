using System.Security.Cryptography;
using System.Text;

namespace Util.Encrypt
{
    public class PasswordHasher
    {
        private readonly byte[] _salt = Encoding.UTF8.GetBytes("umSaltUnicoAqui123"); // Salt fixo

        public string HashPassword(string password)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, _salt, 10000))
            {
                return Convert.ToBase64String(pbkdf2.GetBytes(32)); // Hash de 256 bits (32 bytes)
            }
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            // Re-hash a senha fornecida e compara com o hash armazenado
            string hashedInputPassword = HashPassword(password);
            return hashedInputPassword == hashedPassword;
        }
    }
}
