using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese KWH consumido: ");
            double kwh =double.Parse(Console.ReadLine());

            double subtotal = 5 + 0.55 * kwh;
            double igv = subtotal * 0.18;
            double total = subtotal + igv;
            Console.WriteLine("__________________________");
            Console.WriteLine($"El subtotal es: {subtotal:C2}");
            Console.WriteLine($"El IGV es: {igv:C2}");
            Console.WriteLine($"El Total es: {total:C2}");


        }
    }
}
