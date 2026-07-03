using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static bool CodigoValido(string ingresado, string esperado)
        {
            // Normaliza el código ingresado:
            // quitar espacios extremos y convertir a mayúsculas.
            string codigoIngresadoNormalizado = ingresado.Trim().ToUpper();
            // Normaliza el código esperado con la misma lógica.
            string codigoEsperadoNormalizado = esperado.Trim().ToUpper();
            // CompareTo devuelve 0 si ambas cadenas son iguales.
            return codigoIngresadoNormalizado.CompareTo(codigoEsperadoNormalizado) == 0;

        }
        static void Main(string[] args)
        {
            Console.Write("Código esperado: ");
            string esperado = Console.ReadLine();
            Console.Write("Código ingresado: ");
            string ingresado = Console.ReadLine();
            // Llama a la función y valida el resultado.
            if (CodigoValido(ingresado, esperado))
            {
                Console.WriteLine("Código aceptado.");

            }
            else
            {
                Console.WriteLine("Código no coincide.");
            }

        }
    }
}
