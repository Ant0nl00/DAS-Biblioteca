using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        List<Libro> listaLibros = new List<Libro>();
        List<Usuario> listaUsuarios = new List<Usuario>();
        List<Prestamo> listaPrestamos = new List<Prestamo>();

        public Form1()
        {
            InitializeComponent();

            // Inicializar el DataGridView cuando se carga el formulario
            InicializarDataGridViewLibros();
            InicializarDataGridViewUsuarios();
            InicializarDataGridViewHistorialPrestamos();
        }

        private void InicializarDataGridViewLibros()
        {
            // Limpiar las columnas actuales, si existen
            dgvLibros.Columns.Clear();

            // Agregar columnas al DataGridView
            dgvLibros.Columns.Add("Titulo", "Título");
            dgvLibros.Columns.Add("Autor", "Autor");
            dgvLibros.Columns.Add("AñoPublicacion", "Año de Publicación");
            dgvLibros.Columns.Add("Genero", "Género");

            // Ajustar tamaño de las columnas
            dgvLibros.Columns[0].Width = 250; // Título
            dgvLibros.Columns[1].Width = 150; // Autor
            dgvLibros.Columns[2].Width = 90;  // Año de Publicación
            dgvLibros.Columns[3].Width = 100; // Género
        }

        private void InicializarDataGridViewUsuarios()
        {
            // Limpiar las columnas actuales, si existen
            dgvUsuarios.Columns.Clear();

            // Agregar columnas al DataGridView
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Identificacion", "Identificación");
            dgvUsuarios.Columns.Add("Contacto", "Contacto");

            // Ajustar tamaño de las columnas (opcional)
            dgvUsuarios.Columns[0].Width = 250;  // Nombre
            dgvUsuarios.Columns[1].Width = 100;  // Identificación
            dgvUsuarios.Columns[2].Width = 150;  // Contacto
        }

        private void InicializarDataGridViewHistorialPrestamos()
        {
            // Limpiar las columnas actuales, si existen
            dgvHistorialPrestamos.Columns.Clear();

            // Agregar columnas al DataGridView
            dgvHistorialPrestamos.Columns.Add("Usuario", "Usuario");
            dgvHistorialPrestamos.Columns.Add("Libro", "Libro");
            dgvHistorialPrestamos.Columns.Add("FechaPrestamo", "Fecha de Préstamo");
            dgvHistorialPrestamos.Columns.Add("FechaDevolucion", "Fecha de Devolución");
            dgvHistorialPrestamos.Columns.Add("Devuelto", "Devuelto");

            // Ajustar tamaño de las columnas
            dgvHistorialPrestamos.Columns[0].Width = 250; // Usuario
            dgvHistorialPrestamos.Columns[1].Width = 150; // Libro
            dgvHistorialPrestamos.Columns[2].Width = 150; // Fecha de Préstamo
            dgvHistorialPrestamos.Columns[3].Width = 150; // Fecha de Devolución
            dgvHistorialPrestamos.Columns[4].Width = 80;  // Devuelto
        }

        private void ActualizarListaLibros()
        {
            // Limpiar todas las filas actuales del DataGridView
            dgvLibros.Rows.Clear();

            // Recorrer la lista de libros y agregar cada uno al DataGridView
            foreach (var libro in listaLibros)
            {
                // Agregar una fila nueva al DataGridView
                dgvLibros.Rows.Add(libro.Titulo, libro.Autor, libro.AñoPublicacion, libro.Genero);
            }
        }

        private void ActualizarListaUsuarios()
        {
            dgvUsuarios.Rows.Clear();

            foreach (var usuario in listaUsuarios)
            {
                dgvUsuarios.Rows.Add(usuario.Nombre, usuario.Identificacion, usuario.Contacto);
            }
        }

        private void ActualizarHistorialPrestamos()
        {
            dgvHistorialPrestamos.Rows.Clear();

            // Agregar cada préstamo a la tabla
            foreach (var prestamo in listaPrestamos)
            {
                dgvHistorialPrestamos.Rows.Add(prestamo.Usuario.Nombre,
                                               prestamo.Libro.Titulo,
                                               prestamo.FechaPrestamo.ToShortDateString(),
                                               prestamo.FechaDevolucion.ToShortDateString(),
                                               prestamo.Devuelto ? "Devuelto" : "No devuelto");
            }
        }

        private void ActualizarLibrosDisponibles()
        {
            cmbLibros.Items.Clear();

            var librosDisponibles = listaLibros.Where(libro => !listaPrestamos.Any(p => p.Libro == libro && !p.Devuelto)).ToList();

            foreach (var libro in librosDisponibles)
            {
                cmbLibros.Items.Add(libro.Titulo);
            }
        }

        private void GenerarGraficoLibrosPorAutor()
        {
            // Crear una serie para el gráfico
            Series serie = new Series("Libros por Autor");
            serie.ChartType = SeriesChartType.Column;

            // Contar el número de libros por autor
            var librosPorAutor = listaLibros.GroupBy(libro => libro.Autor)
                                            .Select(grupo => new { Autor = grupo.Key, Cantidad = grupo.Count() });

            // Añadir los datos al gráfico
            foreach (var item in librosPorAutor)
            {
                serie.Points.AddXY(item.Autor, item.Cantidad);
            }

            // Añadir la serie al gráfico
            chartBiblioteca.Series.Add(serie);
        }

        private void GenerarGraficoLibrosPorAño()
        {
            Series serie = new Series("Libros por Año");
            serie.ChartType = SeriesChartType.Column;

            var librosPorAño = listaLibros.GroupBy(libro => libro.AñoPublicacion)
                                          .Select(grupo => new { Año = grupo.Key, Cantidad = grupo.Count() });

            foreach (var item in librosPorAño)
            {
                serie.Points.AddXY(item.Año, item.Cantidad);
            }

            chartBiblioteca.Series.Add(serie);
        }

        private void GenerarGraficoPrestamosPorUsuario()
        {
            Series serie = new Series("Préstamos por Usuario");
            serie.ChartType = SeriesChartType.Column;

            var prestamosPorUsuario = listaPrestamos.GroupBy(prestamo => prestamo.Usuario.Nombre)
                                                    .Select(grupo => new { Usuario = grupo.Key, Cantidad = grupo.Count() });

            foreach (var item in prestamosPorUsuario)
            {
                serie.Points.AddXY(item.Usuario, item.Cantidad);
            }

            chartBiblioteca.Series.Add(serie);
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int añoPublicacion = int.Parse(txtAñoPublicacion.Text);
            string genero = txtGenero.Text;

            // Crear un nuevo libro y agregarlo a la lista
            Libro nuevoLibro = new Libro(titulo, autor, añoPublicacion, genero);
            listaLibros.Add(nuevoLibro);

            // Actualizar la lista en el DataGridView
            ActualizarListaLibros();

            // Limpiar los campos de texto
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAñoPublicacion.Clear();
            txtGenero.Clear();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscarLibro.Text.ToLower();

            var librosFiltrados = listaLibros.Where(l => l.Titulo.ToLower().Contains(criterioBusqueda) ||
                                                         l.Autor.ToLower().Contains(criterioBusqueda)).ToList();

            // Limpiar el DataGridView y mostrar los libros filtrados
            dgvLibros.Rows.Clear();
            foreach (var libro in librosFiltrados)
            {
                dgvLibros.Rows.Add(libro.Titulo, libro.Autor, libro.AñoPublicacion, libro.Genero);
            }

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAñoPublicacion.Clear();
            txtGenero.Clear();
        }

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            int indice = dgvLibros.SelectedRows[0].Index;

            // Actualizar los valores del libro seleccionado
            listaLibros[indice].Titulo = txtTitulo.Text;
            listaLibros[indice].Autor = txtAutor.Text;
            listaLibros[indice].AñoPublicacion = int.Parse(txtAñoPublicacion.Text);
            listaLibros[indice].Genero = txtGenero.Text;

            // Actualizar la lista en el DataGridView
            ActualizarListaLibros();

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAñoPublicacion.Clear();
            txtGenero.Clear();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            int indice = dgvLibros.SelectedRows[0].Index;

            // Eliminar el libro de la lista
            listaLibros.RemoveAt(indice);

            // Actualizar la lista en el DataGridView
            ActualizarListaLibros();

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAñoPublicacion.Clear();
            txtGenero.Clear();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string nombre = txtNombreUsuario.Text;
            string identificacion = txtIdentificacion.Text;
            string contacto = txtContacto.Text;

            // Crear un nuevo usuario y agregarlo a la lista
            Usuario nuevoUsuario = new Usuario(nombre, identificacion, contacto);
            listaUsuarios.Add(nuevoUsuario);

            // Actualizar la lista en el DataGridView de usuarios
            ActualizarListaUsuarios();

            // Limpiar los campos de texto
            txtNombreUsuario.Clear();
            txtIdentificacion.Clear();
            txtContacto.Clear();
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0) // Asegurarse de que haya una fila seleccionada
            {
                // Obtener el índice del usuario seleccionado
                int indice = dgvUsuarios.SelectedRows[0].Index;

                // Actualizar los valores del usuario seleccionado
                listaUsuarios[indice].Nombre = txtNombreUsuario.Text;
                listaUsuarios[indice].Identificacion = txtIdentificacion.Text;
                listaUsuarios[indice].Contacto = txtContacto.Text;

                // Actualizar la lista en el DataGridView
                ActualizarListaUsuarios();

                MessageBox.Show("Usuario actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para actualizar.");
            }

            // Limpiar los campos de texto
            txtNombreUsuario.Clear();
            txtIdentificacion.Clear();
            txtContacto.Clear();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0) // Asegurarse de que haya una fila seleccionada
            {
                // Obtener el índice del usuario seleccionado
                int indice = dgvUsuarios.SelectedRows[0].Index;

                // Eliminar el usuario de la lista
                listaUsuarios.RemoveAt(indice);

                // Actualizar la lista en el DataGridView
                ActualizarListaUsuarios();

                MessageBox.Show("Usuario eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
            }

            // Limpiar los campos de texto
            txtNombreUsuario.Clear();
            txtIdentificacion.Clear();
            txtContacto.Clear();
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedIndex == -1 || cmbLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un usuario y un libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el usuario y libro seleccionados
            Usuario usuarioSeleccionado = listaUsuarios[cmbUsuarios.SelectedIndex];
            Libro libroSeleccionado = listaLibros[cmbLibros.SelectedIndex];

            // Verificar que el libro no esté prestado
            if (listaPrestamos.Any(p => p.Libro == libroSeleccionado && !p.Devuelto))
            {
                MessageBox.Show("El libro ya está prestado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener las fechas
            DateTime fechaPrestamo = dtpFechaPrestamo.Value;
            DateTime fechaDevolucion = dtpFechaDevolucion.Value;

            // Crear un nuevo préstamo y agregarlo a la lista
            Prestamo nuevoPrestamo = new Prestamo(usuarioSeleccionado, libroSeleccionado, fechaPrestamo, fechaDevolucion);
            listaPrestamos.Add(nuevoPrestamo);

            // Actualizar el historial de préstamos
            ActualizarHistorialPrestamos();

            MessageBox.Show("Préstamo registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            if (dgvHistorialPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un préstamo para registrar la devolución.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = dgvHistorialPrestamos.SelectedRows[0].Index;
            Prestamo prestamoSeleccionado = listaPrestamos[indice];

            // Verificar si el préstamo ya fue devuelto
            if (prestamoSeleccionado.Devuelto)
            {
                MessageBox.Show("Este préstamo ya fue devuelto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Marcar el préstamo como devuelto
            prestamoSeleccionado.Devuelto = true;

            // Actualizar el historial de préstamos
            ActualizarHistorialPrestamos();

            MessageBox.Show("Devolución registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tcBiblioteca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcBiblioteca.SelectedTab == Prestamos) // Verificar si estamos en la pestaña de préstamos
            {
                ActualizarLibrosDisponibles();  // Actualizar combobox de libros disponibles
                ActualizarUsuariosDisponibles();  // Actualizar combobox de usuarios
            }
        }

        private void ActualizarUsuariosDisponibles()
        {
            cmbUsuarios.Items.Clear();

            // Agregar cada usuario a combobox de usuarios
            foreach (var usuario in listaUsuarios)
            {
                cmbUsuarios.Items.Add(usuario.Nombre);
            }
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            // Limpiar el gráfico anterior
            chartBiblioteca.Series.Clear();

            // Obtener el tipo de estadística seleccionada
            string tipoEstadistica = cmbTipoEstadistica.SelectedItem.ToString();

            switch (tipoEstadistica)
            {
                case "Número de libros por autor":
                    GenerarGraficoLibrosPorAutor();
                    break;
                case "Número de libros por año":
                    GenerarGraficoLibrosPorAño();
                    break;
                case "Préstamos por usuario":
                    GenerarGraficoPrestamosPorUsuario();
                    break;
                default:
                    MessageBox.Show("Por favor selecciona una opción válida.");
                    break;
            }


        }
    }
}