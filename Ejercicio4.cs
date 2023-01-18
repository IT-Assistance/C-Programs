using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio4
    {
        // Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.
        public static void Inicio()
        {
            Console.Write("Ejercicio #4 \n ");
            Console.Write("Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par. \n ");
            Console.Write("Ingrese un numero de dos digitos: ");
            string numero1 = Console.ReadLine();

            if (!EsNumeroValido(numero1))
            {
                Inicio();
                return;
            }

            Console.Write("Ingrese otro numero de dos digitos: ");
            string numero2 = Console.ReadLine();


            if (!EsNumeroValido(numero2))
            {
                Inicio();
                return;
            }


            int suma = int.Parse(numero1) + int.Parse(numero2);
            Console.WriteLine($"Suma: {suma}");
            if (suma % 2 == 0)
            {
                Console.WriteLine($"La suma de los numeros es un numero par");
            }
            else
            {
                Console.WriteLine($"La suma de los numeros NO es un numero par");

            }
            Console.ReadKey();
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
