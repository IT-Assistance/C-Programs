using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio3
    {
        // Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.
        public static void Inicio()
        {
            Console.Write("Ejercicio #3 \n ");
            Console.Write("Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos. \n ");
            Console.Write("Ingrese un numero de dos digitos: ");
            string numero = Console.ReadLine();

            if (!EsNumeroValido(numero))
            {
                Inicio();
                return;
            }

            char[] digitos = numero.ToCharArray();

            int digito1 = int.Parse(digitos[0].ToString());
            if (EsPrimo(digito1))
            {
                Console.WriteLine($"El digito {digito1} es primo");
            }
            else
            {
                Console.WriteLine($"El digito {digito1} NO es primo");
            }

            int digito2 = int.Parse(digitos[1].ToString());
            if (EsPrimo(digito2))
            {
                Console.WriteLine($"El digito {digito2} es primo");
            }
            else
            {
                Console.WriteLine($"El digito {digito2} NO es primo");
            }

            Console.ReadKey();
        }

        public static bool EsPrimo(int n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n < 2 || n % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool EsNumeroValido(string numero)
        {
            if (numero.Length != 2)
            {
                Console.WriteLine("Este numero NO contiene dos digitos");
                return false;
            }

            int numericValue;
            bool esNumero = int.TryParse(numero, out numericValue);
            if (!esNumero)
            {
                Console.WriteLine("Este no es un numero valido");
                return false;
            }

            return true;
        }
    }
}
