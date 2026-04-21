using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese examen parcial: ");
            int parcial=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese examen final: ");
            int final=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese práctica 1: ");
            int prac1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese práctica 2: ");
            int prac2=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese práctica 3: ");
            int prac3=Convert.ToInt32(Console.ReadLine());
            
            double prom_prac=(prac1+prac2+prac3-Math.Min(prac1,Math.Min(prac2,prac3)))/2;
            double prom_final=Math.Round((parcial+final+prom_prac )/3);

            Console.WriteLine($"Promedio de practicas: {prom_prac}");
            Console.WriteLine($"Promedio final: {prom_final}");

            if (prom_final>=18 && prom_final<=20)
            {
                Console.WriteLine("Excelente");
            }
            else if (prom_final>=14 &&  prom_final<=17)
            {
                Console.WriteLine("Bueno");
            }
            else if (prom_final>=10 && prom_final<=13)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Deficiente");
            }

        }
    }
}
