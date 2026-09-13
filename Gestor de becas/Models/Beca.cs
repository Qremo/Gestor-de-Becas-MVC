using System;
using System.Collections.Generic;
using System.Text;

/*******************************************************************
 * EQUIPO: 6
 * INTEGRANTES:
 *   GARCÍA COLMENARES, Arturo Misael
 *   HILARIO ANDRADE, Luis Ángel
 * PROYECTO: Gestor de Becas y Apoyos Estudiantiles
 * MATERIA: Programación Orientada a Eventos (MVC - Capa Modelo)
 *******************************************************************/

namespace Gestor_de_becas.Models
{
    internal class Beca
    {
        private int idBeca;
        private string nombreBeca;
        private decimal montoMensual;
        private int duracionMeses;
        private string rutaImagen;
        private bool estado;

        public int IdBeca
        {
            get { return idBeca; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID de la beca debe ser un número entero positivo.");
                idBeca = value;
            }
        }

        public string NombreBeca
        {
            get { return nombreBeca; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre de la beca no puede estar vacío.");
                nombreBeca = value.Trim();
            }
        }

        public decimal MontoMensual
        {
            get { return montoMensual; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El monto mensual no puede ser negativo.");
                montoMensual = value;
            }
        }

        public int DuracionMeses
        {
            get { return duracionMeses; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La duración en meses debe ser mayor a 0.");
                duracionMeses = value;
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_beca.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Beca()
        {
            idBeca = 0;
            nombreBeca = "Sin Asignar";
            montoMensual = 0.0m;
            duracionMeses = 1;
            rutaImagen = "default_beca.png";
            estado = true;
        }

        public Beca(int idBeca, string nombreBeca, decimal montoMensual, int duracionMeses, string rutaImagen, bool estado)
        {
            IdBeca = idBeca;
            NombreBeca = nombreBeca;
            MontoMensual = montoMensual;
            DuracionMeses = duracionMeses;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public decimal CalcularMontoTotal()
        {
            return montoMensual * duracionMeses;
        }

        public decimal CalcularMontoTotal(decimal porcentajeAjuste)
        {
            decimal montoBase = CalcularMontoTotal();
            return montoBase + (montoBase * (porcentajeAjuste / 100));
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Activa" : "Inactiva";
            return $"[Beca #{idBeca}] {nombreBeca} - Monto Mensual: ${montoMensual:N2} ({duracionMeses} meses) - Estado: {estatusTexto}";
        }
    }
}

