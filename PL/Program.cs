// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!\n");
try
{
    bool continuar = true;
    char opcion;
    bool val;

    while (continuar)
    {

        Console.WriteLine("\n\n-- ¿Que Ejercicio desea ejecutar? --");
        Console.WriteLine("[ A ] Ejercicio 1 (cadena binaria)");
        Console.WriteLine("[ B ] Ejercicio 2 (cantidad de litros tomados)");
        Console.WriteLine("[ C ] Ejercicio 3 (sumatoria de array de numeros)");
        Console.WriteLine("[ D ] Ejercicio 4 (suma de potencia de numeros)");
        Console.WriteLine("[ Q ] Salir");
        Console.Write("\n Seleccione una opcion: ");
        val = Char.TryParse(Console.ReadLine().ToLower(), out opcion);

        if (val)
        {
            Console.WriteLine();
            switch (opcion)
            {
                case 'a':
                    BL.Ejercicio1.EjecutarEjercicio1();
                    break;
                case 'b':
                    BL.Ejercicio2.EjecutarEjercicio2();
                    break;
                case 'c':
                    BL.Ejercicio3.EjecutarEjercicio3();
                    break;
                case 'd':
                    BL.Ejercicio4.EjecutarEjercicio4();
                    break;
                case 'q':
                    Console.WriteLine("Programa finalizado ...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Ingrese una opción valida...");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ingrese una letra de laas opciones");
        }
    }
    
    
    


}
catch (Exception ex)
{
	Console.WriteLine("Algo salio mal: "+ex.Message);
}

Console.ReadKey();
