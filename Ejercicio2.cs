using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio2
    {
        //  Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.
        public static void Inicio()
        {
            Console.Write("Ejercicio #2 \n ");
            Console.Write("Leer un número entero de dos dígitos y determinar si es primo y además si es negativo. \n ");
            Console.Write("Ingrese un numero de dos digitos: ");
            string numero = Console.ReadLine();

            if (!EsNumeroValido(numero))
            {
                Inicio();
                return;
            }

            if (EsPrimo(int.Parse(numero)))
            {
                Console.WriteLine("Este es un numero primo");
            }else
            {
                Console.WriteLine("Este numero NO es primo");
            }

            if (int.Parse(numero) < 0)
            {
                Console.WriteLine("Este numero es negativo");
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
