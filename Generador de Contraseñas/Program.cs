using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al generador de contraseñas");
            Console.Write("¿Cuál es la longitud de la contraseña deseada? ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Desea incluir letras mayúsculas? (S/N) ");
            bool includeUpper = Console.ReadLine().ToLower().Equals("s");

            Console.Write("¿Desea incluir letras minúsculas? (S/N) ");
            bool includeLower = Console.ReadLine().ToLower().Equals("s");

            Console.Write("¿Desea incluir números? (S/N) ");
            bool includeNumbers = Console.ReadLine().ToLower().Equals("s");

            Console.Write("¿Desea incluir símbolos? (S/N) ");
            bool includeSymbols = Console.ReadLine().ToLower().Equals("s");

            string password = GeneratePassword(length, includeUpper, includeLower, includeNumbers, includeSymbols);

            Console.WriteLine("Su contraseña generada es: " + password);
            Console.ReadLine();
        }

        static string GeneratePassword(int length, bool includeUpper, bool includeLower, bool includeNumbers, bool includeSymbols)
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string numberChars = "0123456789";
            const string symbolChars = "!@#$%^&*()_+-=[]{}|;:,.<>/?";

            string chars = "";
            if (includeUpper)
            {
                chars += upperChars;
            }
            if (includeLower)
            {
                chars += lowerChars;
            }
            if (includeNumbers)
            {
                chars += numberChars;
            }
            if (includeSymbols)
            {
                chars += symbolChars;
            }

            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }
            return sb.ToString();
        }
    }
}