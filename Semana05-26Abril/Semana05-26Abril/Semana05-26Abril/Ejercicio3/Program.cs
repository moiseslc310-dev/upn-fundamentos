using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precioUnitario = 5.00;
            //Mostrar encabezado de la tabla
            Console.WriteLine("Cant | Subtotal | Desc% | Total");
            Console.WriteLine("-----|----------|-------|------------");

            for (int cant=1;cant<=20;cant++)
            {
                double subtotal = cant * precioUnitario;
                double descuento;
                if (cant <= 5)
                {
                    descuento = 0;
                }
                else if (cant <= 12)
                {
                    descuento = subtotal * 0.10;
                }
                else
                {
                    descuento = subtotal * 0.20;
                }
                double total = subtotal  - descuento;
                Console.WriteLine($"{cant,5}|S/{subtotal,8:F2}|{descuento,6:F0}%|S/{total,6:F2}");
            }
            
        }
    }
}
