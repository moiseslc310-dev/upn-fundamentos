using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldo = 1000;
            int retiros = 0;
            Console.WriteLine("=== CAJERO AUTOMATICO ===");
            Console.WriteLine($"Saldo disponible: S/. {saldo}");

            //1era lectura
            Console.Write("Monto a retirar (0 para salir): ");
            int monto=int.Parse(Console.ReadLine());

            while( monto != 0 )
            {
                if(monto<0)
                {
                    Console.WriteLine("Error: Monto invalido");
                }
                else if(monto>saldo)
                {
                    Console.WriteLine("Error: saldo insuficiente.");
                }
                else
                {
                    saldo = saldo - monto;
                    retiros++;
                    Console.WriteLine($"Retiro exitoso. Saldo: S/.{saldo}");
                }
                //2da lectura
                Console.Write("Monto a retirar (0 para salir): ");
                monto= int.Parse(Console.ReadLine());

            }
            Console.WriteLine("----- RESUMEN -------");
            Console.WriteLine($"Retiros realizados:{retiros}");
            Console.WriteLine($"Saldo final: {saldo}");
        }
    }
}
