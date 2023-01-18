using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio7
    {
        //  Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.
        public static void Inicio()
        {
            Console.Write("Ejercicio #7 \n ");
            Console.Write("Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables. \n ");

            string variable1;
            string variable2;

            Console.Write("Ingrese el primer numero: ");
            variable1 = Console.ReadLine();

            Console.Write("Ingrese el segundo numero: ");
            variable2 = Console.ReadLine();

            if (int.Parse(variable1) > int.Parse(variable2))
            {
                Console.Write("Ingrese el tercer numero: ");
                variable2 = Console.ReadLine();
                if (int.Parse(variable1) > int.Parse(variable2))
                {
                    Console.Write($"El mayor es: {variable1}");
                }
                else
                {
                    Console.Write($"El mayor es: {variable2}");
                }
            }
            else
            {
                Console.Write("Ingrese el tercer numero: ");
                variable1 = Console.ReadLine();
                if (int.Parse(variable2) > int.Parse(variable1))
                {
                    Console.Write($"El mayor es: {variable2}");
                }
                else
                {
                    Console.Write($"El mayor es: {variable1}");
                }
            }

            Console.ReadKey();
        }

    }
}
