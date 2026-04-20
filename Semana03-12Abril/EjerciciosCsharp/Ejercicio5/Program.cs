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
            Console.Write("Monto en soles: ");
            double monto = double.Parse(Console.ReadLine());

            double haciaArriba =Math.Ceiling(monto);
            double haciaAbajo = Math.Floor(monto);
            int truncado =(int)monto;
            double redondeado = Math.Round(monto, 2);

            Console.WriteLine($"Monto Original:            {monto}");
            Console.WriteLine($"Ceiling (Hacia Arriba):    {haciaArriba}");
            Console.WriteLine($"Floor (Hacia Abajo):       {haciaAbajo}");
            Console.WriteLine($"Truncado (Casting int):    {truncado}");
            Console.WriteLine($"Redondeado (2 deciamales): {redondeado}");


        }
    }
}
