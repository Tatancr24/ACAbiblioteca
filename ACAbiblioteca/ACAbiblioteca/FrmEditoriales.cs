using ACAbiblioteca.Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ACAbiblioteca
{
    public partial class FrmEditoriales : Form
    {
        public FrmEditoriales()
        {
            InitializeComponent();
            CargarEditoriales();
        }

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Editoriales";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        DgvEditoriales.DataSource = tabla;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la editorial.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "INSERT INTO Editoriales (Nombre) VALUES (@Nombre)";

                using (SqlCommand comando =
                       new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        TxtNombre.Text.Trim());

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Editorial guardada correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarEditoriales();

            TxtNombre.Clear();
            TxtNombre.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtNombre.Focus();
        }

        // *** Metodo Función CellDoubleClick - dgvEditoriales ****

        private void dgvEditoriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TxtNombre.Text =
                DgvEditoriales.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvEditoriales.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione una editorial para editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idEditorial = Convert.ToInt32(
                    DgvEditoriales.CurrentRow.Cells["IdEditorial"].Value);

                if (string.IsNullOrWhiteSpace(TxtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la editorial.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta =
                        "UPDATE Editoriales SET Nombre = @Nombre WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre",
                            TxtNombre.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@IdEditorial",
                            idEditorial);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial actualizada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();

                TxtNombre.Clear();
                TxtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar la editorial:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvEditoriales.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione una editorial para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idEditorial = Convert.ToInt32(
                    DgvEditoriales.CurrentRow.Cells["IdEditorial"].Value);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar esta editorial?",
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

                    string consulta =
                        "DELETE FROM Editoriales WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@IdEditorial",
                            idEditorial);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial eliminada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();

                TxtNombre.Clear();
                TxtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la editorial:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtNombre.Focus();
        }
    }
}
