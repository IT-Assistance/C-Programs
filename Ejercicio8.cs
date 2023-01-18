using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio8
    {
        //   Leer un número entero de cinco dígitos y determinar si es un número Capicúa. 

        public static void Inicio()
        {
            Console.Write("Ejercicio #8 \n ");
            Console.Write("Leer un número entero de cinco dígitos y determinar si es un número Capicúa. \n ");

            Console.Write("Ingrese un numero de cinco digitos: ");
            string numero = Console.ReadLine();

            if (!EsNumeroValido(numero))
            {
                Inicio();
                return;
            }

            char[] digitos = numero.ToCharArray();

            if (digitos[0] == digitos[4] && digitos[1] == digitos[3])
            {
                Console.Write($"Este es un número Capicúa");
            }else
            {
                Console.Write($"Este NO es un número Capicúa");
            }

            Console.ReadKey();
        }

        static bool EsNumeroValido(string numero)
        {
            if (numero.Length != 5)
            {
                Console.WriteLine("Este numero NO contiene cinco digitos");
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
