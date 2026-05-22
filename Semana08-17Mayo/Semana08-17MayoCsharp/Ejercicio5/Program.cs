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
            Console.Write("Ingrese la nota: ");
            double nota = double.Parse(Console.ReadLine());

            if (EsNotaValida(nota))
            {
                string clasificacion = ClasificarNota(nota);
                MostrarReporte(nota, clasificacion);
            }
            else
            {
                Console.WriteLine("Error: La nota debe estar entre 0 y 20");
            }

        } 

        static bool EsNotaValida(double nota)
        {
            return nota >= 0 && nota <= 20;
        }

        static string ClasificarNota(double nota)
        {
            if (nota >= 18)
                return "Excelente";
            else if (nota >= 14)
                return "Bueno";
            else if (nota >= 11)
                return "Regular";
            else
                return "Desaprobado";
        }

        // Función void (procedimiento) para mostrar el reporte
        static void MostrarReporte(double nota, string clasificacion)
        {
            Console.WriteLine($"Nota ingresada: {nota:F2}");
            Console.WriteLine($"Clasificación: {clasificacion}");
        }

    }
}
