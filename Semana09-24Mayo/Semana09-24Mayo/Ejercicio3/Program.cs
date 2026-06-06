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
            Console.WriteLine("=== TIENDA - CÁLCULO DE DESCUENTO ===");
            Console.Write("Ingrese cantidad de productos: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio unitario: S/");
            double precio = double.Parse(Console.ReadLine());

            // Llamamos a los métodos de la clase UtilTienda
            double subtotal = UtilTienda.CalcularSubtotal(cantidad, precio);
            double descuento = UtilTienda.CalcularDescuento(subtotal);
            double total = UtilTienda.CalcularTotal(subtotal, descuento);
            Console.WriteLine("\n=== COMPROBANTE DE COMPRA ===");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Precio unitario: S/{precio:F2}");
            Console.WriteLine($"Subtotal: S/{subtotal:F2}");
            Console.WriteLine($"Descuento: S/{descuento:F2}");
            Console.WriteLine($"Total a pagar: S/{total:F2}");

        }
    }
}
