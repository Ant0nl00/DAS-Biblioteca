
namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tcBiblioteca = new System.Windows.Forms.TabControl();
            this.Libros = new System.Windows.Forms.TabPage();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnActualizarLibro = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.txtBuscarLibro = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAñoPublicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Prestamos = new System.Windows.Forms.TabPage();
            this.btnRegistrarDevolucion = new System.Windows.Forms.Button();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.dgvHistorialPrestamos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.Graficos = new System.Windows.Forms.TabPage();
            this.cmbTipoEstadistica = new System.Windows.Forms.ComboBox();
            this.chartBiblioteca = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerarGrafico = new System.Windows.Forms.Button();
            this.tcBiblioteca.SuspendLayout();
            this.Libros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.Prestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPrestamos)).BeginInit();
            this.Graficos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBiblioteca
            // 
            this.tcBiblioteca.Controls.Add(this.Libros);
            this.tcBiblioteca.Controls.Add(this.Usuarios);
            this.tcBiblioteca.Controls.Add(this.Prestamos);
            this.tcBiblioteca.Controls.Add(this.Graficos);
            this.tcBiblioteca.Location = new System.Drawing.Point(22, 12);
            this.tcBiblioteca.Name = "tcBiblioteca";
            this.tcBiblioteca.SelectedIndex = 0;
            this.tcBiblioteca.Size = new System.Drawing.Size(1167, 690);
            this.tcBiblioteca.TabIndex = 0;
            this.tcBiblioteca.SelectedIndexChanged += new System.EventHandler(this.tcBiblioteca_SelectedIndexChanged);
            // 
            // Libros
            // 
            this.Libros.BackColor = System.Drawing.Color.DimGray;
            this.Libros.Controls.Add(this.dgvLibros);
            this.Libros.Controls.Add(this.btnEliminarLibro);
            this.Libros.Controls.Add(this.btnActualizarLibro);
            this.Libros.Controls.Add(this.btnAgregarLibro);
            this.Libros.Controls.Add(this.btnBuscarLibro);
            this.Libros.Controls.Add(this.txtBuscarLibro);
            this.Libros.Controls.Add(this.txtGenero);
            this.Libros.Controls.Add(this.label4);
            this.Libros.Controls.Add(this.txtAñoPublicacion);
            this.Libros.Controls.Add(this.label3);
            this.Libros.Controls.Add(this.txtAutor);
            this.Libros.Controls.Add(this.label2);
            this.Libros.Controls.Add(this.txtTitulo);
            this.Libros.Controls.Add(this.label1);
            this.Libros.Location = new System.Drawing.Point(4, 25);
            this.Libros.Name = "Libros";
            this.Libros.Padding = new System.Windows.Forms.Padding(3);
            this.Libros.Size = new System.Drawing.Size(1159, 661);
            this.Libros.TabIndex = 0;
            this.Libros.Text = "LIBROS";
            // 
            // dgvLibros
            // 
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(117, 380);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(869, 242);
            this.dgvLibros.TabIndex = 13;
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarLibro.Location = new System.Drawing.Point(728, 309);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(117, 50);
            this.btnEliminarLibro.TabIndex = 12;
            this.btnEliminarLibro.Text = "ELIMINAR LIBRO";
            this.btnEliminarLibro.UseVisualStyleBackColor = false;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnActualizarLibro
            // 
            this.btnActualizarLibro.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnActualizarLibro.Location = new System.Drawing.Point(510, 309);
            this.btnActualizarLibro.Name = "btnActualizarLibro";
            this.btnActualizarLibro.Size = new System.Drawing.Size(117, 50);
            this.btnActualizarLibro.TabIndex = 11;
            this.btnActualizarLibro.Text = "ACTUALIZAR LIBRO";
            this.btnActualizarLibro.UseVisualStyleBackColor = false;
            this.btnActualizarLibro.Click += new System.EventHandler(this.btnActualizarLibro_Click);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarLibro.Location = new System.Drawing.Point(306, 309);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(117, 50);
            this.btnAgregarLibro.TabIndex = 10;
            this.btnAgregarLibro.Text = "AGREGAR LIBRO";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBuscarLibro.Location = new System.Drawing.Point(928, 30);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(117, 50);
            this.btnBuscarLibro.TabIndex = 9;
            this.btnBuscarLibro.Text = "BUSCAR";
            this.btnBuscarLibro.UseVisualStyleBackColor = false;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // txtBuscarLibro
            // 
            this.txtBuscarLibro.Location = new System.Drawing.Point(728, 30);
            this.txtBuscarLibro.Name = "txtBuscarLibro";
            this.txtBuscarLibro.Size = new System.Drawing.Size(149, 22);
            this.txtBuscarLibro.TabIndex = 8;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(245, 222);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(343, 22);
            this.txtGenero.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENERO";
            // 
            // txtAñoPublicacion
            // 
            this.txtAñoPublicacion.Location = new System.Drawing.Point(245, 156);
            this.txtAñoPublicacion.Name = "txtAñoPublicacion";
            this.txtAñoPublicacion.Size = new System.Drawing.Size(343, 22);
            this.txtAñoPublicacion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "AÑO";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(245, 86);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(343, 22);
            this.txtAutor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "AUTOR";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(245, 31);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(343, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITULO";
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.Color.DimGray;
            this.Usuarios.Controls.Add(this.dgvUsuarios);
            this.Usuarios.Controls.Add(this.btnEliminarUsuario);
            this.Usuarios.Controls.Add(this.btnActualizarUsuario);
            this.Usuarios.Controls.Add(this.btnAgregarUsuario);
            this.Usuarios.Controls.Add(this.txtContacto);
            this.Usuarios.Controls.Add(this.label5);
            this.Usuarios.Controls.Add(this.txtIdentificacion);
            this.Usuarios.Controls.Add(this.label6);
            this.Usuarios.Controls.Add(this.txtNombreUsuario);
            this.Usuarios.Controls.Add(this.label7);
            this.Usuarios.Location = new System.Drawing.Point(4, 25);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(1159, 661);
            this.Usuarios.TabIndex = 1;
            this.Usuarios.Text = "USUARIOS";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(127, 356);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(869, 242);
            this.dgvUsuarios.TabIndex = 16;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(721, 273);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(117, 50);
            this.btnEliminarUsuario.TabIndex = 15;
            this.btnEliminarUsuario.Text = "ELIMINAR USUARIO";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(503, 273);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(117, 50);
            this.btnActualizarUsuario.TabIndex = 14;
            this.btnActualizarUsuario.Text = "ACTUALIZAR USUARIO";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(299, 273);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(117, 50);
            this.btnAgregarUsuario.TabIndex = 13;
            this.btnAgregarUsuario.Text = "REGISTRAR USUARIO";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(275, 177);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(343, 22);
            this.txtContacto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "CONTACTO";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(275, 107);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(343, 22);
            this.txtIdentificacion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "IDENTIFICACION";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(275, 52);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(343, 22);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "NOMBRE";
            // 
            // Prestamos
            // 
            this.Prestamos.BackColor = System.Drawing.Color.DimGray;
            this.Prestamos.Controls.Add(this.btnRegistrarDevolucion);
            this.Prestamos.Controls.Add(this.btnRegistrarPrestamo);
            this.Prestamos.Controls.Add(this.dgvHistorialPrestamos);
            this.Prestamos.Controls.Add(this.label10);
            this.Prestamos.Controls.Add(this.label11);
            this.Prestamos.Controls.Add(this.dtpFechaDevolucion);
            this.Prestamos.Controls.Add(this.dtpFechaPrestamo);
            this.Prestamos.Controls.Add(this.cmbLibros);
            this.Prestamos.Controls.Add(this.cmbUsuarios);
            this.Prestamos.Location = new System.Drawing.Point(4, 25);
            this.Prestamos.Name = "Prestamos";
            this.Prestamos.Padding = new System.Windows.Forms.Padding(3);
            this.Prestamos.Size = new System.Drawing.Size(1159, 661);
            this.Prestamos.TabIndex = 2;
            this.Prestamos.Text = "PRESTAMOS";
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.BackColor = System.Drawing.Color.Pink;
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(756, 201);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(117, 50);
            this.btnRegistrarDevolucion.TabIndex = 22;
            this.btnRegistrarDevolucion.Text = "REGISTRAR DEVOLUCION";
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            this.btnRegistrarDevolucion.Click += new System.EventHandler(this.btnRegistrarDevolucion_Click);
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.BackColor = System.Drawing.Color.Tomato;
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(552, 201);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(117, 50);
            this.btnRegistrarPrestamo.TabIndex = 21;
            this.btnRegistrarPrestamo.Text = "REGISTRAR PRESTAMO";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // dgvHistorialPrestamos
            // 
            this.dgvHistorialPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPrestamos.Location = new System.Drawing.Point(77, 314);
            this.dgvHistorialPrestamos.Name = "dgvHistorialPrestamos";
            this.dgvHistorialPrestamos.RowHeadersWidth = 51;
            this.dgvHistorialPrestamos.RowTemplate.Height = 24;
            this.dgvHistorialPrestamos.Size = new System.Drawing.Size(954, 292);
            this.dgvHistorialPrestamos.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "FECHA DEVOLUCION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "FECHA PRESTAMO";
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(232, 232);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaDevolucion.TabIndex = 17;
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(232, 179);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaPrestamo.TabIndex = 16;
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(436, 108);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(213, 24);
            this.cmbLibros.TabIndex = 15;
            this.cmbLibros.Text = "SELECCIONAR LIBRO";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(436, 49);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(213, 24);
            this.cmbUsuarios.TabIndex = 14;
            this.cmbUsuarios.Text = "SELECCIONAR USUARIO";
            // 
            // Graficos
            // 
            this.Graficos.BackColor = System.Drawing.Color.Silver;
            this.Graficos.Controls.Add(this.btnGenerarGrafico);
            this.Graficos.Controls.Add(this.chartBiblioteca);
            this.Graficos.Controls.Add(this.cmbTipoEstadistica);
            this.Graficos.Location = new System.Drawing.Point(4, 25);
            this.Graficos.Name = "Graficos";
            this.Graficos.Padding = new System.Windows.Forms.Padding(3);
            this.Graficos.Size = new System.Drawing.Size(1159, 661);
            this.Graficos.TabIndex = 3;
            this.Graficos.Text = "GRAFICOS";
            // 
            // cmbTipoEstadistica
            // 
            this.cmbTipoEstadistica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbTipoEstadistica.FormattingEnabled = true;
            this.cmbTipoEstadistica.Items.AddRange(new object[] {
            "Número de libros por autor",
            "Número de libros por año",
            "Préstamos por usuario"});
            this.cmbTipoEstadistica.Location = new System.Drawing.Point(388, 79);
            this.cmbTipoEstadistica.Name = "cmbTipoEstadistica";
            this.cmbTipoEstadistica.Size = new System.Drawing.Size(336, 24);
            this.cmbTipoEstadistica.TabIndex = 0;
            this.cmbTipoEstadistica.Text = "SELECCIONE LA ESTADISTICA A CONOCER";
            // 
            // chartBiblioteca
            // 
            this.chartBiblioteca.BackColor = System.Drawing.Color.Coral;
            this.chartBiblioteca.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea1.Name = "ChartArea1";
            this.chartBiblioteca.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBiblioteca.Legends.Add(legend1);
            this.chartBiblioteca.Location = new System.Drawing.Point(251, 237);
            this.chartBiblioteca.Name = "chartBiblioteca";
            this.chartBiblioteca.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBiblioteca.Series.Add(series1);
            this.chartBiblioteca.Size = new System.Drawing.Size(685, 374);
            this.chartBiblioteca.TabIndex = 1;
            this.chartBiblioteca.Text = "BIBLIOTECA";
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.BackColor = System.Drawing.Color.Orange;
            this.btnGenerarGrafico.Location = new System.Drawing.Point(442, 143);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(239, 61);
            this.btnGenerarGrafico.TabIndex = 2;
            this.btnGenerarGrafico.Text = "GENERAR GRAFICO";
            this.btnGenerarGrafico.UseVisualStyleBackColor = false;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 752);
            this.Controls.Add(this.tcBiblioteca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcBiblioteca.ResumeLayout(false);
            this.Libros.ResumeLayout(false);
            this.Libros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.Usuarios.ResumeLayout(false);
            this.Usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.Prestamos.ResumeLayout(false);
            this.Prestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPrestamos)).EndInit();
            this.Graficos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBiblioteca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBiblioteca;
        private System.Windows.Forms.TabPage Libros;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.TabPage Prestamos;
        private System.Windows.Forms.TabPage Graficos;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnActualizarLibro;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.TextBox txtBuscarLibro;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAñoPublicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnRegistrarDevolucion;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.DataGridView dgvHistorialPrestamos;
        private System.Windows.Forms.ComboBox cmbTipoEstadistica;
        private System.Windows.Forms.Button btnGenerarGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBiblioteca;
    }
}

