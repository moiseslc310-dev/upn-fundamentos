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
            Console.Write("Ingrese el monto de la compra (S/): ");
            double monto = double.Parse(Console.ReadLine());

            double descuento = 0;
            if (monto >=100)
            {
                descuento = monto * 0.10;

            }
            double total = monto - descuento;
            Console.WriteLine($"Descuento aplicado: {descuento:C2}");
            Console.WriteLine($"Total a pagar: {total:C2}");
            Console.ReadKey();
        }
    }
}
