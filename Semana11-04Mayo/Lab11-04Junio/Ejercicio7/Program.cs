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

            int[] asistencia = new int[5];
            bool existeCero = false;
            int indiceModificar, nuevoValor;

            Console.WriteLine("Ingrese la asistencia de las 5 sesiones:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Sesión {i}: ");
                asistencia[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nAsistencias registradas:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]}");
            }

            for (int i = 0; i < 5; i++)
            {
                if (asistencia[i] == 0)
                {
                    existeCero = true;
                }
            }

            if (existeCero)
            {
                Console.WriteLine("\nAlerta: existe una sesión con 0 asistentes");
            }
            else
            {
                Console.WriteLine("\nNo hay sesión con 0 asistentes");
            }

            Console.Write("\nIngrese el índice a modificar (0-4): ");
            indiceModificar = Convert.ToInt32(Console.ReadLine());

            if (indiceModificar >= 0 && indiceModificar < 5)
            {
                Console.Write("Ingrese el nuevo valor: ");
                nuevoValor = Convert.ToInt32(Console.ReadLine());

                asistencia[indiceModificar] = nuevoValor;
            }
            else
            {
                Console.WriteLine("Índice no válido");
            }

            Console.WriteLine("\nAsistencias actualizadas:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Índice {i}: {asistencia[i]}");
            }

        }
    }
}
