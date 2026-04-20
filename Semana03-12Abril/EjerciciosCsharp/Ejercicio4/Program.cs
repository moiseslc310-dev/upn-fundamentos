using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());

            double area = Math.PI*Math.Pow(radio, 2);
            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine("____________");
            Console.WriteLine($"Area: {area:F4}");
            Console.WriteLine($"Perimetro: {perimetro:F4}");

        }
    }
}
