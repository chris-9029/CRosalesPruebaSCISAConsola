using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Ejercicio3
    {
        public static int Sumatoria(int[] numeros)
        {
            int sumaArr = 0;
            foreach (var item in numeros)
            {
                if (item >= 0)
                    sumaArr += item;

            }
            return sumaArr;
        }

        public static int[] CapturarArreglo()
        {

            Console.WriteLine("Ingresa cantidad de numeros a ingresar: ");

            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese numero {i + 1} de {n}:");

                numeros[i] = int.Parse(Console.ReadLine());
            }

            return numeros;

        }

        public static void EjecutarEjercicio3()
        {
            int[] ints = CapturarArreglo();
            int resultadoInt = Sumatoria(ints);
            Console.WriteLine($"\nSumatoria de Array: {resultadoInt} \n");
        }


    }

}
