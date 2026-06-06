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
            Console.WriteLine("=== CASA DE CAMBIO ===");
            Console.Write("Ingrese monto en soles: S/");
            double soles = double.Parse(Console.ReadLine());
            double comision = UtilCambio.CalcularComision(soles);
            double solesNetos = UtilCambio.CalcularSolesNetos(soles, comision);
            double dolares = UtilCambio.ConvertirADolares(solesNetos);
            Console.WriteLine("\n=== COMPROBANTE DE CAMBIO ===");
            Console.WriteLine($"Monto ingresado: S/{soles:F2}");
            Console.WriteLine($"Comisión (2%): S/{comision:F2}");
            Console.WriteLine($"Soles netos: S/{solesNetos:F2}");
            Console.WriteLine($"Dólares recibidos: ${dolares:F2}");

        }
    }
}
