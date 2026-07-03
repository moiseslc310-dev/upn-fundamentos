using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static string NormalizarCodigo(string codigo)
        {
            // Completa el método para quitar espacios extremos.
            codigo = codigo.Trim();
            // Completa el método para eliminar los guiones.
            codigo = codigo.Replace("-", "");
            // Completa el método para convertir el código a mayúsculas.
            codigo = codigo.ToUpper();
            return codigo;
        }

        static bool TieneLongitudValida(string codigo)
        {
            // Completa la propiedad y el número de caracteres requeridos.
            return codigo.Length == 8;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese código de comprobante: ");
            // Completa la lectura del código ingresado.
            string codigoIngresado = Console.ReadLine();
            // Completa la llamada a la función que limpia el código.
            string codigoNormalizado = NormalizarCodigo(codigoIngresado);
            Console.WriteLine($"Código normalizado: {codigoNormalizado} ");
            // Completa la llamada a la función de validación.
            if (TieneLongitudValida(codigoNormalizado))
            {
                Console.WriteLine("Código válido.");
            }
            else
            {
                Console.WriteLine("Código inválido. Debe tener 8 caracteres.");

            }
        }
    }
}
