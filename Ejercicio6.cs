using System;
using System.Collections.Generic;
using System.Text;

namespace Guia2
{
    class Ejercicio6
    {
        public static void ejer6()
        {
            DateTime fecha = DateTime.Now;
            DateTime hora = DateTime.Now;
            Console.WriteLine("Hoy es {0} {1} de {2} del {3} y son las {4}", fecha.ToString("dddd"), fecha.Day, fecha.ToString("MMMM"), fecha.Year, hora.ToString("hh:mm") );
            Console.ReadKey();
        }
    }
}
