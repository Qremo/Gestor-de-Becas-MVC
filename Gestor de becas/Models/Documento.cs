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
    internal class Documento
    {
        private int idDocumento;
        private int idSolicitud;
        private string tipoDocumento;
        private string formatoArchivo;
        private DateTime fechaSubida;
        private string rutaImagen;
        private bool estado;

        public int IdDocumento
        {
            get { return idDocumento; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del documento debe ser un número entero positivo.");
                idDocumento = value;
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

        public string TipoDocumento
        {
            get { return tipoDocumento; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El tipo de documento no puede estar vacío.");
                tipoDocumento = value.Trim();
            }
        }

        public string FormatoArchivo
        {
            get { return formatoArchivo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El formato del archivo no puede estar vacío.");
                formatoArchivo = value.Trim().ToLower();
            }
        }

        public DateTime FechaSubida
        {
            get { return fechaSubida; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de subida no puede ser posterior a la fecha actual.");
                fechaSubida = value;
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_documento.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Documento()
        {
            idDocumento = 0;
            idSolicitud = 0;
            tipoDocumento = "Sin Especificar";
            formatoArchivo = "pdf";
            fechaSubida = DateTime.Now;
            rutaImagen = "default_documento.png";
            estado = true;
        }

        public Documento(int idDocumento, int idSolicitud, string tipoDocumento, string formatoArchivo, DateTime fechaSubida, string rutaImagen, bool estado)
        {
            IdDocumento = idDocumento;
            IdSolicitud = idSolicitud;
            TipoDocumento = tipoDocumento;
            FormatoArchivo = formatoArchivo;
            FechaSubida = fechaSubida;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public bool EsFormatoPermitido()
        {
            return formatoArchivo == "pdf" || formatoArchivo == "jpg" || formatoArchivo == "png";
        }

        public bool EsFormatoPermitido(string extensionEspecifica)
        {
            if (string.IsNullOrWhiteSpace(extensionEspecifica))
                return false;

            return formatoArchivo.Equals(extensionEspecifica.Trim().ToLower());
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Validado" : "Pendiente/Rechazado";
            return $"[Doc #{idDocumento}] {tipoDocumento} (.{formatoArchivo}) | Solicitud ID: {idSolicitud} | Subido: {fechaSubida:dd/MM/yyyy} | Estado: {estatusTexto}";
        }
    }
}
