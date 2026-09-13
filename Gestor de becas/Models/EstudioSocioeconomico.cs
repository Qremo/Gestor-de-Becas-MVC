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
    internal class EstudioSocioeconomico
    {
        private int idEstudio;
        private string matriculaEstudiante;
        private decimal ingresoMensualFamiliar;
        private int numeroDependientes;
        private string dictamenSocioeconomico;
        private string rutaImagen;
        private bool estado;

        public int IdEstudio
        {
            get { return idEstudio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del estudio socioeconómico debe ser un número entero positivo.");
                idEstudio = value;
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

        public decimal IngresoMensualFamiliar
        {
            get { return ingresoMensualFamiliar; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El ingreso mensual familiar no puede ser negativo.");
                ingresoMensualFamiliar = value;
            }
        }

        public int NumeroDependientes
        {
            get { return numeroDependientes; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("El número de dependientes debe ser al menos 1.");
                numeroDependientes = value;
            }
        }

        public string DictamenSocioeconomico
        {
            get { return dictamenSocioeconomico; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El dictamen socioeconómico no puede estar vacío.");
                dictamenSocioeconomico = value.Trim();
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_estudio.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public EstudioSocioeconomico()
        {
            idEstudio = 0;
            matriculaEstudiante = "000000000";
            ingresoMensualFamiliar = 0.0m;
            numeroDependientes = 1;
            dictamenSocioeconomico = "Pendiente";
            rutaImagen = "default_estudio.png";
            estado = true;
        }

        public EstudioSocioeconomico(int idEstudio, string matriculaEstudiante, decimal ingresoMensualFamiliar, int numeroDependientes, string dictamenSocioeconomico, string rutaImagen, bool estado)
        {
            IdEstudio = idEstudio;
            MatriculaEstudiante = matriculaEstudiante;
            IngresoMensualFamiliar = ingresoMensualFamiliar;
            NumeroDependientes = numeroDependientes;
            DictamenSocioeconomico = dictamenSocioeconomico;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public decimal CalcularIngresoPerCapita()
        {
            return ingresoMensualFamiliar / numeroDependientes;
        }

        public decimal CalcularIngresoPerCapita(decimal deduccionGastosMedicos)
        {
            decimal ingresoAjustado = ingresoMensualFamiliar - deduccionGastosMedicos;
            if (ingresoAjustado < 0)
                ingresoAjustado = 0;

            return ingresoAjustado / numeroDependientes;
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Válido" : "Invalidad";
            return $"[Estudio #{idEstudio}] Estudiante: {matriculaEstudiante} | Per Cápita: ${CalcularIngresoPerCapita():N2} | Dictamen: {dictamenSocioeconomico} | Estado: {estatusTexto}";
        }
    }
}
