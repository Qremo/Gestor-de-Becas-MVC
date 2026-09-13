using System;
using System.Collections.Generic;
using System.Numerics;
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
    internal class Administrador
    {
        private int idAdmin;
        private string nombre;
        private string correo;
        private string claveAcceso;
        private string nivelPermiso;
        private string rutaImagen;
        private bool estado;

        public int IdAdmin
        {
            get { return idAdmin; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del administrador debe ser un número entero positivo.");
                idAdmin = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del administrador no puede estar vacío.");
                nombre = value.Trim();
            }
        }

        public string Correo
        {
            get { return correo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("Debe proporcionar un correo electrónico válido.");
                correo = value.Trim().ToLower();
            }
        }

        public string ClaveAcceso
        {
            get { return claveAcceso; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new ArgumentException("La clave de acceso debe tener al menos 6 caracteres.");
                claveAcceso = value;
            }
        }

        public string NivelPermiso
        {
            get { return nivelPermiso; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nivel de permiso no puede estar vacío.");
                nivelPermiso = value.Trim();
            }
        }

        public string RutaImagen
        {
            get { return rutaImagen; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    rutaImagen = "default_admin.png";
                else
                    rutaImagen = value.Trim();
            }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Administrador()
        {
            idAdmin = 0;
            nombre = "Sin Nombre";
            correo = "admin@sistema.org";
            claveAcceso = "123456";
            nivelPermiso = "General";
            rutaImagen = "default_admin.png";
            estado = true;
        }

        public Administrador(int idAdmin, string nombre, string correo, string claveAcceso, string nivelPermiso, string rutaImagen, bool estado)
        {
            IdAdmin = idAdmin;
            Nombre = nombre;
            Correo = correo;
            ClaveAcceso = claveAcceso;
            NivelPermiso = nivelPermiso;
            RutaImagen = rutaImagen;
            Estado = estado;
        }

        public bool ValidarSeguridadClave()
        {
            return claveAcceso != null && claveAcceso.Length >= 8;
        }

        public bool ValidarSeguridadClave(string intentoClave)
        {
            if (string.IsNullOrEmpty(intentoClave))
                return false;

            return claveAcceso == intentoClave;
        }

        public override string ToString()
        {
            string estatusTexto = estado ? "Activo" : "Inactivo";
            return $"[Admin #{idAdmin}] {nombre} | Correo: {correo} | Nivel: {nivelPermiso} | Estado: {estatusTexto}";
        }
}

}



