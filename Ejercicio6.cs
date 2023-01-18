using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio6
    {
        // Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.
        public static void Inicio()
        {
            Console.Write("Ejercicio #6 \n ");
            Console.Write("Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros. \n ");
            Console.Write("Ingrese un numero de tres digitos: ");
            string numero = Console.ReadLine();

            if (!EsNumeroValido(numero))
            {
                Inicio();
                return;
            }

            char[] digitos = numero.ToCharArray();
            int mayor = 0;

            for (int i = 0; i < digitos.Length; i++)
            {
                if (digitos[i] > digitos[mayor])
                {
                    mayor = i;
                }
            }

            Console.Write($"El digito mayor se encuentra en la posicion: {mayor}");
            Console.ReadKey();
        }

        static bool EsNumeroValido(string numero)
        {
            if (numero.Length != 3)
            {
                Console.WriteLine("Este numero NO contiene tres digitos");
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
