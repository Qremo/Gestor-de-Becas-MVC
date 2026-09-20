namespace Gestor_de_becas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcPrincipal = new TabControl();
            tbpEstudiantes = new TabPage();
            gbxListaEstudiantes = new GroupBox();
            dgvEstudiantes = new DataGridView();
            gbxDatosEstudiante = new GroupBox();
            txtNombreEstudiantes = new TextBox();
            txtMatriIdentificador = new TextBox();
            nudSemestreEstudiante = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            cmbCarreraEstudiante = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            lblCarreraEstudiante = new Label();
            lblNombreEstudiante = new Label();
            lblMatrIdentificador = new Label();
            pnlBotonesEstudiante = new Panel();
            btnDestruirEstudiante = new Button();
            btnCrearEstudiante = new Button();
            btnBorrarEstudiante = new Button();
            btnBuscarEstudiante = new Button();
            btnActualizarEstudiante = new Button();
            btnMostrarEstudiantes = new Button();
            tbpBecas = new TabPage();
            gbxListaBecas = new GroupBox();
            dataGridView1 = new DataGridView();
            gbxDatosBeca = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nudCupoBeca = new NumericUpDown();
            nudMontoBeca = new NumericUpDown();
            cmbTipoBeca = new ComboBox();
            txtNombreBeca = new TextBox();
            txtIdBeca = new TextBox();
            pnlBotonesBeca = new Panel();
            btnBorrarBeca = new Button();
            btnDestruirBeca = new Button();
            btnBuscarBeca = new Button();
            btnActualizarBeca = new Button();
            btnMostrarBecas = new Button();
            btnCrearBeca = new Button();
            tbpPresupuesto = new TabPage();
            gbxListaPresupuestos = new GroupBox();
            dgvPresupuesto = new DataGridView();
            gbxDatosPresupuesto = new GroupBox();
            lblPeriodoPresupuesto = new Label();
            lblMontoDisponible = new Label();
            lblMontoAsignado = new Label();
            lblIdPresupuesto = new Label();
            cmbPeriodoPresupuesto = new ComboBox();
            nudMontoDisponible = new NumericUpDown();
            nudMontoAsignado = new NumericUpDown();
            txtIdPresupuesto = new TextBox();
            pnlBotonesPresupuesto = new Panel();
            btnBorrarPresupuesto = new Button();
            btnDestruirPresupuesto = new Button();
            btnBuscarPresupuesto = new Button();
            btnActualizarPresupuesto = new Button();
            btnMostrarPresupuestos = new Button();
            btnCrearPresupuesto = new Button();
            tbpSolicitudes = new TabPage();
            gbxListaSolicitudes = new GroupBox();
            dgvSolicitudes = new DataGridView();
            gbxDatosSolicitud = new GroupBox();
            label8 = new Label();
            cmbEstadoSolicitud = new ComboBox();
            dtpFechaSolicitud = new DateTimePicker();
            cmbBecaSolicitud = new ComboBox();
            cmbEstudianteSolicitud = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            txtIdSolicitud = new TextBox();
            pnlBotonesSolicitud = new Panel();
            btnBorrarSolicitud = new Button();
            btnDestruirSolicitud = new Button();
            btnBuscarSolicitud = new Button();
            btnActualizarSolicitud = new Button();
            btnMostrarSolicitudes = new Button();
            btnCrearSolicitud = new Button();
            tbcPrincipal.SuspendLayout();
            tbpEstudiantes.SuspendLayout();
            gbxListaEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            gbxDatosEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSemestreEstudiante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            pnlBotonesEstudiante.SuspendLayout();
            tbpBecas.SuspendLayout();
            gbxListaBecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbxDatosBeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupoBeca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoBeca).BeginInit();
            pnlBotonesBeca.SuspendLayout();
            tbpPresupuesto.SuspendLayout();
            gbxListaPresupuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuesto).BeginInit();
            gbxDatosPresupuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoDisponible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoAsignado).BeginInit();
            pnlBotonesPresupuesto.SuspendLayout();
            tbpSolicitudes.SuspendLayout();
            gbxListaSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            gbxDatosSolicitud.SuspendLayout();
            pnlBotonesSolicitud.SuspendLayout();
            SuspendLayout();
            // 
            // tbcPrincipal
            // 
            tbcPrincipal.Controls.Add(tbpEstudiantes);
            tbcPrincipal.Controls.Add(tbpBecas);
            tbcPrincipal.Controls.Add(tbpPresupuesto);
            tbcPrincipal.Controls.Add(tbpSolicitudes);
            tbcPrincipal.Dock = DockStyle.Fill;
            tbcPrincipal.Location = new Point(0, 0);
            tbcPrincipal.Name = "tbcPrincipal";
            tbcPrincipal.SelectedIndex = 0;
            tbcPrincipal.Size = new Size(1008, 689);
            tbcPrincipal.TabIndex = 0;
            // 
            // tbpEstudiantes
            // 
            tbpEstudiantes.Controls.Add(gbxListaEstudiantes);
            tbpEstudiantes.Controls.Add(gbxDatosEstudiante);
            tbpEstudiantes.Controls.Add(pnlBotonesEstudiante);
            tbpEstudiantes.Location = new Point(4, 24);
            tbpEstudiantes.Name = "tbpEstudiantes";
            tbpEstudiantes.Padding = new Padding(3);
            tbpEstudiantes.Size = new Size(1000, 661);
            tbpEstudiantes.TabIndex = 0;
            tbpEstudiantes.Text = "Estudiantes";
            tbpEstudiantes.UseVisualStyleBackColor = true;
            // 
            // gbxListaEstudiantes
            // 
            gbxListaEstudiantes.Controls.Add(dgvEstudiantes);
            gbxListaEstudiantes.Location = new Point(459, 45);
            gbxListaEstudiantes.Name = "gbxListaEstudiantes";
            gbxListaEstudiantes.Size = new Size(500, 480);
            gbxListaEstudiantes.TabIndex = 2;
            gbxListaEstudiantes.TabStop = false;
            gbxListaEstudiantes.Text = "Listado de Estudiantes Registrados";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Dock = DockStyle.Fill;
            dgvEstudiantes.Location = new Point(3, 19);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Size = new Size(494, 458);
            dgvEstudiantes.TabIndex = 0;
            // 
            // gbxDatosEstudiante
            // 
            gbxDatosEstudiante.Controls.Add(txtNombreEstudiantes);
            gbxDatosEstudiante.Controls.Add(txtMatriIdentificador);
            gbxDatosEstudiante.Controls.Add(nudSemestreEstudiante);
            gbxDatosEstudiante.Controls.Add(numericUpDown1);
            gbxDatosEstudiante.Controls.Add(cmbCarreraEstudiante);
            gbxDatosEstudiante.Controls.Add(label5);
            gbxDatosEstudiante.Controls.Add(label4);
            gbxDatosEstudiante.Controls.Add(lblCarreraEstudiante);
            gbxDatosEstudiante.Controls.Add(lblNombreEstudiante);
            gbxDatosEstudiante.Controls.Add(lblMatrIdentificador);
            gbxDatosEstudiante.Location = new Point(3, 45);
            gbxDatosEstudiante.Name = "gbxDatosEstudiante";
            gbxDatosEstudiante.Size = new Size(450, 480);
            gbxDatosEstudiante.TabIndex = 1;
            gbxDatosEstudiante.TabStop = false;
            gbxDatosEstudiante.Text = "Datos del Estudiante";
            // 
            // txtNombreEstudiantes
            // 
            txtNombreEstudiantes.Location = new Point(143, 113);
            txtNombreEstudiantes.Name = "txtNombreEstudiantes";
            txtNombreEstudiantes.Size = new Size(100, 23);
            txtNombreEstudiantes.TabIndex = 10;
            // 
            // txtMatriIdentificador
            // 
            txtMatriIdentificador.Location = new Point(143, 59);
            txtMatriIdentificador.Name = "txtMatriIdentificador";
            txtMatriIdentificador.Size = new Size(100, 23);
            txtMatriIdentificador.TabIndex = 9;
            // 
            // nudSemestreEstudiante
            // 
            nudSemestreEstudiante.Location = new Point(99, 367);
            nudSemestreEstudiante.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            nudSemestreEstudiante.Name = "nudSemestreEstudiante";
            nudSemestreEstudiante.Size = new Size(120, 23);
            nudSemestreEstudiante.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(99, 298);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // cmbCarreraEstudiante
            // 
            cmbCarreraEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarreraEstudiante.FormattingEnabled = true;
            cmbCarreraEstudiante.Items.AddRange(new object[] { "Ingeniería en Computación", "Ingeniería en Nanotecnología", "Derecho", "Gestor de Empresas" });
            cmbCarreraEstudiante.Location = new Point(6, 185);
            cmbCarreraEstudiante.Name = "cmbCarreraEstudiante";
            cmbCarreraEstudiante.Size = new Size(337, 23);
            cmbCarreraEstudiante.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 369);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Semestre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 298);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Promedio:";
            // 
            // lblCarreraEstudiante
            // 
            lblCarreraEstudiante.AutoSize = true;
            lblCarreraEstudiante.Location = new Point(6, 167);
            lblCarreraEstudiante.Name = "lblCarreraEstudiante";
            lblCarreraEstudiante.Size = new Size(48, 15);
            lblCarreraEstudiante.TabIndex = 2;
            lblCarreraEstudiante.Text = "Carrera:";
            // 
            // lblNombreEstudiante
            // 
            lblNombreEstudiante.AutoSize = true;
            lblNombreEstudiante.Location = new Point(6, 116);
            lblNombreEstudiante.Name = "lblNombreEstudiante";
            lblNombreEstudiante.Size = new Size(110, 15);
            lblNombreEstudiante.TabIndex = 1;
            lblNombreEstudiante.Text = "Nombre Completo:";
            // 
            // lblMatrIdentificador
            // 
            lblMatrIdentificador.AutoSize = true;
            lblMatrIdentificador.Location = new Point(6, 62);
            lblMatrIdentificador.Name = "lblMatrIdentificador";
            lblMatrIdentificador.Size = new Size(60, 15);
            lblMatrIdentificador.TabIndex = 0;
            lblMatrIdentificador.Text = "Matrícula:";
            // 
            // pnlBotonesEstudiante
            // 
            pnlBotonesEstudiante.Controls.Add(btnDestruirEstudiante);
            pnlBotonesEstudiante.Controls.Add(btnCrearEstudiante);
            pnlBotonesEstudiante.Controls.Add(btnBorrarEstudiante);
            pnlBotonesEstudiante.Controls.Add(btnBuscarEstudiante);
            pnlBotonesEstudiante.Controls.Add(btnActualizarEstudiante);
            pnlBotonesEstudiante.Controls.Add(btnMostrarEstudiantes);
            pnlBotonesEstudiante.Dock = DockStyle.Bottom;
            pnlBotonesEstudiante.Location = new Point(3, 598);
            pnlBotonesEstudiante.Name = "pnlBotonesEstudiante";
            pnlBotonesEstudiante.Size = new Size(994, 60);
            pnlBotonesEstudiante.TabIndex = 0;
            // 
            // btnDestruirEstudiante
            // 
            btnDestruirEstudiante.Location = new Point(825, 1);
            btnDestruirEstudiante.Name = "btnDestruirEstudiante";
            btnDestruirEstudiante.Size = new Size(142, 46);
            btnDestruirEstudiante.TabIndex = 14;
            btnDestruirEstudiante.Text = "Eliminar Definitivo";
            btnDestruirEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnCrearEstudiante
            // 
            btnCrearEstudiante.Location = new Point(0, 0);
            btnCrearEstudiante.Name = "btnCrearEstudiante";
            btnCrearEstudiante.Size = new Size(142, 46);
            btnCrearEstudiante.TabIndex = 9;
            btnCrearEstudiante.Text = "Agregar";
            btnCrearEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnBorrarEstudiante
            // 
            btnBorrarEstudiante.Location = new Point(655, 1);
            btnBorrarEstudiante.Name = "btnBorrarEstudiante";
            btnBorrarEstudiante.Size = new Size(142, 46);
            btnBorrarEstudiante.TabIndex = 13;
            btnBorrarEstudiante.Text = "Inactivar";
            btnBorrarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnBuscarEstudiante
            // 
            btnBuscarEstudiante.Location = new Point(162, 0);
            btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            btnBuscarEstudiante.Size = new Size(130, 46);
            btnBuscarEstudiante.TabIndex = 10;
            btnBuscarEstudiante.Text = "Buscar";
            btnBuscarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEstudiante
            // 
            btnActualizarEstudiante.Location = new Point(489, 1);
            btnActualizarEstudiante.Name = "btnActualizarEstudiante";
            btnActualizarEstudiante.Size = new Size(142, 46);
            btnActualizarEstudiante.TabIndex = 12;
            btnActualizarEstudiante.Text = "Actualizar";
            btnActualizarEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnMostrarEstudiantes
            // 
            btnMostrarEstudiantes.Location = new Point(317, 1);
            btnMostrarEstudiantes.Name = "btnMostrarEstudiantes";
            btnMostrarEstudiantes.Size = new Size(145, 45);
            btnMostrarEstudiantes.TabIndex = 11;
            btnMostrarEstudiantes.Text = "Mostrar Todo";
            btnMostrarEstudiantes.UseVisualStyleBackColor = true;
            // 
            // tbpBecas
            // 
            tbpBecas.Controls.Add(gbxListaBecas);
            tbpBecas.Controls.Add(gbxDatosBeca);
            tbpBecas.Controls.Add(pnlBotonesBeca);
            tbpBecas.Location = new Point(4, 24);
            tbpBecas.Name = "tbpBecas";
            tbpBecas.Padding = new Padding(3);
            tbpBecas.Size = new Size(1000, 661);
            tbpBecas.TabIndex = 1;
            tbpBecas.Text = "Becas";
            tbpBecas.UseVisualStyleBackColor = true;
            // 
            // gbxListaBecas
            // 
            gbxListaBecas.Controls.Add(dataGridView1);
            gbxListaBecas.Location = new Point(482, 67);
            gbxListaBecas.Name = "gbxListaBecas";
            gbxListaBecas.Size = new Size(490, 458);
            gbxListaBecas.TabIndex = 2;
            gbxListaBecas.TabStop = false;
            gbxListaBecas.Text = "Listado de Becas Registradas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(484, 436);
            dataGridView1.TabIndex = 0;
            // 
            // gbxDatosBeca
            // 
            gbxDatosBeca.Controls.Add(label7);
            gbxDatosBeca.Controls.Add(label6);
            gbxDatosBeca.Controls.Add(label3);
            gbxDatosBeca.Controls.Add(label2);
            gbxDatosBeca.Controls.Add(label1);
            gbxDatosBeca.Controls.Add(nudCupoBeca);
            gbxDatosBeca.Controls.Add(nudMontoBeca);
            gbxDatosBeca.Controls.Add(cmbTipoBeca);
            gbxDatosBeca.Controls.Add(txtNombreBeca);
            gbxDatosBeca.Controls.Add(txtIdBeca);
            gbxDatosBeca.Location = new Point(27, 67);
            gbxDatosBeca.Name = "gbxDatosBeca";
            gbxDatosBeca.Size = new Size(438, 458);
            gbxDatosBeca.TabIndex = 1;
            gbxDatosBeca.TabStop = false;
            gbxDatosBeca.Text = "Datos de la Beca";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 404);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 9;
            label7.Text = "Cupo Disponible:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 331);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "Monto ($):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 249);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 7;
            label3.Text = "Tipo de Beca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 153);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre Beca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "ID Beca:";
            // 
            // nudCupoBeca
            // 
            nudCupoBeca.Location = new Point(175, 396);
            nudCupoBeca.Name = "nudCupoBeca";
            nudCupoBeca.Size = new Size(100, 23);
            nudCupoBeca.TabIndex = 4;
            // 
            // nudMontoBeca
            // 
            nudMontoBeca.DecimalPlaces = 2;
            nudMontoBeca.Location = new Point(175, 323);
            nudMontoBeca.Name = "nudMontoBeca";
            nudMontoBeca.Size = new Size(100, 23);
            nudMontoBeca.TabIndex = 3;
            // 
            // cmbTipoBeca
            // 
            cmbTipoBeca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoBeca.FormattingEnabled = true;
            cmbTipoBeca.Location = new Point(175, 241);
            cmbTipoBeca.Name = "cmbTipoBeca";
            cmbTipoBeca.Size = new Size(100, 23);
            cmbTipoBeca.TabIndex = 2;
            // 
            // txtNombreBeca
            // 
            txtNombreBeca.Location = new Point(175, 145);
            txtNombreBeca.Name = "txtNombreBeca";
            txtNombreBeca.Size = new Size(100, 23);
            txtNombreBeca.TabIndex = 1;
            // 
            // txtIdBeca
            // 
            txtIdBeca.Location = new Point(175, 53);
            txtIdBeca.Name = "txtIdBeca";
            txtIdBeca.Size = new Size(100, 23);
            txtIdBeca.TabIndex = 0;
            // 
            // pnlBotonesBeca
            // 
            pnlBotonesBeca.Controls.Add(btnBorrarBeca);
            pnlBotonesBeca.Controls.Add(btnDestruirBeca);
            pnlBotonesBeca.Controls.Add(btnBuscarBeca);
            pnlBotonesBeca.Controls.Add(btnActualizarBeca);
            pnlBotonesBeca.Controls.Add(btnMostrarBecas);
            pnlBotonesBeca.Controls.Add(btnCrearBeca);
            pnlBotonesBeca.Dock = DockStyle.Bottom;
            pnlBotonesBeca.Location = new Point(3, 598);
            pnlBotonesBeca.Name = "pnlBotonesBeca";
            pnlBotonesBeca.Size = new Size(994, 60);
            pnlBotonesBeca.TabIndex = 0;
            // 
            // btnBorrarBeca
            // 
            btnBorrarBeca.Location = new Point(669, 3);
            btnBorrarBeca.Name = "btnBorrarBeca";
            btnBorrarBeca.Size = new Size(142, 46);
            btnBorrarBeca.TabIndex = 15;
            btnBorrarBeca.Text = "Inactivar";
            btnBorrarBeca.UseVisualStyleBackColor = true;
            // 
            // btnDestruirBeca
            // 
            btnDestruirBeca.Location = new Point(827, 3);
            btnDestruirBeca.Name = "btnDestruirBeca";
            btnDestruirBeca.Size = new Size(142, 46);
            btnDestruirBeca.TabIndex = 14;
            btnDestruirBeca.Text = "Eliminar Definitivo";
            btnDestruirBeca.UseVisualStyleBackColor = true;
            // 
            // btnBuscarBeca
            // 
            btnBuscarBeca.Location = new Point(169, 3);
            btnBuscarBeca.Name = "btnBuscarBeca";
            btnBuscarBeca.Size = new Size(142, 46);
            btnBuscarBeca.TabIndex = 13;
            btnBuscarBeca.Text = "Buscar";
            btnBuscarBeca.UseVisualStyleBackColor = true;
            // 
            // btnActualizarBeca
            // 
            btnActualizarBeca.Location = new Point(506, 3);
            btnActualizarBeca.Name = "btnActualizarBeca";
            btnActualizarBeca.Size = new Size(142, 46);
            btnActualizarBeca.TabIndex = 12;
            btnActualizarBeca.Text = "Actualizar";
            btnActualizarBeca.UseVisualStyleBackColor = true;
            // 
            // btnMostrarBecas
            // 
            btnMostrarBecas.Location = new Point(337, 3);
            btnMostrarBecas.Name = "btnMostrarBecas";
            btnMostrarBecas.Size = new Size(142, 46);
            btnMostrarBecas.TabIndex = 11;
            btnMostrarBecas.Text = "Mostrar Todo";
            btnMostrarBecas.UseVisualStyleBackColor = true;
            // 
            // btnCrearBeca
            // 
            btnCrearBeca.Location = new Point(5, 3);
            btnCrearBeca.Name = "btnCrearBeca";
            btnCrearBeca.Size = new Size(142, 46);
            btnCrearBeca.TabIndex = 10;
            btnCrearBeca.Text = "Agregar";
            btnCrearBeca.UseVisualStyleBackColor = true;
            // 
            // tbpPresupuesto
            // 
            tbpPresupuesto.Controls.Add(gbxListaPresupuestos);
            tbpPresupuesto.Controls.Add(gbxDatosPresupuesto);
            tbpPresupuesto.Controls.Add(pnlBotonesPresupuesto);
            tbpPresupuesto.Location = new Point(4, 24);
            tbpPresupuesto.Name = "tbpPresupuesto";
            tbpPresupuesto.Size = new Size(1000, 661);
            tbpPresupuesto.TabIndex = 2;
            tbpPresupuesto.Text = "Presupuesto";
            tbpPresupuesto.UseVisualStyleBackColor = true;
            // 
            // gbxListaPresupuestos
            // 
            gbxListaPresupuestos.Controls.Add(dgvPresupuesto);
            gbxListaPresupuestos.Location = new Point(482, 16);
            gbxListaPresupuestos.Name = "gbxListaPresupuestos";
            gbxListaPresupuestos.Size = new Size(490, 458);
            gbxListaPresupuestos.TabIndex = 2;
            gbxListaPresupuestos.TabStop = false;
            gbxListaPresupuestos.Text = "Listado de Presupuestos";
            // 
            // dgvPresupuesto
            // 
            dgvPresupuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuesto.Dock = DockStyle.Fill;
            dgvPresupuesto.Location = new Point(3, 19);
            dgvPresupuesto.Name = "dgvPresupuesto";
            dgvPresupuesto.Size = new Size(484, 436);
            dgvPresupuesto.TabIndex = 0;
            // 
            // gbxDatosPresupuesto
            // 
            gbxDatosPresupuesto.Controls.Add(lblPeriodoPresupuesto);
            gbxDatosPresupuesto.Controls.Add(lblMontoDisponible);
            gbxDatosPresupuesto.Controls.Add(lblMontoAsignado);
            gbxDatosPresupuesto.Controls.Add(lblIdPresupuesto);
            gbxDatosPresupuesto.Controls.Add(cmbPeriodoPresupuesto);
            gbxDatosPresupuesto.Controls.Add(nudMontoDisponible);
            gbxDatosPresupuesto.Controls.Add(nudMontoAsignado);
            gbxDatosPresupuesto.Controls.Add(txtIdPresupuesto);
            gbxDatosPresupuesto.Location = new Point(27, 16);
            gbxDatosPresupuesto.Name = "gbxDatosPresupuesto";
            gbxDatosPresupuesto.Size = new Size(438, 458);
            gbxDatosPresupuesto.TabIndex = 1;
            gbxDatosPresupuesto.TabStop = false;
            gbxDatosPresupuesto.Text = "Datos del Presupuesto";
            // 
            // lblPeriodoPresupuesto
            // 
            lblPeriodoPresupuesto.AutoSize = true;
            lblPeriodoPresupuesto.Location = new Point(16, 331);
            lblPeriodoPresupuesto.Name = "lblPeriodoPresupuesto";
            lblPeriodoPresupuesto.Size = new Size(51, 15);
            lblPeriodoPresupuesto.TabIndex = 6;
            lblPeriodoPresupuesto.Text = "Periodo:";
            // 
            // lblMontoDisponible
            // 
            lblMontoDisponible.AutoSize = true;
            lblMontoDisponible.Location = new Point(16, 249);
            lblMontoDisponible.Name = "lblMontoDisponible";
            lblMontoDisponible.Size = new Size(122, 15);
            lblMontoDisponible.TabIndex = 4;
            lblMontoDisponible.Text = "Monto Disponible ($):";
            // 
            // lblMontoAsignado
            // 
            lblMontoAsignado.AutoSize = true;
            lblMontoAsignado.Location = new Point(16, 153);
            lblMontoAsignado.Name = "lblMontoAsignado";
            lblMontoAsignado.Size = new Size(116, 15);
            lblMontoAsignado.TabIndex = 2;
            lblMontoAsignado.Text = "Monto Asignado ($):";
            // 
            // lblIdPresupuesto
            // 
            lblIdPresupuesto.AutoSize = true;
            lblIdPresupuesto.Location = new Point(16, 53);
            lblIdPresupuesto.Name = "lblIdPresupuesto";
            lblIdPresupuesto.Size = new Size(89, 15);
            lblIdPresupuesto.TabIndex = 0;
            lblIdPresupuesto.Text = "ID Presupuesto:";
            // 
            // cmbPeriodoPresupuesto
            // 
            cmbPeriodoPresupuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodoPresupuesto.FormattingEnabled = true;
            cmbPeriodoPresupuesto.Location = new Point(175, 325);
            cmbPeriodoPresupuesto.Name = "cmbPeriodoPresupuesto";
            cmbPeriodoPresupuesto.Size = new Size(100, 23);
            cmbPeriodoPresupuesto.TabIndex = 7;
            // 
            // nudMontoDisponible
            // 
            nudMontoDisponible.DecimalPlaces = 2;
            nudMontoDisponible.Location = new Point(175, 249);
            nudMontoDisponible.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMontoDisponible.Name = "nudMontoDisponible";
            nudMontoDisponible.Size = new Size(100, 23);
            nudMontoDisponible.TabIndex = 5;
            // 
            // nudMontoAsignado
            // 
            nudMontoAsignado.DecimalPlaces = 2;
            nudMontoAsignado.Location = new Point(175, 150);
            nudMontoAsignado.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMontoAsignado.Name = "nudMontoAsignado";
            nudMontoAsignado.Size = new Size(100, 23);
            nudMontoAsignado.TabIndex = 3;
            // 
            // txtIdPresupuesto
            // 
            txtIdPresupuesto.Location = new Point(175, 53);
            txtIdPresupuesto.Name = "txtIdPresupuesto";
            txtIdPresupuesto.Size = new Size(100, 23);
            txtIdPresupuesto.TabIndex = 1;
            // 
            // pnlBotonesPresupuesto
            // 
            pnlBotonesPresupuesto.Controls.Add(btnBorrarPresupuesto);
            pnlBotonesPresupuesto.Controls.Add(btnDestruirPresupuesto);
            pnlBotonesPresupuesto.Controls.Add(btnBuscarPresupuesto);
            pnlBotonesPresupuesto.Controls.Add(btnActualizarPresupuesto);
            pnlBotonesPresupuesto.Controls.Add(btnMostrarPresupuestos);
            pnlBotonesPresupuesto.Controls.Add(btnCrearPresupuesto);
            pnlBotonesPresupuesto.Dock = DockStyle.Bottom;
            pnlBotonesPresupuesto.Location = new Point(0, 601);
            pnlBotonesPresupuesto.Name = "pnlBotonesPresupuesto";
            pnlBotonesPresupuesto.Size = new Size(1000, 60);
            pnlBotonesPresupuesto.TabIndex = 0;
            // 
            // btnBorrarPresupuesto
            // 
            btnBorrarPresupuesto.Location = new Point(669, 3);
            btnBorrarPresupuesto.Name = "btnBorrarPresupuesto";
            btnBorrarPresupuesto.Size = new Size(142, 46);
            btnBorrarPresupuesto.TabIndex = 4;
            btnBorrarPresupuesto.Text = "Inactivar";
            btnBorrarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btnDestruirPresupuesto
            // 
            btnDestruirPresupuesto.Location = new Point(827, 3);
            btnDestruirPresupuesto.Name = "btnDestruirPresupuesto";
            btnDestruirPresupuesto.Size = new Size(142, 46);
            btnDestruirPresupuesto.TabIndex = 5;
            btnDestruirPresupuesto.Text = "Eliminar Definitivo";
            btnDestruirPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPresupuesto
            // 
            btnBuscarPresupuesto.Location = new Point(170, 3);
            btnBuscarPresupuesto.Name = "btnBuscarPresupuesto";
            btnBuscarPresupuesto.Size = new Size(142, 46);
            btnBuscarPresupuesto.TabIndex = 1;
            btnBuscarPresupuesto.Text = "Buscar";
            btnBuscarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPresupuesto
            // 
            btnActualizarPresupuesto.Location = new Point(506, 3);
            btnActualizarPresupuesto.Name = "btnActualizarPresupuesto";
            btnActualizarPresupuesto.Size = new Size(142, 46);
            btnActualizarPresupuesto.TabIndex = 3;
            btnActualizarPresupuesto.Text = "Actualizar";
            btnActualizarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btnMostrarPresupuestos
            // 
            btnMostrarPresupuestos.Location = new Point(337, 3);
            btnMostrarPresupuestos.Name = "btnMostrarPresupuestos";
            btnMostrarPresupuestos.Size = new Size(142, 46);
            btnMostrarPresupuestos.TabIndex = 2;
            btnMostrarPresupuestos.Text = "Mostrar Todo";
            btnMostrarPresupuestos.UseVisualStyleBackColor = true;
            // 
            // btnCrearPresupuesto
            // 
            btnCrearPresupuesto.Location = new Point(5, 3);
            btnCrearPresupuesto.Name = "btnCrearPresupuesto";
            btnCrearPresupuesto.Size = new Size(142, 46);
            btnCrearPresupuesto.TabIndex = 0;
            btnCrearPresupuesto.Text = "Agregar";
            btnCrearPresupuesto.UseVisualStyleBackColor = true;
            // 
            // tbpSolicitudes
            // 
            tbpSolicitudes.Controls.Add(gbxListaSolicitudes);
            tbpSolicitudes.Controls.Add(gbxDatosSolicitud);
            tbpSolicitudes.Controls.Add(pnlBotonesSolicitud);
            tbpSolicitudes.Location = new Point(4, 24);
            tbpSolicitudes.Name = "tbpSolicitudes";
            tbpSolicitudes.Size = new Size(1000, 661);
            tbpSolicitudes.TabIndex = 3;
            tbpSolicitudes.Text = "Solicitudes";
            tbpSolicitudes.UseVisualStyleBackColor = true;
            // 
            // gbxListaSolicitudes
            // 
            gbxListaSolicitudes.Controls.Add(dgvSolicitudes);
            gbxListaSolicitudes.Location = new Point(482, 16);
            gbxListaSolicitudes.Name = "gbxListaSolicitudes";
            gbxListaSolicitudes.Size = new Size(490, 458);
            gbxListaSolicitudes.TabIndex = 8;
            gbxListaSolicitudes.TabStop = false;
            gbxListaSolicitudes.Text = "Lista Solicitudes";
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Dock = DockStyle.Fill;
            dgvSolicitudes.Location = new Point(3, 19);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.Size = new Size(484, 436);
            dgvSolicitudes.TabIndex = 0;
            // 
            // gbxDatosSolicitud
            // 
            gbxDatosSolicitud.Controls.Add(label8);
            gbxDatosSolicitud.Controls.Add(cmbEstadoSolicitud);
            gbxDatosSolicitud.Controls.Add(dtpFechaSolicitud);
            gbxDatosSolicitud.Controls.Add(cmbBecaSolicitud);
            gbxDatosSolicitud.Controls.Add(cmbEstudianteSolicitud);
            gbxDatosSolicitud.Controls.Add(label13);
            gbxDatosSolicitud.Controls.Add(label14);
            gbxDatosSolicitud.Controls.Add(label15);
            gbxDatosSolicitud.Controls.Add(label17);
            gbxDatosSolicitud.Controls.Add(txtIdSolicitud);
            gbxDatosSolicitud.Location = new Point(27, 16);
            gbxDatosSolicitud.Name = "gbxDatosSolicitud";
            gbxDatosSolicitud.Size = new Size(438, 458);
            gbxDatosSolicitud.TabIndex = 7;
            gbxDatosSolicitud.TabStop = false;
            gbxDatosSolicitud.Text = "Datos de la Solicitud";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 392);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 15;
            label8.Text = "Estado:";
            // 
            // cmbEstadoSolicitud
            // 
            cmbEstadoSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoSolicitud.FormattingEnabled = true;
            cmbEstadoSolicitud.Items.AddRange(new object[] { "Pendiente", "Aprobada", "Rechazada" });
            cmbEstadoSolicitud.Location = new Point(175, 384);
            cmbEstadoSolicitud.Name = "cmbEstadoSolicitud";
            cmbEstadoSolicitud.Size = new Size(100, 23);
            cmbEstadoSolicitud.TabIndex = 14;
            // 
            // dtpFechaSolicitud
            // 
            dtpFechaSolicitud.Location = new Point(175, 325);
            dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            dtpFechaSolicitud.Size = new Size(237, 23);
            dtpFechaSolicitud.TabIndex = 13;
            // 
            // cmbBecaSolicitud
            // 
            cmbBecaSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBecaSolicitud.FormattingEnabled = true;
            cmbBecaSolicitud.Location = new Point(175, 249);
            cmbBecaSolicitud.Name = "cmbBecaSolicitud";
            cmbBecaSolicitud.Size = new Size(100, 23);
            cmbBecaSolicitud.TabIndex = 12;
            // 
            // cmbEstudianteSolicitud
            // 
            cmbEstudianteSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstudianteSolicitud.FormattingEnabled = true;
            cmbEstudianteSolicitud.Location = new Point(175, 150);
            cmbEstudianteSolicitud.Name = "cmbEstudianteSolicitud";
            cmbEstudianteSolicitud.Size = new Size(100, 23);
            cmbEstudianteSolicitud.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 331);
            label13.Name = "label13";
            label13.Size = new Size(106, 15);
            label13.TabIndex = 8;
            label13.Text = "Fecha de Solicitud:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 249);
            label14.Name = "label14";
            label14.Size = new Size(89, 15);
            label14.TabIndex = 7;
            label14.Text = "Beca Solicitada:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 153);
            label15.Name = "label15";
            label15.Size = new Size(65, 15);
            label15.TabIndex = 6;
            label15.Text = "Estudiante:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 53);
            label17.Name = "label17";
            label17.Size = new Size(70, 15);
            label17.TabIndex = 5;
            label17.Text = "ID Solicitud:";
            // 
            // txtIdSolicitud
            // 
            txtIdSolicitud.Location = new Point(175, 53);
            txtIdSolicitud.Name = "txtIdSolicitud";
            txtIdSolicitud.Size = new Size(100, 23);
            txtIdSolicitud.TabIndex = 0;
            // 
            // pnlBotonesSolicitud
            // 
            pnlBotonesSolicitud.Controls.Add(btnBorrarSolicitud);
            pnlBotonesSolicitud.Controls.Add(btnDestruirSolicitud);
            pnlBotonesSolicitud.Controls.Add(btnBuscarSolicitud);
            pnlBotonesSolicitud.Controls.Add(btnActualizarSolicitud);
            pnlBotonesSolicitud.Controls.Add(btnMostrarSolicitudes);
            pnlBotonesSolicitud.Controls.Add(btnCrearSolicitud);
            pnlBotonesSolicitud.Dock = DockStyle.Bottom;
            pnlBotonesSolicitud.Location = new Point(0, 601);
            pnlBotonesSolicitud.Name = "pnlBotonesSolicitud";
            pnlBotonesSolicitud.Size = new Size(1000, 60);
            pnlBotonesSolicitud.TabIndex = 6;
            // 
            // btnBorrarSolicitud
            // 
            btnBorrarSolicitud.Location = new Point(669, 3);
            btnBorrarSolicitud.Name = "btnBorrarSolicitud";
            btnBorrarSolicitud.Size = new Size(142, 46);
            btnBorrarSolicitud.TabIndex = 15;
            btnBorrarSolicitud.Text = "Inactivar";
            btnBorrarSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnDestruirSolicitud
            // 
            btnDestruirSolicitud.Location = new Point(827, 3);
            btnDestruirSolicitud.Name = "btnDestruirSolicitud";
            btnDestruirSolicitud.Size = new Size(142, 46);
            btnDestruirSolicitud.TabIndex = 14;
            btnDestruirSolicitud.Text = "Eliminar Definitivo";
            btnDestruirSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnBuscarSolicitud
            // 
            btnBuscarSolicitud.Location = new Point(170, 3);
            btnBuscarSolicitud.Name = "btnBuscarSolicitud";
            btnBuscarSolicitud.Size = new Size(142, 46);
            btnBuscarSolicitud.TabIndex = 13;
            btnBuscarSolicitud.Text = "Buscar";
            btnBuscarSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnActualizarSolicitud
            // 
            btnActualizarSolicitud.Location = new Point(506, 3);
            btnActualizarSolicitud.Name = "btnActualizarSolicitud";
            btnActualizarSolicitud.Size = new Size(142, 46);
            btnActualizarSolicitud.TabIndex = 12;
            btnActualizarSolicitud.Text = "Actualizar";
            btnActualizarSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSolicitudes
            // 
            btnMostrarSolicitudes.Location = new Point(337, 3);
            btnMostrarSolicitudes.Name = "btnMostrarSolicitudes";
            btnMostrarSolicitudes.Size = new Size(142, 46);
            btnMostrarSolicitudes.TabIndex = 11;
            btnMostrarSolicitudes.Text = "Mostrar Todo";
            btnMostrarSolicitudes.UseVisualStyleBackColor = true;
            btnMostrarSolicitudes.Click += btnMostrarSolicitudes_Click;
            // 
            // btnCrearSolicitud
            // 
            btnCrearSolicitud.Location = new Point(5, 3);
            btnCrearSolicitud.Name = "btnCrearSolicitud";
            btnCrearSolicitud.Size = new Size(142, 46);
            btnCrearSolicitud.TabIndex = 10;
            btnCrearSolicitud.Text = "Agregar";
            btnCrearSolicitud.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 689);
            Controls.Add(tbcPrincipal);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor de Becas y Apoyos Estudiantiles - Equipo 6";
            tbcPrincipal.ResumeLayout(false);
            tbpEstudiantes.ResumeLayout(false);
            gbxListaEstudiantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            gbxDatosEstudiante.ResumeLayout(false);
            gbxDatosEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSemestreEstudiante).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            pnlBotonesEstudiante.ResumeLayout(false);
            tbpBecas.ResumeLayout(false);
            gbxListaBecas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbxDatosBeca.ResumeLayout(false);
            gbxDatosBeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCupoBeca).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoBeca).EndInit();
            pnlBotonesBeca.ResumeLayout(false);
            tbpPresupuesto.ResumeLayout(false);
            gbxListaPresupuestos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPresupuesto).EndInit();
            gbxDatosPresupuesto.ResumeLayout(false);
            gbxDatosPresupuesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoDisponible).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMontoAsignado).EndInit();
            pnlBotonesPresupuesto.ResumeLayout(false);
            tbpSolicitudes.ResumeLayout(false);
            gbxListaSolicitudes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            gbxDatosSolicitud.ResumeLayout(false);
            gbxDatosSolicitud.PerformLayout();
            pnlBotonesSolicitud.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcPrincipal;

        // Estudiantes
        private TabPage tbpEstudiantes;
        private GroupBox gbxListaEstudiantes;
        private DataGridView dgvEstudiantes;
        private GroupBox gbxDatosEstudiante;
        private NumericUpDown nudSemestreEstudiante;
        private NumericUpDown numericUpDown1;
        private ComboBox cmbCarreraEstudiante;
        private Label label5;
        private Label label4;
        private Label lblCarreraEstudiante;
        private Label lblNombreEstudiante;
        private Label lblMatrIdentificador;
        private TextBox txtMatriIdentificador;
        private TextBox txtNombreEstudiantes;
        private Panel pnlBotonesEstudiante;
        private Button btnDestruirEstudiante;
        private Button btnCrearEstudiante;
        private Button btnBorrarEstudiante;
        private Button btnBuscarEstudiante;
        private Button btnActualizarEstudiante;
        private Button btnMostrarEstudiantes;

        // Becas
        private TabPage tbpBecas;
        private GroupBox gbxDatosBeca;
        private TextBox txtIdBeca;
        private TextBox txtNombreBeca;
        private ComboBox cmbTipoBeca;
        private NumericUpDown nudMontoBeca;
        private NumericUpDown nudCupoBeca;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private GroupBox gbxListaBecas;
        private DataGridView dataGridView1;
        private Panel pnlBotonesBeca;
        private Button btnCrearBeca;
        private Button btnBuscarBeca;
        private Button btnMostrarBecas;
        private Button btnActualizarBeca;
        private Button btnBorrarBeca;
        private Button btnDestruirBeca;

        // Presupuesto
        private TabPage tbpPresupuesto;
        private GroupBox gbxDatosPresupuesto;
        private TextBox txtIdPresupuesto;
        private NumericUpDown nudMontoAsignado;
        private NumericUpDown nudMontoDisponible;
        private ComboBox cmbPeriodoPresupuesto;
        private Label lblIdPresupuesto;
        private Label lblMontoAsignado;
        private Label lblMontoDisponible;
        private Label lblPeriodoPresupuesto;
        private GroupBox gbxListaPresupuestos;
        private DataGridView dgvPresupuesto;
        private Panel pnlBotonesPresupuesto;
        private Button btnCrearPresupuesto;
        private Button btnBuscarPresupuesto;
        private Button btnMostrarPresupuestos;
        private Button btnActualizarPresupuesto;
        private Button btnBorrarPresupuesto;
        private Button btnDestruirPresupuesto;

        // Solicitudes
        private TabPage tbpSolicitudes;
        private GroupBox gbxDatosSolicitud;
        private TextBox txtIdSolicitud;
        private ComboBox cmbEstudianteSolicitud;
        private ComboBox cmbBecaSolicitud;
        private DateTimePicker dtpFechaSolicitud;
        private ComboBox cmbEstadoSolicitud;
        private Label label17;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label8;
        private GroupBox gbxListaSolicitudes;
        private DataGridView dgvSolicitudes;
        private Panel pnlBotonesSolicitud;
        private Button btnCrearSolicitud;
        private Button btnBuscarSolicitud;
        private Button btnMostrarSolicitudes;
        private Button btnActualizarSolicitud;
        private Button btnBorrarSolicitud;
        private Button btnDestruirSolicitud;
    }
}