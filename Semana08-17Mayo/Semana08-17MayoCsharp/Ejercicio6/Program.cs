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
            Console.Write("Ingrese los m3 consumidos: ");
            double m3 = double.Parse(Console.ReadLine());

            double costo = CalcularCostoAgua(m3);

            Console.WriteLine("\n=== RECIBO FINAL ===");
            MostrarRecibo(m3, costo);

        }

        static double CalcularCostoAgua(double m3)
        {
            double costo;
            if (m3 <= 20)
            {
                costo = m3 * 1.80;
            }
            else
            {
                costo = (20 * 1.80) + ((m3 - 20) * 2.50);
            }
            return costo;
        }

        static void MostrarRecibo(double m3, double costo)
        {
            Console.WriteLine($"Consumo: {m3} m3");
            Console.WriteLine($"Costo total: S/ {costo:F2}");
        }
    }
}
