using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Ejercicio2
    {
        public static double LitrosTomados(double litros)
        {
            const double litroHora = 0.5;
            double litrosTomados = Math.Floor(litros * litroHora);
            return litrosTomados;
        }
        public static void EjecutarEjercicio2()
        {
            Console.Write("\nIngrese tiempo en horas: ");
            double litros = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nUsted bebe: {LitrosTomados(litros)}L cada 0.5L/h \n");

        }

    }
}
