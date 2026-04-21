using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad =int.Parse(Console.ReadLine());

            if (edad >=18)
            {
                Console.WriteLine("Acceso Permitido. Bienvenido");
            }
            else
            {
                int edadfaltante=Math.Abs(edad-18);
                Console.WriteLine("Acceso denegado.");
                Console.WriteLine($"Te faltan {edadfaltante} año(s) para registrarte");
            }
          
        }
    }
}
