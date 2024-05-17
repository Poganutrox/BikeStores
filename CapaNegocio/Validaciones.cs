using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Validaciones
    {
        public static bool ValidarFormatoEmail(string email)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regex.IsMatch(email);
        }
        public static bool ValidarFormatoTelefono(string telefono)
        {
            Regex regex = new Regex(@"^(6|7|8|9)\d{8}$");

            if (regex.IsMatch(telefono))
            {
                return true;
            }

            return false;
        }

        //Convierte la contraseña introducida en su código hash correspondiente 
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var hashPassword = sha256.ComputeHash(passwordBytes);
                return Convert.ToHexString(hashPassword);
            }
        }
    }
}
