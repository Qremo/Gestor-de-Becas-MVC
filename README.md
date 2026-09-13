# Actividad 2.1:  Diseño e Implementación de Modelos(Clases) - Gestor de Becas

## Información General
* **Materia:** Programación Orientada a Eventos
* **Proyecto:** Sistema Gestor de Becas y Apoyos Estudiantiles
* **Equipo:** 6

## Integrantes
* GARCÍA COLMENARES, Arturo Misael
* HILARIO ANDRADE, Luis Ángel



## Descripción del Proyecto
Este repositorio contiene la implementación exclusiva de la **Capa Modelo (Model)** para el sistema de gestión de becas, desarrollada bajo el patrón de arquitectura software MVC (Modelo-Vista-Controlador) en C# con Windows Forms.

Las clases representan las entidades del dominio de negocio aisladas completamente de la interfaz gráfica de usuario, aplicando principios fundamentales de la Programación Orientada a Objetos (POO) como encapsulamiento estricto, ocultamiento de información, sobrecarga de constructores y sobrecarga de métodos de negocio.



## Estructura de la Capa Modelo (`Models`)
El sistema integra 10 clases de modelo físicas:

1. **`Administrador.cs`**: Gestión y credenciales del personal administrativo.
2. **`Estudiante.cs`**: Registro de alumnos solicitantes y validación de promedio académico.
3. **`Beca.cs`**: Catálogo de apoyos, presupuestos por beca y requisitos.
4. **`Solicitud.cs`**: Control del trámite de aplicación y asignación de folio.
5. **`EstudioSocioeconomico.cs`**: Evaluación de ingresos y nivel de vulnerabilidad del aspirante.
6. **`Documento.cs`**: Expediente digital y validación de archivos adjuntos.
7. **`ComiteEvaluador.cs`**: Integrantes del jurado revisor y cuerpo dictaminador.
8. **`Dictamen.cs`**: Resolución final de aprobación o rechazo de solicitudes.
9. **`Pago.cs`**: Registro de ministraciones, desembolsos y depósitos realizados.
10. **`Presupuesto.cs`**: Control del techo financiero anual y saldos disponibles.

*Todas las entidades incluyen propiedades de control `RutaImagen` (para interfaz gráfica) y `Estado` (estatus activo/inactivo).*



## Requisitos del Sistema
* **Entorno de Desarrollo:** Visual Studio 2022 (o superior)
* **Plataforma:** .NET Framework / .NET Core para Windows Forms
* **Lenguaje:** C#



## Instrucciones para Ejecutar las Pruebas

1. **Clonar o descargar el repositorio.**
2. **Abrir la solución:**
   Abre el archivo `.sln` del proyecto en **Visual Studio**.
3. **Compilar la solución:**
   Presiona `Ctrl + Mayús + B` para verificar que no existan errores de sintaxis.
4. **Ejecutar las pruebas:**
   Presiona `F5`. El evento de carga de `Form1.cs` instanciará objetos de prueba y desplegará un `MessageBox` mostrando el correcto funcionamiento del modelo y la captura de excepciones con `try-catch`.
