using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class UtilCambio
    {
        public const double TIPO_CAMBIO = 3.75;
        public const double COMISION = 0.02;
        public static double CalcularComision(double soles)
        {
            return soles * COMISION;
        }
        public static double CalcularSolesNetos(double soles, double comision)
        {
            return soles - comision;
        }

        public static double ConvertirADolares(double solesNetos)
        {
            return solesNetos / TIPO_CAMBIO;
        }


    }
}
