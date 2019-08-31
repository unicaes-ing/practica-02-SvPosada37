using System;
using System.Collections.Generic;
using System.Text;

namespace Guia2
{
    class Ejercicio5
    {
        public static void ejer5()
        {
            
            double precio;
            DateTime InicioLlamada;
            DateTime FinalLlamada;
            Console.WriteLine("Bienvenido a \"TIGO\" ");
            Console.WriteLine("\nEl precio por cada minuto de la llamada es de: \n$0.10");
            Console.WriteLine("\nFavor ingresar su numero:");
            string numero = Console.ReadLine();
            Console.WriteLine("\nIngrese la hora de inicio de la llamada:");
            InicioLlamada = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\nIngrese la hora en la que termino la llamada:");
            FinalLlamada = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\nSu llamada duro {0} minutos", FinalLlamada.Subtract(InicioLlamada).Minutes);
            precio = FinalLlamada.Subtract(InicioLlamada).Minutes * 0.1;
            Console.WriteLine("\nEl precio total por la llamda es de: {0}", precio.ToString("c2"));
            Console.ReadKey();
        }
    }
}
