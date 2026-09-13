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
    internal class Estudiante
    {
        private string matricula;
        private string nombre;
        private string carrera;
        private double promedio;
        private int semestre;
        private string rutaImagen;
        private bool estado;

        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La matrícula del estudiante no puede estar vacía.");
                matricula = value.Trim();
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del estudiante no puede estar vacío.");
                nombre = value.Trim();
            }
        }

        public string Carrera
        {
            get { return carrera; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La carrera no puede estar vacía.");
                carrera = value.Trim();
            }
        }

        public double Promedio
        {
            get { return promedio; }
            set
            {
                if (value < 0.0 || value > 100.0)
                    throw new ArgumentException("El promedio debe estar en un rango de 0 a 100.");
                promedio = value;
            }
        }

        public int Semestre
        {
            get { return semestre; }
            set
            {
                if (value <= 0 || value > 12)
                    throw new ArgumentException("El semestre debe ser un número entre 1 y 12.");
                semestre = value;
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_estudiante.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Estudiante()
        {
            matricula = "000000000";
            nombre = "Sin Nombre";
            carrera = "No Asignada";
            promedio = 0.0;
            semestre = 1;
            rutaImagen = "default_estudiante.png";
            estado = true;
        }

        public Estudiante(string matricula, string nombre, string carrera, double promedio, int semestre, string rutaImagen, bool estado)
        {
            Matricula = matricula;
            Nombre = nombre;
            Carrera = carrera;
            Promedio = promedio;
            Semestre = semestre;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public bool EsElegibleParaBeca()
        {
            return promedio >= 80.0 && estado;
        }

        public bool EsElegibleParaBeca(double promedioMinimoRequerido)
        {
            return promedio >= promedioMinimoRequerido && estado;
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Activo" : "Inactivo";
            return $"[{matricula}] {nombre} | {carrera} ({semestre}° Sem) - Promedio: {promedio:F1} | Estado: {estatusTexto}";
        }
    }
}

