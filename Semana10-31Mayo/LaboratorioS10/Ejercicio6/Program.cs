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
            double totalDia = 0;

            for (int turno = 1; turno <= 3; turno++)
            {
                Console.WriteLine($"Turno {turno}");

                double cantidad = 0;
                do
                {
                    Console.Write("Ingrese cantidad: ");
                    cantidad = Convert.ToDouble(Console.ReadLine());

                    if (cantidad <= 0)
                    {
                        Console.WriteLine("Error: la cantidad debe ser mayor que 0");
                    }
                } while (cantidad <= 0);

                double precio = 0;
                do
                {
                    Console.Write("Ingrese precio: ");
                    precio = Convert.ToDouble(Console.ReadLine());

                    if (precio <= 0)
                    {
                        Console.WriteLine("Error: el precio debe ser mayor que 0");
                    }
                } while (precio <= 0);

                double venta = CalcularVentaTurno(cantidad, precio);

                totalDia += venta;

                Console.WriteLine($"Venta del turno: S/. {venta:N2}");
                Console.WriteLine();
            } 

            Console.WriteLine($"Total vendido del día: S/. {totalDia:N2}");
        }

        static double CalcularVentaTurno(double cantidad, double precio)
        {
            return cantidad * precio;
        }
    }
}
