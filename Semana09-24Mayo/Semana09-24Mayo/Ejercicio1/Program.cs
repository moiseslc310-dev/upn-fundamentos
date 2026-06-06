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
            Console.WriteLine("=== CONTROL DE STOCK ===");
            Console.Write("Ingrese stock actual: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad vendida: ");
            int venta = int.Parse(Console.ReadLine());

            // Primero validamos si la venta puede realizarse.
            if (venta <= stock)
            {
                // Esta función recibe el stock por valor.
                // Solo simula la venta, pero no modifica el stock real.
                SimularVenta(stock, venta);
                Console.WriteLine($"Stock real después de simular: {stock}");

                // Esta función recibe el stock por referencia.
                // Aquí sí se modifica el stock real.
                ConfirmarVenta(ref stock, venta);
                Console.WriteLine($"Stock real después de confirmar: {stock}");
            }
            else
            {
                Console.WriteLine("No se confirma venta por falta de stock.");

            }
        }

        // Parámetro por valor:
        // stock recibe una copia del valor original.
        static void SimularVenta(int stock, int venta)
        {
            stock = stock - venta;
            Console.WriteLine($"Simulación: el stock quedaría en {stock}");
        }

        // Parámetro por referencia:
        // ref permite modificar la variable original enviada desde Main.
        static void ConfirmarVenta(ref int stock, int venta)
        {
            stock = stock - venta;
            Console.WriteLine("Confirmación: venta realizada correctamente.");
        }

    }
}

