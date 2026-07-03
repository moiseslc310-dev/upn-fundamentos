using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void OrdenarRankingNotas(string[] estudiantes, double[] notas)
        {
            for (int i = 0; i < notas.Length - 1; i++)
            {
                for (int j = 0; j < notas.Length - 1 - i; j++)
                {
                    if (notas[j] < notas[j + 1])
                    {
                        // Intercambiar notas
                        double auxNota = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = auxNota;

                        // Intercambiar nombres
                        string auxNombre = estudiantes[j];
                        estudiantes[j] = estudiantes[j + 1];
                        estudiantes[j + 1] = auxNombre;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string[] estudiantes ={"Ana Torres","Luis Ramos","Maria Diaz","Carlos Lopez"};
            double[] notas ={18,14,19,17};

            // Llamada a la función
            OrdenarRankingNotas(estudiantes, notas);

            Console.WriteLine("------- Ranking de Estudiantes --------\n");

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + estudiantes[i] + " - Nota: " + notas[i]);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    
    }
}
