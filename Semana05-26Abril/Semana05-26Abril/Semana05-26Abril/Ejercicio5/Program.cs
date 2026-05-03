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
            Console.Write("Ingrese la cantidad de días: ");
            int n = int.Parse(Console.ReadLine());

            double total = 0;
            double mayor = double.MinValue;
            double menor = double.MaxValue;

            int diaMayor = 0;
            int diaMenor = 0;

            int excelente = 0;
            int bueno = 0;
            int regular = 0;
            int malo = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese la venta del dia {i}: ");
                double venta=double.Parse(Console.ReadLine());

                total = total + venta;

                if (venta>mayor)
                {
                    mayor = venta;
                    diaMayor = i;
                }
                if (venta<menor)
                {
                    menor = venta;
                    diaMenor= i;
                }
                
                if (venta>=500)
                {
                    excelente++;
                }
                else if(venta>=200)
                {
                    bueno++;
                }
                else if (venta>=50)
                {
                    regular++;
                }
                else
                {
                    malo++;
                }
            }
            double promedio = total / n;
            Console.WriteLine();
            Console.WriteLine("---------- Resumen de Ventas ----------------");
            Console.WriteLine($"Total de ventas: {total:C2}");
            Console.WriteLine($"Promedio diario: {promedio:C2}");
            Console.WriteLine($"Mayor venta: Día {diaMayor} con {mayor:C2}");
            Console.WriteLine($"Menor venta: Día {diaMenor} con {menor:C2}");
            Console.WriteLine($"Días Excelentes: {excelente}");
            Console.WriteLine($"Días Buenos:     {bueno}");
            Console.WriteLine($"Días Regulares:  {regular}");
            Console.WriteLine($"Días Malos:      {malo}");
            Console.WriteLine();

        }
    }
}
