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
            Console.Write("Ingrese ingreso mensual: ");
            double ingreso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese gasto en alimentos: ");
            double alimentos = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese gasto en servicios: ");
            double servicios = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese gasto en transporte: ");
            double transporte = Convert.ToDouble(Console.ReadLine());

            double gastos = CalcularGastos(alimentos, servicios, transporte);
            double saldo = CalcularSaldo(ingreso, gastos);
            bool alerta = EvaluarAlerta(ingreso, gastos);

            Console.WriteLine($"\nTotal de gastos: S/{gastos:F2}");
            Console.WriteLine($"Saldo disponible: S/{saldo:F2}");

            if (alerta)
            {
                Console.WriteLine("Alerta: gastos altos");
            }
            else
            {
                Console.WriteLine("Sin alerta");
            }

            Console.ReadKey();

        }

        static double CalcularGastos(double alimentos, double servicios, double transporte)
        {
            return alimentos + servicios + transporte;
        }

        static double CalcularSaldo(double ingreso, double gastos)
        {
            return ingreso - gastos;
        }

        static bool EvaluarAlerta(double ingreso, double gastos)
        {
            return gastos >= (ingreso * 0.80);
        }

    }
}
