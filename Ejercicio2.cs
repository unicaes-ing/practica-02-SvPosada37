using System;
using System.Collections.Generic;
using System.Text;

namespace Guia2
{
    class Ejercicio2
    {
        public static void ejer2()
        {
            Console.WriteLine("Bienvenido a BoatTarsh");
            Console.WriteLine("\nDigite el nombre del producto que desea llevar: ");
            string producto = Console.ReadLine();
            Console.WriteLine("\nCuantos {0} desea comprar?", producto   );
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nCuanto cuesta su producto?");
            int coste = Convert.ToInt32(Console.ReadLine());
            double IVA;
            double subtotal;
            double total;
            subtotal = cantidad * coste;
            IVA = subtotal * 0.13;
            total = (subtotal*0.13)+subtotal;
            if (cantidad >= 2)
            {
                Console.WriteLine("\nEl subtotal a pagar por sus productos es de: {0:c}", subtotal);
            }
            Console.WriteLine("\nSe le agrego {0:c} debido al 13% de IVA.", IVA);
            if (cantidad >= 2)
            {
                Console.WriteLine("\nEl total a pagar por sus {0} es de: {1:c}",producto, total);
            }
            else
            {
              Console.WriteLine("\nEl total a pagar por su {0} es de: {1:c}",producto , total);
            }
            Console.ReadKey();
        }
    }
}
