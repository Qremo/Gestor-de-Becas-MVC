using System;
using System.Collections.Generic;
using System.Text;
/*******************************************************************
 * EQUIPO: [Pendiente de asignar]
 * INTEGRANTES:
 *   GARCÍA COLMENARES, Arturo Misael
 *   HILARIO ANDRADE, Luis Ángel
 * PROYECTO: Gestor de Becas y Apoyos Estudiantiles
 * MATERIA: Programación Orientada a Eventos (MVC - Capa Modelo)
 *******************************************************************/

namespace Gestor_de_becas.Models
{
    internal class Presupuesto
    {
        private int idPresupuesto;
        private string periodoAnual;
        private decimal montoAsignado;
        private decimal montoEjecutado;
        private string fuenteFinanciamiento;
        private string rutaImagen;
        private bool estado;

        public int IdPresupuesto
        {
            get { return idPresupuesto; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del presupuesto debe ser un número entero positivo.");
                idPresupuesto = value;
            }
        }

        public string PeriodoAnual
        {
            get { return periodoAnual; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El período anual no puede estar vacío.");
                periodoAnual = value.Trim();
            }
        }

        public decimal MontoAsignado
        {
            get { return montoAsignado; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El monto asignado no puede ser negativo.");
                montoAsignado = value;
            }
        }

        public decimal MontoEjecutado
        {
            get { return montoEjecutado; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El monto ejecutado no puede ser negativo.");
                montoEjecutado = value;
            }
        }

        public string FuenteFinanciamiento
        {
            get { return fuenteFinanciamiento; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La fuente de financiamiento no puede estar vacía.");
                fuenteFinanciamiento = value.Trim();
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_presupuesto.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Presupuesto()
        {
            idPresupuesto = 0;
            periodoAnual = "2026";
            montoAsignado = 0.0m;
            montoEjecutado = 0.0m;
            fuenteFinanciamiento = "Estatal";
            rutaImagen = "default_presupuesto.png";
            estado = true;
        }

        public Presupuesto(int idPresupuesto, string periodoAnual, decimal montoAsignado, decimal montoEjecutado, string fuenteFinanciamiento, string rutaImagen, bool estado)
        {
            IdPresupuesto = idPresupuesto;
            PeriodoAnual = periodoAnual;
            MontoAsignado = montoAsignado;
            MontoEjecutado = montoEjecutado;
            FuenteFinanciamiento = fuenteFinanciamiento;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public decimal CalcularMontoDisponible()
        {
            return montoAsignado - montoEjecutado;
        }

        public decimal CalcularMontoDisponible(decimal reservaEmergencia)
        {
            decimal disponible = montoAsignado - montoEjecutado - reservaEmergencia;
            return disponible < 0 ? 0 : disponible;
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Disponible" : "Agotado/Cerrado";
            return $"[Presupuesto #{idPresupuesto}] Año: {periodoAnual} | Asignado: ${montoAsignado:N2} | Disponible: ${CalcularMontoDisponible():N2} | Estado: {estatusTexto}";
        }
    }
}
