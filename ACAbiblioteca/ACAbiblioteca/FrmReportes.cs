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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
            CargarTiposReporte();
        }

        private void CargarTiposReporte()
        {
            CmbTipoReporte.Items.Clear();

            CmbTipoReporte.Items.Add("Préstamos activos");
            CmbTipoReporte.Items.Add("Préstamos devueltos");
            CmbTipoReporte.Items.Add("Inventario de libros");

            CmbTipoReporte.SelectedIndex = -1;
        }

        // *** Código btnGenerar_Click ***

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbTipoReporte.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de reporte.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "";

                    if (CmbTipoReporte.Text == "Préstamos activos")
                    {
                        consulta = @"SELECT
                                p.IdPrestamo,
                                u.Nombre + ' ' + u.Apellido AS Usuario,
                                l.ISBN,
                                l.Titulo,
                                p.FechaPrestamo,
                                p.Estado
                             FROM Prestamos p
                             INNER JOIN Usuarios u
                                ON p.IdUsuario = u.IdUsuario
                             INNER JOIN Libros l
                                ON p.ISBN = l.ISBN
                             WHERE p.Estado = 'Prestado'
                             ORDER BY p.FechaPrestamo DESC";
                    }
                    else if (CmbTipoReporte.Text == "Préstamos devueltos")
                    {
                        consulta = @"SELECT
                                p.IdPrestamo,
                                u.Nombre + ' ' + u.Apellido AS Usuario,
                                l.ISBN,
                                l.Titulo,
                                p.FechaPrestamo,
                                p.FechaDevolucion,
                                p.Estado
                             FROM Prestamos p
                             INNER JOIN Usuarios u
                                ON p.IdUsuario = u.IdUsuario
                             INNER JOIN Libros l
                                ON p.ISBN = l.ISBN
                             WHERE p.Estado = 'Devuelto'
                             ORDER BY p.FechaDevolucion DESC";
                    }
                    else if (CmbTipoReporte.Text == "Inventario de libros")
                    {
                        consulta = @"SELECT
                                l.ISBN,
                                l.Titulo,
                                a.Nombre + ' ' + a.Apellido AS Autor,
                                e.Nombre AS Editorial,
                                l.Categoria,
                                l.Anio,
                                l.Existencias
                             FROM Libros l
                             INNER JOIN Autores a
                                ON l.IdAutor = a.IdAutor
                             INNER JOIN Editoriales e
                                ON l.IdEditorial = e.IdEditorial
                             ORDER BY l.Titulo";
                    }

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        DgvReportes.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // *** Código btnLimpiar_Click ***

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CmbTipoReporte.SelectedIndex = -1;

            DgvReportes.DataSource = null;
        }
    }
}
