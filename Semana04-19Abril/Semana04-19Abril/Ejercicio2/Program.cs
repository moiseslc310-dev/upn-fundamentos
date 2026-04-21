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
            Console.WriteLine("==== Menú de operaciones ===");
            Console.WriteLine("1.- Calcular área de un círculo");
            Console.WriteLine("2.- Calcular área de un cuadrado");
            Console.WriteLine("3.- Calcular área de un triángulo");
            Console.WriteLine("4.- Salir");
            Console.Write("Seleccione una opción (1-4): ");
            int opcion =int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("Área Circulo = PI x R x R");
                    Console.Write("Ingrese la Radio: ");
                    double radio = double.Parse(Console.ReadLine());
                    double areaCirc =Math.PI*Math.Pow(radio,2);
                    Console.WriteLine($"El área del circulo es: {areaCirc:F2}");
                    break;
                case 2:
                    Console.WriteLine("Area Cuadrado = Lado x Lado");
                    Console.Write("Ingrese Lado: ");

                    double lado = double.Parse(Console.ReadLine());
                    double areaCuad=Math.Pow(lado,2);
                    Console.WriteLine($"Área del cuadrado es: {areaCuad:F2}");
                    break;
                case 3:
                    Console.WriteLine("Área de triángulo = (base x altura)/2");
                    Console.Write("Ingrese Base: ");
                    double baseT = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese altura: ");
                    double altura = double.Parse(Console.ReadLine());

                    double areaTri = (baseT * altura) / 2;
                    Console.WriteLine($"Área del triangulo {areaTri:F2}");

                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Ingrese un número del 1 al 4");
                    break;
            
            }
        }
    }
}
