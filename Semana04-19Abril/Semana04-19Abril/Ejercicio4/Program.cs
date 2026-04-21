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
            Console.Write("Ingrese la categoria: ");
            string cat =Console.ReadLine().ToUpper();
            Console.Write("Ingrese las horas trabajadas: ");
            double horas =double.Parse(Console.ReadLine());
            Console.Write("Ingrese los años trabajados: ");
            double anios =int.Parse(Console.ReadLine());
            double tarifa = 0;

            if (cat == "A")
            {
                tarifa = 33.5;
            }
            else if (cat == "B") 
            {
                tarifa = 29.80;
            
            }
            else if(cat == "C")
            {
                tarifa = 25.70;
            }
            else
            {
                Console.WriteLine("Categoria invalida");
                return;
            }

            double bono = 0;
            if (anios<=3)
            {
                bono = 0.00;
            }
            else if (anios>=4 && anios<=10)
            {
                bono = 0.10;
            }
            else if (anios>=11 && anios<=17)
            {
                bono = 0.20;
            }
            else
            {
                bono = 0.30;
            }

            double sueldoFinal = tarifa * horas - (1 + bono);
            Console.WriteLine($"Sueldo: {sueldoFinal:C2}");

        }
    }
}
