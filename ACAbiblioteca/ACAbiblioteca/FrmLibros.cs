using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ACAbiblioteca.Datos;
using System.Drawing.Text;

namespace ACAbiblioteca
{
    public partial class FrmLibros : Form
    {
        private bool modoEdicion = false;
        public FrmLibros()
        {

            InitializeComponent();
            CargarLibros();
            CargarAutores();
            CargarEditoriales();


        }

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        DgvLibros.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdAutor, Nombre, Apellido FROM Autores ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        tabla.Columns.Add("NombreCompleto", typeof(string));

                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] =
                                fila["Nombre"].ToString() + " " +
                                fila["Apellido"].ToString();
                        }

                        CmbAutor.DataSource = tabla;
                        CmbAutor.DisplayMember = "NombreCompleto";
                        CmbAutor.ValueMember = "IdAutor";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los autores:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdEditorial, Nombre FROM Editoriales ORDER BY Nombre";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        CmbEditorial.DataSource = tabla;
                        CmbEditorial.DisplayMember = "Nombre";
                        CmbEditorial.ValueMember = "IdEditorial";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las editoriales:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtBuscarISBN.Text))
                {
                    MessageBox.Show(
                        "Ingrese un ISBN para realizar la búsqueda.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", TxtBuscarISBN.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                TxtISBN.Text = lector["ISBN"].ToString();
                                TxtTitulo.Text = lector["Titulo"].ToString();
                                CmbAutor.SelectedValue = Convert.ToInt32(lector["IdAutor"]);
                                CmbEditorial.SelectedValue = Convert.ToInt32(lector["IdEditorial"]);
                                TxtCategoria.Text = lector["Categoria"].ToString();
                                TxtAño.Text = lector["Anio"].ToString();
                                TxtExistencias.Text = lector["Existencias"].ToString();

                                MessageBox.Show(
                                    "Libro encontrado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un libro con ese ISBN.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            TxtISBN.Clear();
            TxtTitulo.Clear();
            TxtCategoria.Clear();
            TxtAño.Clear();
            TxtExistencias.Clear();

            CmbAutor.SelectedIndex = -1;
            CmbEditorial.SelectedIndex = -1;

            TxtISBN.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtISBN.Text) ||
                    string.IsNullOrWhiteSpace(TxtTitulo.Text) ||
                    CmbAutor.SelectedIndex == -1 ||
                    CmbEditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(TxtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(TxtAño.Text) ||
                    string.IsNullOrWhiteSpace(TxtExistencias.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de guardar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int anio;
                int existencias;

                if (!int.TryParse(TxtAño.Text, out anio))
                {
                    MessageBox.Show(
                        "El año debe ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(TxtExistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Las existencias deben ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Libros
                                (ISBN, Titulo, IdAutor, IdEditorial, Categoria, Anio, Existencias)
                                VALUES
                                (@ISBN, @Titulo, @IdAutor, @IdEditorial, @Categoria, @Anio, @Existencias)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", TxtISBN.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", TxtTitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(CmbAutor.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(CmbEditorial.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", TxtCategoria.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();

                BtnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtISBN.Text) ||
                    string.IsNullOrWhiteSpace(TxtTitulo.Text) ||
                    CmbAutor.SelectedIndex == -1 ||
                    CmbEditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(TxtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(TxtAño.Text) ||
                    string.IsNullOrWhiteSpace(TxtExistencias.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int anio;
                int existencias;

                if (!int.TryParse(TxtAño.Text, out anio))
                {
                    MessageBox.Show(
                        "El año debe ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(TxtExistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Las existencias deben ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Libros
                                SET Titulo = @Titulo,
                                    IdAutor = @IdAutor,
                                    IdEditorial = @IdEditorial,
                                    Categoria = @Categoria,
                                    Anio = @Anio,
                                    Existencias = @Existencias
                                WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", TxtISBN.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", TxtTitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(CmbAutor.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(CmbEditorial.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", TxtCategoria.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();
                BtnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void DgvLibros_CellDoubleClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TxtISBN.Text = DgvLibros.Rows[e.RowIndex]
                .Cells["ISBN"].Value.ToString();

            TxtTitulo.Text = DgvLibros.Rows[e.RowIndex]
                .Cells["Titulo"].Value.ToString();

            CmbAutor.SelectedValue = Convert.ToInt32(
                DgvLibros.Rows[e.RowIndex]
                .Cells["IdAutor"].Value);

            CmbEditorial.SelectedValue = Convert.ToInt32(
                DgvLibros.Rows[e.RowIndex]
                .Cells["IdEditorial"].Value);

            TxtCategoria.Text = DgvLibros.Rows[e.RowIndex]
                .Cells["Categoria"].Value.ToString();

            TxtAño.Text = DgvLibros.Rows[e.RowIndex]
                .Cells["Anio"].Value.ToString();

            TxtExistencias.Text = DgvLibros.Rows[e.RowIndex]
                .Cells["Existencias"].Value.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtISBN.Clear();
            TxtTitulo.Clear();
            TxtCategoria.Clear();
            TxtAño.Clear();
            TxtExistencias.Clear();

            CmbAutor.SelectedIndex = -1;
            CmbEditorial.SelectedIndex = -1;

            modoEdicion = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvLibros.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un libro para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string isbn = DgvLibros.CurrentRow.Cells["ISBN"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este libro?",
                    "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "DELETE FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", isbn);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                modoEdicion = false;
                TxtISBN.Enabled = true;

                CargarLibros();

                BtnNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

}


    

