using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaProg1
{
    public static class Ejercicio10
    {
        //  Leer dos números enteros y si la diferencia entre los dos es menor o igual a 10
        //  entonces mostrar en pantalla todos los enteros comprendidos entre el menor y el mayor de los números leídos.


        public static void Inicio()
        {
            Console.Write("Ejercicio #10 \n ");
            Console.Write("Ingrese un numero entero: ");
            string numero1 = Console.ReadLine();

            if (!EsNumeroValido(numero1))
            {
                Inicio();
                return;
            }

            Console.Write("Ingrese otro numero entero: ");
            string numero2 = Console.ReadLine();


            if (!EsNumeroValido(numero2))
            {
                Inicio();
                return;
            }


            int diferencia = int.Parse(numero1) - int.Parse(numero2);
            Console.WriteLine($"Diferencia: {diferencia}");
            if (diferencia <= 10)
            {
                int menor = int.Parse(numero1);
                int mayor = int.Parse(numero2);
                if (int.Parse(numero1) > int.Parse(numero2))
                {
                    menor = int.Parse(numero2);
                    mayor = int.Parse(numero1);
                }

                for (int i = menor+1; i < mayor; i++)
                {
                    Console.WriteLine(i);

                }
            }

            Console.ReadKey();
        }

        static bool EsNumeroValido(string numero)
        {

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
