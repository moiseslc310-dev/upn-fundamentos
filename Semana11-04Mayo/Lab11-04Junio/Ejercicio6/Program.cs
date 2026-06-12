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

            double[] precios = new double[5];
            double buscado, nuevo;
            int posicion = -1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese el precio {i + 1}: ");
                precios[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Ingrese el precio a buscar: ");
            buscado = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                if (precios[i] == buscado)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
            {
                Console.Write("Ingrese el nuevo precio: ");
                nuevo = Convert.ToDouble(Console.ReadLine());

                precios[posicion] = nuevo;

                Console.WriteLine("Precio actualizado");
            }
            else
            {
                Console.WriteLine("Precio no encontrado");
            }

            Console.WriteLine("\nLista de precios:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Posición {i}: {precios[i]}");
            }


        }
    }
}
