using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static bool ContieneClave(string comentario, string clave)
        {
            // Completa la normalización del comentario:
            // quitar espacios extremos y convertir a minúsculas.
            string texto = comentario.Trim().ToLower();
            // Completa la normalización de la palabra clave.
            string buscar = clave.Trim().ToLower();
            // Completa el método que verifica si texto contiene la palabra clave.
            return texto.Contains(buscar);
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el comentario del estudiante: ");
            // Completa la lectura del comentario.
            string comentario = Console.ReadLine();
            Console.Write("Ingrese la palabra clave a buscar: ");
            // Completa la lectura de la palabra clave.
            string clave = Console.ReadLine();
            // Completa la llamada a la función.
            if (ContieneClave(comentario, clave))
            {
                Console.WriteLine("El comentario contiene la palabra clave.");
            }
            else
            {
                Console.WriteLine("El comentario no contiene la palabra clave.");
            }
        }
    }
}
