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
            Console.WriteLine("=== DIVISIÓN SEGURA ===");
            Console.Write("Ingrese el dividendo: ");
            double dividendo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el divisor: ");
            double divisor = double.Parse(Console.ReadLine());
            double resultado;
            // El método devuelve true o false.
            // El resultado de la división se recibe mediante out.
            bool valido = DividirSeguro(dividendo, divisor, out resultado);
            if (valido)
            {
                Console.WriteLine($"Resultado: {resultado:F2}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }

        }

        // Retorna true si se puede dividir.
        // Retorna false si el divisor es cero.
        static bool DividirSeguro(double dividendo, double divisor, out double resultado)
        {
            if (divisor == 0)
            {
                // Todo parámetro out debe recibir un valor antes de salir del método.
                resultado = 0;
                return false;
            }
            resultado = dividendo / divisor;
            return true;

        }
    }
}
