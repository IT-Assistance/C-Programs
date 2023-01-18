using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio1
    {
        // Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos
        public static void Inicio()
        {
            Console.Write("Ejercicio #1 \n ");
            Console.Write("Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos \n ");
            Console.Write("Ingrese un numero de dos digitos: ");
            string numero = Console.ReadLine();

            if (!EsNumeroValido(numero))
            {
                Inicio();
                return;
            }

            char[] digitos = numero.ToCharArray();

            int suma = int.Parse(digitos[0].ToString()) + int.Parse(digitos[1].ToString());
            Console.Write($"La suma de los digitos es igual a: {suma}");
            Console.ReadKey();
        }

        static bool EsNumeroValido(string numero)
        {
            if(numero.Length != 2)
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
