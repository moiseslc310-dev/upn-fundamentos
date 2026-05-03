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
            Console.Write("Ingrese la cantidad de empleados: ");
            int cant =int.Parse(Console.ReadLine());
            double totalPlanilla = 0;

            for (int i = 1; i <= cant; i++)
            {
                Console.Write("Ingrese nombre del empleado: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese horas trabajadas: ");
                double horasTrabajadas=double.Parse(Console.ReadLine());

                double sueldoBruto,horasNormales, horasExtra;

                if (horasTrabajadas<=160)
                {
                    horasNormales = horasTrabajadas;
                    horasExtra = 0;
                    sueldoBruto = horasNormales * 12.50;

                }
                else
                {
                    horasNormales = 160;
                    horasExtra = horasTrabajadas - 160;
                    sueldoBruto = 160 * 12.50 + horasTrabajadas * 25.00;
                }

                double descuento = sueldoBruto * 0.05;
                double sueldoNeto = sueldoBruto - descuento;
                totalPlanilla = totalPlanilla+sueldoNeto;
                Console.WriteLine();
                Console.WriteLine($"Empleado {i}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Horas Normales: {horasNormales}");
                Console.WriteLine("-------Boleta de Empleado--------");
                Console.WriteLine($"Horas Extras: {horasExtra}");
                Console.WriteLine($"Sueldo Bruto: {sueldoBruto:C2}");
                Console.WriteLine($"Descuento: {descuento:C2}");
                Console.WriteLine($"Sueldo Neto: {sueldoNeto:C2}");
                Console.WriteLine();

            }
            Console.WriteLine($"Total de la planilla: {totalPlanilla:C2}");
        }
    }
}
