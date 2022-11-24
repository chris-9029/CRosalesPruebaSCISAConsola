using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Ejercicio1
    {
        public static string CadenaBinaria(string str)
        {
            string strResult = "";
            int numeroActual = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] >= 48 && (int)str[i] <= 57)
                {
                    numeroActual = int.Parse(str[i].ToString());
                    if (numeroActual < 5)
                        strResult += "0";
                    else if (numeroActual >= 5)
                        strResult += "1";
                }
            }

            return strResult;
        }

        public static void EjecutarEjercicio1()
        {
            Console.Write("\nIngrese una cadena numerica: ");
            string cadenaIngresada = Console.ReadLine();
            string Ejercicio1Resultado = CadenaBinaria(cadenaIngresada);
            Console.WriteLine("\nResultado: " + Ejercicio1Resultado+"\n");
        }

    }
}
