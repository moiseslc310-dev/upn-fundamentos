using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PAGO EN CAJA ===");
            Console.Write("Ingrese saldo inicial de caja: S/");
            double saldoCaja = double.Parse(Console.ReadLine());
            Console.Write("Ingrese total de la compra: S/");
            double totalCompra = double.Parse(Console.ReadLine());
            Console.Write("Ingrese pago del cliente: S/");

            double pagoCliente = double.Parse(Console.ReadLine());
            double vuelto;
            double faltante;
            bool pagoValido = ProcesarPago(ref saldoCaja, totalCompra, pagoCliente, out vuelto, out faltante);
            if (pagoValido)
            {
                Console.WriteLine("\nPago realizado correctamente.");
                Console.WriteLine($"Vuelto: S/{vuelto:F2}");
                Console.WriteLine($"Saldo final de caja: S/{saldoCaja:F2}");
            }
            else
            {
                Console.WriteLine("\nPago insuficiente.");
                Console.WriteLine($"Falta pagar: S/{faltante:F2}");
                Console.WriteLine($"Saldo final de caja: S/{saldoCaja:F2}");
            }
        }

        static bool ProcesarPago(ref double saldoCaja, double totalCompra, double pagoCliente, out double vuelto, out double faltante)
        {
            if (pagoCliente >= totalCompra)
            {
                vuelto = pagoCliente - totalCompra;
                faltante = 0;
                saldoCaja = saldoCaja + totalCompra;
                return true;
            }
            else
            {
                vuelto = 0;
                faltante = totalCompra - pagoCliente;
                return false;
            }

        }
    }
}
