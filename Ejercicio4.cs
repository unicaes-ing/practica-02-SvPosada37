using System;
using System.Collections.Generic;
using System.Text;

namespace Guia2
{
    class Ejercicio4
    {
        public static void ejer4()
        {
            
            double precio;
            DateTime FechaInicio;
            DateTime FechaDevolucion;
            Console.WriteLine("Bienvenido a \"Mi auto por unos dias\" ");
            Console.WriteLine("\nEl precio de alquieler por dia es de: \n$10.00");
            Console.WriteLine("\nIngrese la fecha de inicio del alquiler:");
            FechaInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\nIngrese la fecha de devolucion del alquiler:");
            FechaDevolucion = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("\nUsted esta rentanto un auto por {0} dias", FechaDevolucion.Subtract(FechaInicio).Days);
            precio = FechaDevolucion.Subtract(FechaInicio).Days * 10;
            Console.WriteLine("\nEl precio total por el alquier es de: {0}", precio.ToString("c2"));
            Console.ReadKey();
        }
    }
}
