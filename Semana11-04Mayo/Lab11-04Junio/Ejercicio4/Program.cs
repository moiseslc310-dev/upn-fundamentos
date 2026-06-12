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

            int[] stock = new int[4];

            for (int i = 0; i < stock.Length; i++)
            {
                Console.Write($"Stock del producto {i}: ");
                stock[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Índice a modificar: ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < stock.Length)
            {
                Console.Write("Nuevo stock: ");
                int nuevo = int.Parse(Console.ReadLine());

                stock[indice] = nuevo;
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }
            Console.WriteLine("\nStock actualizado:");

            for (int i = 0; i < stock.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {stock[i]}");
            }

        }
    }
}
