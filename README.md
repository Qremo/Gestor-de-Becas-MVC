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

Las clases representan las entidades del dominio de negocio aisladas completamente de la interfaz gráfica de usuario, aplicando principios fundamentales de la Programación Orientada a Eventos (POE) como encapsulamiento estricto, ocultamiento de información, sobrecarga de constructores y sobrecarga de métodos de negocio.



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


# Actividad 2.3: Diseño e Implementación de Vistas (View MVC) - Gestor de Becas

## Información General

* **Materia:** Programación Orientada a Eventos
* **Proyecto:** Sistema Gestor de Becas y Apoyos Estudiantiles
* **Equipo:** 6

## Integrantes

* GARCÍA COLMENARES, Arturo Misael
* HILARIO ANDRADE, Luis Ángel

---

## Descripción del Proyecto

Este repositorio contiene la implementación e integración de la **Capa Vista (View)** junto con la **Capa Modelo (Model)** para el sistema de gestión de becas, desarrollada bajo el patrón de arquitectura de software **MVC (Modelo-Vista-Controlador)** en C# con Windows Forms (.NET Core / .NET 8).

La interfaz gráfica se centraliza en la clase principal `FrmPrincipal`, la cual actúa como contenedor maestro utilizando un componente `TabControl` para articular la navegación entre los diferentes módulos funcionales del sistema de forma limpia y desacoplada de la lógica de negocio.

---

## Estructura de la Capa Vista (View)

La interfaz gráfica se organiza en **4 pestañas principales**:

1. **Estudiantes (`tbpEstudiantes`):** Captura de datos personales (matrícula, nombre, carrera, promedio, semestre), visualización tabular en `DataGridView` y panel de comandos CRUD.
2. **Becas (`tbpBecas`):** Módulo para la administración de apoyos institucionales (ID, nombre, tipo de beca, monto económico y cupos disponibles).
3. **Presupuesto (`tbpPresupuesto`):** Control y seguimiento de los fondos asignados y disponibles por periodo académico.
4. **Solicitudes (`tbpSolicitudes`):** Gestión de trámites de vinculación entre estudiantes y becas (ID solicitud, alumno elegible, apoyo solicitado, fecha y estado del trámite).

---

## Arquitectura y Estándares de Diseño

* **Organización Modular:** Uso riguroso de `GroupBox` para delimitar formularios de entrada respecto a las listas de consulta, y `Panel` alineado al borde inferior (`Dock = DockStyle.Bottom`) para la botonera de acciones.
* **Nomenclatura Estándar:** Aplicación de notación húngara reducida para la identificación única de controles (`txt`, `cmb`, `nud`, `dtp`, `dgv`, `btn`).
* **Operaciones CRUD Estandarizadas:** Cada módulo cuenta con una botonera de 6 acciones estándar:
  * `Agregar` (`btnCrear...`)
  * `Buscar` (`btnBuscar...`)
  * `Mostrar Todo` (`btnMostrar...`)
  * `Actualizar` (`btnActualizar...`)
  * `Inactivar` (`btnBorrar...` - Borrado Lógico)
  * `Eliminar Definitivo` (`btnDestruir...` - Borrado Físico)
* **Desacoplamiento MVC:** La Vista se limita a exponer controles y eventos hacia la capa Controlador sin ejecutar persistencia ni reglas de negocio dentro del código subyacente.
* 
