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
    internal class Solicitud
    {
        private int idSolicitud;
        private string matriculaEstudiante;
        private int idBeca;
        private DateTime fechaSolicitud;
        private string observaciones;
        private string rutaImagen;
        private bool estado;

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

        public string MatriculaEstudiante
        {
            get { return matriculaEstudiante; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La matrícula del estudiante no puede estar vacía.");
                matriculaEstudiante = value.Trim();
            }
        }

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

        public DateTime FechaSolicitud
        {
            get { return fechaSolicitud; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de solicitud no puede ser posterior a la fecha actual.");
                fechaSolicitud = value;
            }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    observaciones = "Sin observaciones";
                else
                    observaciones = value.Trim();
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_comprobante.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Solicitud()
        {
            idSolicitud = 0;
            matriculaEstudiante = "000000000";
            idBeca = 0;
            fechaSolicitud = DateTime.Now;
            observaciones = "Sin observaciones";
            rutaImagen = "default_comprobante.png";
            estado = true;
        }

        public Solicitud(int idSolicitud, string matriculaEstudiante, int idBeca, DateTime fechaSolicitud, string observaciones, string rutaImagen, bool estado)
        {
            IdSolicitud = idSolicitud;
            MatriculaEstudiante = matriculaEstudiante;
            IdBeca = idBeca;
            FechaSolicitud = fechaSolicitud;
            Observaciones = observaciones;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public int CalcularDiasAntiguedad()
        {
            return (DateTime.Now - fechaSolicitud).Days;
        }

        public int CalcularDiasAntiguedad(DateTime fechaCorte)
        {
            if (fechaCorte < fechaSolicitud)
                return 0;

            return (fechaCorte - fechaSolicitud).Days;
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Pendiente/En Proceso" : "Finalizada/Cancelada";
            return $"[Solicitud #{idSolicitud}] Estudiante: {matriculaEstudiante} | Beca ID: {idBeca} | Fecha: {fechaSolicitud:dd/MM/yyyy} | Estado: {estatusTexto}";
        }
    }
}
