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
            Console.Write("Deposito inicial: S/. ");
            double saldo=double.Parse(Console.ReadLine());
            Console.Write("Meta a alcanzar: S/. ");
            double meta=double.Parse(Console.ReadLine());

            double tasa = 0.015;
            int meses = 0;
            Console.WriteLine($"Mes 0: S/. {saldo}");

            while(saldo <meta)
            {
                saldo = saldo * (1 + tasa);
                meses++;
                Console.WriteLine($"Mes {meses}: S/. {saldo}");

            }
            Console.WriteLine($"Alcanza la meta en {meses} meses");

        }
    }
}
