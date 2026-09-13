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
    internal class Pago
    {
        private int idPago;
        private int idSolicitud;
        private decimal monto;
        private DateTime fechaPago;
        private string metodoPago;
        private string rutaImagen;
        private bool estado;

        public int IdPago
        {
            get { return idPago; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del pago debe ser un número entero positivo.");
                idPago = value;
            }
        }

        public int IdSolicitud
        {
            get { return idSolicitud; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID de la solicitud debe ser un número entero positivo.");
                idSolicitud = value;
            }
        }

        public decimal Monto
        {
            get { return monto; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El monto del pago debe ser mayor a cero.");
                monto = value;
            }
        }

        public DateTime FechaPago
        {
            get { return fechaPago; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de pago no puede ser posterior a la fecha actual.");
                fechaPago = value;
            }
        }

        public string MetodoPago
        {
            get { return metodoPago; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El método de pago no puede estar vacío.");
                metodoPago = value.Trim();
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_pago.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Pago()
        {
            idPago = 0;
            idSolicitud = 0;
            monto = 0.0m;
            fechaPago = DateTime.Now;
            metodoPago = "Transferencia";
            rutaImagen = "default_pago.png";
            estado = true;
        }

        public Pago(int idPago, int idSolicitud, decimal monto, DateTime fechaPago, string metodoPago, string rutaImagen, bool estado)
        {
            IdPago = idPago;
            IdSolicitud = idSolicitud;
            Monto = monto;
            FechaPago = fechaPago;
            MetodoPago = metodoPago;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public bool EsPagoReciente()
        {
            return (DateTime.Now - fechaPago).TotalDays <= 30 && estado;
        }

        public bool EsPagoReciente(int diasLimite)
        {
            return (DateTime.Now - fechaPago).TotalDays <= diasLimite && estado;
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Procesado" : "Cancelado";
            return $"[Pago #{idPago}] Solicitud ID: {idSolicitud} | Monto: ${monto:N2} | Método: {metodoPago} | Fecha: {fechaPago:dd/MM/yyyy} | Estado: {estatusTexto}";
        }
    }
}
