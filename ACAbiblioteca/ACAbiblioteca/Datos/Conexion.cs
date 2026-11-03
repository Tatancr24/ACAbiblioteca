using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ACAbiblioteca.Datos
{
    public class Conexion
    {
        private string cadenaConexion = "server=localhost;Database=ACAbiblioteca;Integrated Security=true;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);

        }

    }
}
