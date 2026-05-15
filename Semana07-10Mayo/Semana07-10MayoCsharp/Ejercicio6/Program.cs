using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votosAna = 0;
            int votosCarlos = 0;
            int votosLucia = 0;
            int nulos = 0;
            int voto;

            do
            {
                Console.WriteLine("\n--- OPCIONES DE VOTACIÓN ---");
                Console.WriteLine("1. Ana Torres");
                Console.WriteLine("2. Carlos Mendoza");
                Console.WriteLine("3. Lucia Paredes");
                Console.WriteLine("0. Cerrar votación");
                Console.Write("Ingrese su voto: ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    votosAna = votosAna + 1;
                }
                else if (voto == 2)
                {
                    votosCarlos = votosCarlos + 1;
                }
                else if (voto == 3)
                {
                    votosLucia = votosLucia + 1;
                }
                else if (voto != 0)
                {
                    nulos = nulos + 1;
                    Console.WriteLine("Voto nulo");
                }

            } while (voto != 0);

            int total = votosAna + votosCarlos + votosLucia + nulos;

            Console.WriteLine("\n=== RESULTADOS FINALES ===");
            Console.WriteLine($"Votos de Ana Torres: {votosAna}");
            Console.WriteLine($"Votos de Carlos Mendoza: {votosCarlos}");
            Console.WriteLine($"Votos de Lucia Paredes: {votosLucia}");
            Console.WriteLine($"Votos nulos: {nulos}");
            Console.WriteLine($"Total de votantes: {total}");

            if (votosAna > votosCarlos && votosAna > votosLucia)
            {
                Console.WriteLine("Ganadora: Ana Torres");
            }
            else if (votosCarlos > votosAna && votosCarlos > votosLucia)
            {
                Console.WriteLine("Ganador: Carlos Mendoza");
            }
            else if (votosLucia > votosAna && votosLucia > votosCarlos)
            {
                Console.WriteLine("Ganadora: Lucia Paredes");
            }
            else
            {
                Console.WriteLine("Resultado: EMPATE");
            }
        }
    }
}
