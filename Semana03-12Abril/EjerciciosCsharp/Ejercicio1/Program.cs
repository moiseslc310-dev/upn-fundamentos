using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.Write("Ingrese la nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            int nota3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 4: ");
            int nota4 = int.Parse(Console.ReadLine());

            //Proceso
            int suma = nota1 + nota2 + nota3 + nota4;
            double promedio = suma / 4.0;

            //Salida
            Console.WriteLine("_____________________");
            Console.WriteLine();
            Console.WriteLine("Suma de notas: " + suma);
            Console.WriteLine($"Promedio final: {promedio}");

        }
    }
}
