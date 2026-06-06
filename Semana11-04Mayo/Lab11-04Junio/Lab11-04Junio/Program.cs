using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_04Junio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] estudiantes = new string[3];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i]=Console.ReadLine();
            }

            for (int i = 0;i < estudiantes.Length;i++)
            {
                Console.WriteLine(estudiantes[i]);
            }

        }
    }
}
