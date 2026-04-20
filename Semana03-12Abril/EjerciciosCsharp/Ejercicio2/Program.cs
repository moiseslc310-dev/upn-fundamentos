using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Precio unitario S/. ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());

            double subtotal = precio * cantidad;
            double igv = subtotal * 0.18;
            double totalFinal = subtotal + igv;
            Console.WriteLine("___________________________");
            Console.WriteLine();
            Console.WriteLine("Subtotal sin IGV: S/. " + subtotal);
            Console.WriteLine($"IGV 18%: S/.{igv:F2}");
            Console.WriteLine($"Total a pagar: S/.{totalFinal:F2}");

        }
    }
}
