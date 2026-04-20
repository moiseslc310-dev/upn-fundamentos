using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de habitaciónes: ");
            int habitaciones = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de baño: ");
            int banos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de patios: ");
            int patios = int.Parse(Console.ReadLine());

            double total = (habitaciones * 30) + (banos * 10) + (patios * 15);
            Console.WriteLine("_____________________");
            Console.WriteLine($"El pago total por alquiler es: { total:C2}");



        }
    }
}
