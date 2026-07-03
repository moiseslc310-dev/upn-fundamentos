using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Analizar(string texto)
        {
            // Completa los valores iniciales de los contadores.
            int vocales = 0;
            int digitos = 0;
            int espacios = 0;
            // Completa el método para convertir el texto a minúsculas.
            texto = texto.ToLower();
            // Completa la propiedad que indica la cantidad de caracteres.
            for (int i = 0; i < texto.Length; i++)
            {
                // Completa el índice para obtener el carácter actual.
                char c = texto[i];
                // Verifica si el carácter actual es una vocal.
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'á' || c == 'é' || c == 'í' || c == 'ó' || c == 'ú')
                {
                    // Completa el incremento del contador de vocales.
                    vocales = vocales + 1;
                }
                // Completa la función de C# que verifica si un carácter es dígito.
                if (char.IsDigit(c))
                {
                    // Completa el incremento del contador de dígitos.
                    digitos = digitos + 1;
                }
                // Completa el carácter que representa un espacio.
                if (c == ' ')
                {
                    // Completa el incremento del contador de espacios.
                    espacios = espacios + 1;
                }
            }
            // Completa las variables que se deben mostrar.
            Console.WriteLine($"Vocales: {vocales} ");
            Console.WriteLine($"Dígitos: {digitos} ");
            Console.WriteLine($"Espacios: {espacios}");
        }
        static void Main(string[] args)
        {
            Console.Write("Observación: ");
            // Completa la instrucción para leer texto desde consola.
            string observacion = Console.ReadLine();
            // Completa la llamada al método que analiza la observación.
            Analizar(observacion);
        }
    }
}
