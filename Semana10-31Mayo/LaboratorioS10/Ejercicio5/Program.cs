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
            double sumaPorcentajes = 0;

            // Bucle para las 4 sesiones
            for (int sesion = 1; sesion <= 4; sesion++)
            {
                Console.WriteLine($"--- Sesión {sesion} ---");

                Console.Write("Ingrese estudiantes presentes: ");
                int presentes = int.Parse(Console.ReadLine());

                Console.Write("Ingrese estudiantes matriculados: ");
                int matriculados = int.Parse(Console.ReadLine());

                // Llamada a la función para calcular el porcentaje
                double porcentaje = CalcularPorcentaje(presentes, matriculados);
                sumaPorcentajes += porcentaje;
            }

            // Cálculo del promedio final
            double promedio = sumaPorcentajes / 4;

            // Mostrar resultados
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Promedio de asistencia: {promedio:F2}%");

            // Evaluación de la participación
            if (promedio >= 75)
            {
                Console.WriteLine("Participación adecuada");
            }
            else
            {
                Console.WriteLine("Reforzar asistencia");
            }
        }

       
        static double CalcularPorcentaje(int presentes, int matriculados)
        {
            return ((double)presentes * 100) / matriculados;
        }

    }
}
