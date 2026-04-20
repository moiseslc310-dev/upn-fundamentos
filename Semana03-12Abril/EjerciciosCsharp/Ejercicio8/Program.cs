using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la temperatura en Celsius (C°): ");
            double temperatura = double.Parse(Console.ReadLine());

            double Fahrenheit = (temperatura * (9.0 / 5)) + 32;
            double kelvin = temperatura + 273.15;

            Console.WriteLine($"La temperatura en Fahrenheit es: {Fahrenheit:F2} °F");
            Console.WriteLine($"La temperatura en kelvin es: {kelvin:F2} K");

        }
    }
}
