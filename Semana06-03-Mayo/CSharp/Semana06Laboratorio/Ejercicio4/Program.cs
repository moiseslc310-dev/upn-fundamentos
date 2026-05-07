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
            Random rand = new Random();
            int secreto = rand.Next(1, 51); // Número entre 1 y 50
            int intentos = 0; 
            int maxIntentos = 7;
            bool adivino = false;

            Console.WriteLine("Adivina el número entre 1 y 50. Tienes 7 intentos.");

            while(!adivino && intentos<maxIntentos)
            {
                intentos++;
                Console.Write($"Intento {intentos}: ");
                int intento = int.Parse(Console.ReadLine());

                if(intento==secreto)
                {
                    adivino = true;
                }
                else if (intento<secreto)
                {
                    Console.WriteLine("El número secreto es MAYOR.");
                }
                else
                {
                    Console.WriteLine("El número secreto es MENOR.");
                }
            }
            if(adivino)
            {
                Console.WriteLine($"Ganaste en {intentos} intentos.");
            }
            else
            {
                Console.WriteLine($"Perdiste. El número era {secreto}.");
            }
        }
    }
}
