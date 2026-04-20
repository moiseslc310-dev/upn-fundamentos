using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double dx = x2 - x1;
            double dy = y2 - y1;

            double distancia = Math.Sqrt(Math.Pow(dx,2) + Math.Pow(dy,2));
            Console.WriteLine();
            Console.WriteLine($"Distancia entre los puntos: {distancia:F2}");

        }
    }
}
