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
            Console.Write("Ingrese el promedio de notas: ");
            int promedio=Convert.ToInt32(Console.ReadLine());           

            if (promedio>=0 && promedio<=5)
            {
                Console.WriteLine("Calificación: Deficiente");
            }
            else if (promedio>=6 && promedio<=10)
            {
                Console.WriteLine("Calificación: Regular");
            }
            else if (promedio>=11 && promedio<=14)
            {
                Console.WriteLine("Calificación: Bueno");
            }
            else if (promedio>=15 && promedio<=20)
            {
                Console.WriteLine("Calificación: Excelente");
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }
    }
}
