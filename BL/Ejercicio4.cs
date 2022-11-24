using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Ejercicio4
    {
        public static bool NumeroPotencia(double numeroOriginal)
        {

            string str = numeroOriginal.ToString();
            int exponente = str.Length;
            bool resultado = false;

            if (numeroOriginal >= 0)
            {
                double sumaPotencias = 0;
                double numeroActual = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if ((int)str[i] >= 48 && (int)str[i] <= 57)
                    {
                        numeroActual = Math.Pow((int.Parse(str[i].ToString())), exponente);
                        sumaPotencias += numeroActual;
                    }
                    else
                    {
                        Console.WriteLine("Solo se permiten numeros");
                    }
                }

                resultado = numeroOriginal == sumaPotencias ? true : false;
            }
            else
            {
                Console.WriteLine("Solo se permiten numeros positivos");
            }

            return resultado;

        }

        public static void EjecutarEjercicio4()
        {
            Console.WriteLine("Ingrese un numero");
            string str = Console.ReadLine();
            int exponente = str.Length;
            double numerooriginal = double.Parse(str);

            Console.WriteLine("\nEs igual a las potencias de sus digitos? : " + NumeroPotencia(numerooriginal)+"\n");

        }

    }
}
