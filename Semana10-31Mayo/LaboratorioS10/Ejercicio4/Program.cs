using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el código de comprobante: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            // digitos = ContarDigitos(codigo)
            int digitos = ContarDigitos(codigo);

            // SI digitos >= 6 Y digitos <= 8 ENTONCES
            if (digitos >= 6 && digitos <= 8)
            {
                Console.WriteLine("Código válido");
            }
            else
            {
                Console.WriteLine("Código inválido");
            }

        }

        static int ContarDigitos(int codigo)
        {
            int contador = 0;

            codigo = Math.Abs(codigo);

            if (codigo == 0)
            {
                return 1;
            }

            while (codigo > 0)
            {
                contador = contador + 1;
                codigo = codigo / 10; 
            }

            return contador;
        }

    }
}
