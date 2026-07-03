using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void BuscarEstudiante(string[] estudiantes, double[] notas, string texto)
        {
            bool encontrado = false;

            texto = texto.Trim().ToLower();

            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (estudiantes[i].Trim().ToLower().Contains(texto))
                {
                    Console.WriteLine("\nEstudiante encontrado:");
                    Console.WriteLine("Nombre: " + estudiantes[i]);
                    Console.WriteLine("Nota: " + notas[i]);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\nNo se encontró ningún estudiante con ese nombre.");
            }
        }

        static void Main(string[] args)
        {
            string[] estudiantes = {"Ana Torres","Luis Ramos","Maria Diaz"};
            double[] notas ={18,14,11};

            Console.Write("Ingrese parte del nombre del estudiante: ");
            string buscar = Console.ReadLine();

            BuscarEstudiante(estudiantes, notas, buscar);

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();

        }
    }
}
