using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio9
    {
        //  Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo.


        public static void Inicio()
        {
            Console.Write("Ejercicio #9 \n ");
            Console.Write("Leer un número entero de cuatro dígitos y determinar si el segundo dígito es igual al penúltimo. \n ");

            Console.Write("Ingrese un numero de cuatro digitos: ");
            string numero = Console.ReadLine();

            if (!EsNumeroValido(numero))
            {
                Inicio();
                return;
            }

            char[] digitos = numero.ToCharArray();

            if (digitos[1] == digitos[2])
            {
                Console.Write($"El segundo dígito es igual al penúltimo");
            }else
            {
                Console.Write($"El segundo dígito NO es igual al penúltimo");
            }

            Console.ReadKey();
        }

        static bool EsNumeroValido(string numero)
        {
            if (numero.Length != 4)
            {
                Console.WriteLine("Este numero NO contiene cuatro digitos");
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
