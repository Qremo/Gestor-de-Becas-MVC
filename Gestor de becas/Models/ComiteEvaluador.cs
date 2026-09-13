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
    internal class ComiteEvaluador
    {
        private int idComite;
        private string nombreComite;
        private string periodoAcademico;
        private int numeroIntegrantes;
        private string sedeReunion;
        private string rutaImagen;
        private bool estado;

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

        public string NombreComite
        {
            get { return nombreComite; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del comité no puede estar vacío.");
                nombreComite = value.Trim();
            }
        }

        public string PeriodoAcademico
        {
            get { return periodoAcademico; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El período académico no puede estar vacío.");
                periodoAcademico = value.Trim();
            }
        }

        public int NumeroIntegrantes
        {
            get { return numeroIntegrantes; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El número de integrantes debe ser mayor a 0.");
                numeroIntegrantes = value;
            }
        }

        public string SedeReunion
        {
            get { return sedeReunion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La sede de reunión no puede estar vacía.");
                sedeReunion = value.Trim();
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_comite.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public ComiteEvaluador()
        {
            idComite = 0;
            nombreComite = "Sin Asignar";
            periodoAcademico = "2026-A";
            numeroIntegrantes = 3;
            sedeReunion = "Sala Virtual";
            rutaImagen = "default_comite.png";
            estado = true;
        }

        public ComiteEvaluador(int idComite, string nombreComite, string periodoAcademico, int numeroIntegrantes, string sedeReunion, string rutaImagen, bool estado)
        {
            IdComite = idComite;
            NombreComite = nombreComite;
            PeriodoAcademico = periodoAcademico;
            NumeroIntegrantes = numeroIntegrantes;
            SedeReunion = sedeReunion;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public bool TieneQuorumMinimo()
        {
            return numeroIntegrantes >= 3 && estado;
        }

        public bool TieneQuorumMinimo(int quorumRequerido)
        {
            return numeroIntegrantes >= quorumRequerido && estado;
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Activo" : "Inactivo";
            return $"[Comité #{idComite}] {nombreComite} ({periodoAcademico}) | Integrantes: {numeroIntegrantes} | Sede: {sedeReunion} | Estado: {estatusTexto}";
        }
    }
}
