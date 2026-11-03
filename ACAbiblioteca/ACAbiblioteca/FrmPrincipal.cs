using ACAbiblioteca.Datos;

namespace ACAbiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
           // Conexion conexion = new Conexion();
            //try

            //{
              //  using (var conn = conexion.ObtenerConexion())
                {
                //    conn.Open();
                  //  MessageBox.Show("Conexion a la base de datos establecida correctamente. ",
                    //    "ACAbiblioteca",
                      //MessageBoxButtons.OK,
                      //MessageBoxIcon.Information);
                //}
            }
            //catch (Exception ex) {
            
            //    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
              //  "ACAbiblioteca",
                //      MessageBoxButtons.OK,
                  //    MessageBoxIcon.Error);

            //}

            AbrirFormulario(new FrmInicio());
        }

        private void AbrirFormulario(Form formulario)
        {
            PnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PnlContenido.Controls.Add(formulario);
            formulario.Show();



        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInicio());
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibros());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAutores());
        }

        private void BtnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEditoriales());
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
