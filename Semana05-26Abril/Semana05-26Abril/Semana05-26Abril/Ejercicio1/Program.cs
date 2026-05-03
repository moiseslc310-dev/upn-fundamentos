using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 0)
            {
                Console.WriteLine("Error: la edad no puede ser negativa");
            }
            else
            {
                //Si la edad esta entre 0 y 5 años, viaja gratis
                if (edad <= 5)
                {
                    Console.WriteLine("Resultado: viaja gratis, no requiere medio pasaje.");
                }
                else
                {
                    //si tiene entre 6 y 17 años, recien evaluamos el carne
                    if (edad <= 17)
                    {
                        Console.Write("¿Presenta carne de estudiante? (S/N): ");
                        string carnet = Console.ReadLine().ToUpper();

                        if (carnet == "S")
                        {
                            Console.WriteLine("Resultado: Si accede al medio pasaje escolar.");
                        }
                        else
                        {
                            Console.WriteLine("Resultado: No accede al beneficio poque no presento carnet");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Resultado: No accede al medio pasaje escolar por edad.");
                    }

                }

            }
        }
    }
}
