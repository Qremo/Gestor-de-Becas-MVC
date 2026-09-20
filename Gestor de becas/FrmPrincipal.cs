using System;
using System.Text;
using System.Windows.Forms;
using Gestor_de_becas.Models;

namespace Gestor_de_becas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder resultadoPruebas = new StringBuilder();

            try
            {
                Estudiante estudianteValido = new Estudiante(
                    "222647334",
                    "Arturo García",
                    "Ingeniería en Computación",
                    95.0,
                    4,
                    "foto.jpg",
                    true
                );

                Presupuesto presupuestoValido = new Presupuesto(
                    1,
                    "2026",
                    500000.00m,
                    150000.00m,
                    "Estatal",
                    "presupuesto.png",
                    true
                );

                resultadoPruebas.AppendLine("=== PRUEBAS CON DATOS VÁLIDOS ===");
                resultadoPruebas.AppendLine(estudianteValido.ToString());
                resultadoPruebas.AppendLine($"¿Es elegible para beca?: {estudianteValido.EsElegibleParaBeca()}");
                resultadoPruebas.AppendLine();
                resultadoPruebas.AppendLine(presupuestoValido.ToString());
                resultadoPruebas.AppendLine($"Disponible con reserva: ${presupuestoValido.CalcularMontoDisponible(50000m):N2}");
                resultadoPruebas.AppendLine("\n-------------------------------------------------\n");
            }
            catch (Exception ex)
            {
                resultadoPruebas.AppendLine($"Error inesperado en prueba válida: {ex.Message}");
            }

            try
            {
                resultadoPruebas.AppendLine("=== PRUEBA DE VALIDACIÓN (PROMEDIO INVÁLIDO) ===");

                Estudiante estudianteInvalido = new Estudiante(
                    "219876543",
                    "Arturo García",
                    "Ingeniería en Computación",
                    150.0,
                    4,
                    "foto.jpg",
                    true
                );
            }
            catch (ArgumentException ex)
            {
                resultadoPruebas.AppendLine($"Excepción capturada correctamente: {ex.Message}");
            }

            MessageBox.Show(
                resultadoPruebas.ToString(),
                "Demostración de Pruebas del Modelo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbpPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarSolicitudes_Click(object sender, EventArgs e)
        {

        }
    }
}