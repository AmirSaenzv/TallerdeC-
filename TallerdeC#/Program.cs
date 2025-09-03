using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerdeC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir mensaje
            Console.WriteLine("Bienvenido a Csharp");

            // --Definir variable--
            int a, b, producto;

            // --Entada de datos--
            Console.WriteLine("Ingrese el primer numero: ");
            //Guardar valor de la consola
            a = int.Parse(Console.ReadLine());
            //a = int.TryParse(Console.ReadLine()); //Boolean True or False

            // --Entada de datos--
            Console.WriteLine("Ingrese el segundo numero: ");
            //Guardar valor de la consola
            b= Convert.ToInt32(Console.ReadLine());
            //b = int.TryParse(Console.ReadLine()); //Boolean True or False

            // --Proceso--
            producto = a * b;

            // --Salida de datos--
            Console.WriteLine("El producto es: " + (producto+2));
            Console.WriteLine($"El producto es: {producto}"); //Interpolacion de cadenas

            Console.WriteLine();
            Console.WriteLine("Alagoritmo area del triangulo");

            Ejercicio1 eje1 = new Ejercicio1();
            eje1.areatriangulo();

            //Detener pantalla para ver mensaje
            Console.ReadKey();

        }
    }
}
