using System;

namespace Guia2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" ********************Ejercicio 1********************");
            Console.WriteLine("\nPorfavor, digite su nombre a continuacion: ");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("\nSyntax error.\nAlgo ocurrio mal con el codigo. ");
            

            nombre = nombre.Replace("a", "#");
            nombre = nombre.Replace("e", "%");
            nombre = nombre.Replace("i", "$");
            nombre = nombre.Replace("o", "?");
            nombre = nombre.Replace("u", "*");
            nombre = nombre.Replace("A", "#");
            nombre = nombre.Replace("E", "%");
            nombre = nombre.Replace("I", "$");
            nombre = nombre.Replace("O", "?");
            nombre = nombre.Replace("U", "*");

            Console.WriteLine("\nSu nombre es: {0} ", nombre);
            Console.ReadKey();

            Console.WriteLine("\n ********************Ejercicio 2********************");
            Console.WriteLine();
            Ejercicio2.ejer2();
            Console.WriteLine("\n ********************Ejercicio 3********************");
            Console.WriteLine();
            Ejercicio3.ejer3();
            Console.WriteLine("\n ********************Ejercicio 4********************");
            Console.WriteLine();
            Ejercicio4.ejer4();
            Console.WriteLine("\n ********************Ejercicio 5********************");
            Console.WriteLine();
            Ejercicio5.ejer5();
            Console.WriteLine("\n ********************Ejercicio 6********************");
            Console.WriteLine();
            Ejercicio6.ejer6();
        }
    } 
    
}
