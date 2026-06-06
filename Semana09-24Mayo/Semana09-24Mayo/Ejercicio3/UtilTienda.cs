using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class UtilTienda
    {
        // Calcula el subtotal de la compra
        public static double CalcularSubtotal(int cantidad, double precio)
        {
            return cantidad * precio;
        }
        // Calcula el descuento si el subtotal supera S/200
        public static double CalcularDescuento(double subtotal)
        {
            if (subtotal > 200)
            {
                return subtotal * 0.10;
            }
            else
            {
                return 0;
            }
        }

        // Calcula el total final a pagar
        public static double CalcularTotal(double subtotal, double descuento)
        {
            return subtotal - descuento;
        }

    }
}
