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
            // Crear un arreglo para guardar 3 nombres
            string[] estudiantes = new string[3];
            // Registrar nombres en el arreglo
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write($"Nombre del estudiante {i + 1}: ");
                estudiantes[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Estudiantes registrados:");
            // Mostrar nombres guardados en el arreglo
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {estudiantes[i]}");
            }
        }
    }
}
