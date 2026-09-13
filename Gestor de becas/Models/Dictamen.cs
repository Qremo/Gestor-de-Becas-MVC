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
    internal class Dictamen
    {
        private int idDictamen;
        private int idSolicitud;
        private int idComite;
        private string resultado;
        private DateTime fechaDictamen;
        private string rutaImagen;
        private bool estado;

        public int IdDictamen
        {
            get { return idDictamen; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del dictamen debe ser un número entero positivo.");
                idDictamen = value;
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

        public int IdComite
        {
            get { return idComite; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del comité debe ser un número entero positivo.");
                idComite = value;
            }
        }

        public string Resultado
        {
            get { return resultado; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El resultado del dictamen no puede estar vacío.");
                resultado = value.Trim();
            }
        }

        public DateTime FechaDictamen
        {
            get { return fechaDictamen; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha del dictamen no puede ser posterior a la fecha actual.");
                fechaDictamen = value;
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_dictamen.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Dictamen()
        {
            idDictamen = 0;
            idSolicitud = 0;
            idComite = 0;
            resultado = "Pendiente";
            fechaDictamen = DateTime.Now;
            rutaImagen = "default_dictamen.png";
            estado = true;
        }

        public Dictamen(int idDictamen, int idSolicitud, int idComite, string resultado, DateTime fechaDictamen, string rutaImagen, bool estado)
        {
            IdDictamen = idDictamen;
            IdSolicitud = idSolicitud;
            IdComite = idComite;
            Resultado = resultado;
            FechaDictamen = fechaDictamen;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public bool EsAprobado()
        {
            return resultado.Equals("Aprobado", StringComparison.OrdinalIgnoreCase);
        }

        public bool EsAprobado(string criterioAprobacion)
        {
            if (string.IsNullOrWhiteSpace(criterioAprobacion))
                return false;

            return resultado.Equals(criterioAprobacion.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Oficial" : "Anulado";
            return $"[Dictamen #{idDictamen}] Solicitud ID: {idSolicitud} | Resultado: {resultado} | Fecha: {fechaDictamen:dd/MM/yyyy} | Estado: {estatusTexto}";
        }
    }
}
