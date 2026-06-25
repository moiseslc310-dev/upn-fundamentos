using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Ejercicio1_PlanillaPorTurnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Función para leer sueldos
        // Esta función recibe varios TextBox, lee sus valores y los guarda en un arreglo.
        private double[] LeerSueldos(TextBox[] cajas)
        {
            // Creamos un arreglo del mismo tamaño que la cantidad de TextBox recibidos.
            double[] sueldos = new double[cajas.Length];
            // Recorremos cada TextBox, convertimos su texto a double y lo guardamos.
            for (int i = 0; i < cajas.Length; i++)
            {
                sueldos[i] = double.Parse(cajas[i].Text);
            }
            // Devolvemos el arreglo lleno.
            return sueldos;
        }

        //Función para calcular total
        //Esta función suma todos los sueldos de un turno.
        private double CalcularTotal(double[] datos)
        {
            // Acumulador para sumar los sueldos.
            double total = 0;
            // Recorremos el arreglo y sumamos cada sueldo.
            for (int i = 0; i < datos.Length; i++)
            {
                total = total + datos[i];
            }
            return total;
        }

        // Función para ordenar por burbuja
        //Esta función ordena un arreglo de menor a mayor.
        private void OrdenarBurbuja(double[] datos)
        {
            // Método burbuja ascendente: ordena de menor a mayor.
            for (int i = 0; i < datos.Length - 1; i++)
            {
                for (int j = 0; j < datos.Length - 1 - i; j++)
                {
                     // Si el elemento actual es mayor que el siguiente, se intercambian.
                    if (datos[j] > datos[j+1])
                    {
                        double auxiliar = datos[j];
                        datos[j] = datos[j+1];
                        datos[j + 1] = auxiliar;
                    }
                }
            }
        }

        //Función para mostrar resultados - Mostrar un arreglo en el ListBox
        //Esta función muestra los sueldos ordenados de un turno.
        private void MostrarArreglo(string nombreTurno, double[] datos)
        {
            // Construimos una línea de texto con los sueldos del turno.
            string linea = nombreTurno + ": ";
            // Agregamos cada sueldo a la línea.
            for (int i = 0; i < datos.Length; i++)
            {
                linea += $"S/{datos[i]:F2} ";
            }
            // Mostramos la línea en el ListBox.
            lstResultados.Items.Add(linea);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiamos resultados anteriores.
                lstResultados.Items.Clear();
                // 1. Leemos los sueldos de cada turno.
                double[] manana = LeerSueldos(new TextBox[] { txbM1, txbM2, txbM3 });
                double[] tarde = LeerSueldos(new TextBox[] { txbT1, txbT2 });
                double[] noche = LeerSueldos(new TextBox[] { txbN1, txbN2 });
                // 2. Calculamos el total de cada turno.
                double totalManana = CalcularTotal(manana);
                double totalTarde = CalcularTotal(tarde);
                double totalNoche = CalcularTotal(noche);
                // 3. Mostramos los totales.
                lstResultados.Items.Add("=== TOTALES POR TURNO ===");
                lstResultados.Items.Add($"Mañana: S/{totalManana:F2}");
                lstResultados.Items.Add($"Tarde: S/{totalTarde:F2}");
                lstResultados.Items.Add($"Noche: S/{totalNoche:F2}");

                //4.Identificamos el turno con mayor gasto.
                string turnoMayor = "Mañana";
                double mayorGasto = totalManana;
                if (totalTarde > mayorGasto)
                {
                    mayorGasto = totalTarde;
                    turnoMayor = "Tarde";
                }
                if (totalNoche > mayorGasto)
                {
                    mayorGasto = totalNoche;
                    turnoMayor = "Noche";
                }
                lblTurnoMayor.Text = $"Turno con mayor gasto: {turnoMayor} (S/{mayorGasto:F2})";
                // 5. Ordenamos los sueldos de cada turno.
                OrdenarBurbuja(manana);
                OrdenarBurbuja(tarde);
                OrdenarBurbuja(noche);
                // 6. Mostramos los sueldos ordenados.
                lstResultados.Items.Add("");
                lstResultados.Items.Add("=== SUELDOS ORDENADOS DE MENOR A MAYOR ===");
                MostrarArreglo("Mañana", manana);
                MostrarArreglo("Tarde", tarde);
                MostrarArreglo("Noche", noche);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números válidos en los sueldos.",
                "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiamos los TextBox.
            txbM1.Clear();
            txbM2.Clear();
            txbM3.Clear();
            txbT1.Clear();
            txbT2.Clear();
            txbN1.Clear();
            txbN2.Clear();
            // Limpiamos resultados.
            lstResultados.Items.Clear();
            // Reiniciamos el texto del Label.
            lblTurnoMayor.Text = "____________________________";
            // Enviamos el foco al primer TextBox.
            txbM1.Focus();
        }

        private void btnDatosPrueba_Click(object sender, EventArgs e)
        {
            // Permite recargar los datos de prueba.
            CargarDatosDePrueba();
        }

        private void CargarDatosDePrueba()
        {
            // Datos del turno mañana.
            txbM1.Text = "1500";
            txbM2.Text = "1200";
            txbM3.Text = "1800";
            // Datos del turno tarde.
            txbT1.Text = "1100";
            txbT2.Text = "1400";
            // Datos del turno noche.
            txbN1.Text = "1000";
            txbN2.Text = "950";
            // Limpiamos resultados anteriores.
            lstResultados.Items.Clear();
            lblTurnoMayor.Text = "Turno con mayor gasto: -";
        }
    }
}
