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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Usuarios";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        DgvUsuarios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
        string.IsNullOrWhiteSpace(TxtApellido.Text) ||
        string.IsNullOrWhiteSpace(TxtDocumento.Text) ||
        string.IsNullOrWhiteSpace(TxtTelefono.Text) ||
        string.IsNullOrWhiteSpace(TxtCorreo.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de guardar.",
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
                    "INSERT INTO Usuarios " +
                    "(Nombre, Apellido, Documento, Telefono, Correo) " +
                    "VALUES " +
                    "(@Nombre, @Apellido, @Documento, @Telefono, @Correo)";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@Nombre", TxtNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@Apellido", TxtApellido.Text.Trim());
                    comando.Parameters.AddWithValue("@Documento", TxtDocumento.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefono", TxtTelefono.Text.Trim());
                    comando.Parameters.AddWithValue("@Correo", TxtCorreo.Text.Trim());

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario guardado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            BtnNuevo_Click(null, null);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDocumento.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();

            TxtNombre.Focus();
        }


        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TxtNombre.Text = DgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            TxtApellido.Text = DgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();

            TxtDocumento.Text = DgvUsuarios.Rows[e.RowIndex].Cells["Documento"].Value.ToString();

            TxtTelefono.Text = DgvUsuarios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

            TxtCorreo.Text = DgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)

        {
            if (DgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                DgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(TxtDocumento.Text) ||
                string.IsNullOrWhiteSpace(TxtTelefono.Text) ||
                string.IsNullOrWhiteSpace(TxtCorreo.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de editar.",
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
                    "UPDATE Usuarios SET " +
                    "Nombre = @Nombre, " +
                    "Apellido = @Apellido, " +
                    "Documento = @Documento, " +
                    "Telefono = @Telefono, " +
                    "Correo = @Correo " +
                    "WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        TxtNombre.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Apellido",
                        TxtApellido.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Documento",
                        TxtDocumento.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Telefono",
                        TxtTelefono.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Correo",
                        TxtCorreo.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@IdUsuario",
                        idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario actualizado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            BtnNuevo_Click(null, null);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                DgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?",
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
                    "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario eliminado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            BtnNuevo_Click(null, null);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDocumento.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();

            DgvUsuarios.ClearSelection();

            TxtNombre.Focus();
        }
    }
}
