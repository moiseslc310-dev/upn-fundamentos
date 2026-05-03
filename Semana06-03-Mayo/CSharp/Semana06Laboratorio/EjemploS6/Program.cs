using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EjemploS6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo01();
            Ejemplo02();
            Console.ReadKey();
        }
        //Ejemplo1
        static void Ejemplo01()
        {
            //Encontrar la suma de n números ingresados por el teclado.
            int n;
            int numero;
            int suma = 0;

            Console.Write("¿Cantidad de numeros que desea sumar?: ");
            n=int.Parse(Console.ReadLine());

            int contador = 1; // inicializar el bucle

            while(contador<=n)
            {
                Console.Write($"Ingrese el numero {contador}: ");
                numero=int.Parse(Console.ReadLine());

                suma = suma + numero; // suma += numero;
                contador++;

            }
            Console.WriteLine($"La suma de los {n} numeros es: {suma}");

        }

        //Ejemplo2
        static void Ejemplo02()
        {
            //Encontrar la suma de n números aleatorios.
            int n, suma = 0;
            Random randon=new Random();
            Console.Write("¿Cuantos numeros aleatorios desea sumar?: ");
            n=int.Parse(Console.ReadLine());

            int contador = 1;
            while (contador<=n)
            {
                int numero = randon.Next(1,101);
                Console.WriteLine($"Numero aleatorio {contador}: {numero}");
                suma += numero; // acumular
                contador++; // avanza
            }
            Console.WriteLine($"La suma de los {n} numeros aleatorios es: {suma}");

        }
    }
}
