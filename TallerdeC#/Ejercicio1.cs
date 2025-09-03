using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerdeC_
{
    public class Ejercicio1
    {
        public void areatriangulo() 
        {
            //Definir variable
            

            //solicitar datos
            Console.WriteLine("Ingrese lado a: ");
            //Guardar Datos
            var a= int.Parse(Console.ReadLine());
            //solicitar datos
            Console.WriteLine("Ingrese lado b: ");
            //Guardar Datos
            var b = int.Parse(Console.ReadLine());
            //solicitar datos
            Console.WriteLine("Ingrese lado c: ");
            //Guardar Datos
            var c = int.Parse(Console.ReadLine());

            //Proceso
           var s= (a + b + c) / 2; // s=semiperimetro
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            
            //Salida de datos
            Console.WriteLine($"Algoritmo Area Triangulo es, segun los lados {a},{b},{c} es: {area}");

            //Detener pantalla para ver mensaje
            Console.ReadKey();




        }





    }
}
