namespace ACAbiblioteca
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
            PnlMenu = new Panel();
            BtnSalida = new FontAwesome.Sharp.IconButton();
            BtnReportes = new FontAwesome.Sharp.IconButton();
            BtnPrestamos = new FontAwesome.Sharp.IconButton();
            BtnEditoriales = new FontAwesome.Sharp.IconButton();
            BtnAutores = new FontAwesome.Sharp.IconButton();
            BtnUsuarios = new FontAwesome.Sharp.IconButton();
            BtnLibros = new FontAwesome.Sharp.IconButton();
            BtnInicio = new FontAwesome.Sharp.IconButton();
            PnlLogo = new Panel();
            PicLogo = new PictureBox();
            LblSubtitulos = new Label();
            LblTitulo = new Label();
            PnlSuperior = new Panel();
            PnlEstado = new Panel();
            PnlContenido = new Panel();
            PnlMenu.SuspendLayout();
            PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlMenu
            // 
            PnlMenu.BackColor = Color.SteelBlue;
            PnlMenu.Controls.Add(BtnSalida);
            PnlMenu.Controls.Add(BtnReportes);
            PnlMenu.Controls.Add(BtnPrestamos);
            PnlMenu.Controls.Add(BtnEditoriales);
            PnlMenu.Controls.Add(BtnAutores);
            PnlMenu.Controls.Add(BtnUsuarios);
            PnlMenu.Controls.Add(BtnLibros);
            PnlMenu.Controls.Add(BtnInicio);
            PnlMenu.Controls.Add(PnlLogo);
            PnlMenu.Dock = DockStyle.Left;
            PnlMenu.Location = new Point(0, 0);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(290, 611);
            PnlMenu.TabIndex = 1;
            // 
            // BtnSalida
            // 
            BtnSalida.AutoSize = true;
            BtnSalida.BackColor = Color.Azure;
            BtnSalida.Dock = DockStyle.Top;
            BtnSalida.FlatAppearance.BorderSize = 0;
            BtnSalida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalida.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            BtnSalida.IconColor = Color.Black;
            BtnSalida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalida.IconSize = 30;
            BtnSalida.Location = new Point(0, 395);
            BtnSalida.Margin = new Padding(0, 10, 0, 10);
            BtnSalida.Name = "BtnSalida";
            BtnSalida.Size = new Size(290, 45);
            BtnSalida.TabIndex = 8;
            BtnSalida.Text = "Salida";
            BtnSalida.TextAlign = ContentAlignment.MiddleRight;
            BtnSalida.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalida.UseVisualStyleBackColor = false;
            // 
            // BtnReportes
            // 
            BtnReportes.AutoSize = true;
            BtnReportes.BackColor = Color.Azure;
            BtnReportes.Dock = DockStyle.Top;
            BtnReportes.FlatAppearance.BorderSize = 0;
            BtnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReportes.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            BtnReportes.IconColor = Color.Black;
            BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnReportes.IconSize = 30;
            BtnReportes.Location = new Point(0, 350);
            BtnReportes.Margin = new Padding(0, 10, 0, 10);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(290, 45);
            BtnReportes.TabIndex = 7;
            BtnReportes.Text = "Reportes";
            BtnReportes.TextAlign = ContentAlignment.MiddleRight;
            BtnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReportes.UseVisualStyleBackColor = false;
            // 
            // BtnPrestamos
            // 
            BtnPrestamos.AutoSize = true;
            BtnPrestamos.BackColor = Color.Azure;
            BtnPrestamos.Dock = DockStyle.Top;
            BtnPrestamos.FlatAppearance.BorderSize = 0;
            BtnPrestamos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrestamos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            BtnPrestamos.IconColor = Color.Black;
            BtnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnPrestamos.IconSize = 30;
            BtnPrestamos.Location = new Point(0, 305);
            BtnPrestamos.Margin = new Padding(0, 10, 0, 10);
            BtnPrestamos.Name = "BtnPrestamos";
            BtnPrestamos.Size = new Size(290, 45);
            BtnPrestamos.TabIndex = 6;
            BtnPrestamos.Text = "Prestamos";
            BtnPrestamos.TextAlign = ContentAlignment.MiddleRight;
            BtnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrestamos.UseVisualStyleBackColor = false;
            // 
            // BtnEditoriales
            // 
            BtnEditoriales.AutoSize = true;
            BtnEditoriales.BackColor = Color.Azure;
            BtnEditoriales.Dock = DockStyle.Top;
            BtnEditoriales.FlatAppearance.BorderSize = 0;
            BtnEditoriales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditoriales.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            BtnEditoriales.IconColor = Color.Black;
            BtnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditoriales.IconSize = 30;
            BtnEditoriales.Location = new Point(0, 260);
            BtnEditoriales.Margin = new Padding(0, 10, 0, 10);
            BtnEditoriales.Name = "BtnEditoriales";
            BtnEditoriales.Size = new Size(290, 45);
            BtnEditoriales.TabIndex = 5;
            BtnEditoriales.Text = "Editoriales";
            BtnEditoriales.TextAlign = ContentAlignment.MiddleRight;
            BtnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditoriales.UseVisualStyleBackColor = false;
            BtnEditoriales.Click += BtnEditoriales_Click;
            // 
            // BtnAutores
            // 
            BtnAutores.AutoSize = true;
            BtnAutores.BackColor = Color.Azure;
            BtnAutores.Dock = DockStyle.Top;
            BtnAutores.FlatAppearance.BorderSize = 0;
            BtnAutores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAutores.IconChar = FontAwesome.Sharp.IconChar.Pen;
            BtnAutores.IconColor = Color.Black;
            BtnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAutores.IconSize = 30;
            BtnAutores.Location = new Point(0, 215);
            BtnAutores.Margin = new Padding(0, 10, 0, 10);
            BtnAutores.Name = "BtnAutores";
            BtnAutores.Size = new Size(290, 45);
            BtnAutores.TabIndex = 4;
            BtnAutores.Text = "Autores";
            BtnAutores.TextAlign = ContentAlignment.MiddleRight;
            BtnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAutores.UseVisualStyleBackColor = false;
            BtnAutores.Click += BtnAutores_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.AutoSize = true;
            BtnUsuarios.BackColor = Color.Azure;
            BtnUsuarios.Dock = DockStyle.Top;
            BtnUsuarios.FlatAppearance.BorderSize = 0;
            BtnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            BtnUsuarios.IconColor = Color.Black;
            BtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUsuarios.IconSize = 30;
            BtnUsuarios.Location = new Point(0, 170);
            BtnUsuarios.Margin = new Padding(0, 10, 0, 10);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(290, 45);
            BtnUsuarios.TabIndex = 3;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            BtnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnLibros
            // 
            BtnLibros.AutoSize = true;
            BtnLibros.BackColor = Color.Azure;
            BtnLibros.Cursor = Cursors.Hand;
            BtnLibros.Dock = DockStyle.Top;
            BtnLibros.FlatAppearance.BorderSize = 0;
            BtnLibros.FlatStyle = FlatStyle.Flat;
            BtnLibros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnLibros.IconColor = Color.Black;
            BtnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLibros.IconSize = 30;
            BtnLibros.Location = new Point(0, 125);
            BtnLibros.Margin = new Padding(0, 10, 0, 10);
            BtnLibros.Name = "BtnLibros";
            BtnLibros.Size = new Size(290, 45);
            BtnLibros.TabIndex = 2;
            BtnLibros.Text = "Libros";
            BtnLibros.TextAlign = ContentAlignment.MiddleRight;
            BtnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLibros.UseVisualStyleBackColor = false;
            BtnLibros.Click += BtnLibros_Click;
            // 
            // BtnInicio
            // 
            BtnInicio.AutoSize = true;
            BtnInicio.BackColor = Color.Azure;
            BtnInicio.Dock = DockStyle.Top;
            BtnInicio.FlatAppearance.BorderSize = 0;
            BtnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            BtnInicio.IconColor = Color.Black;
            BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnInicio.IconSize = 30;
            BtnInicio.Location = new Point(0, 80);
            BtnInicio.Margin = new Padding(0, 10, 0, 10);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(290, 45);
            BtnInicio.TabIndex = 1;
            BtnInicio.Text = "Inicio";
            BtnInicio.TextAlign = ContentAlignment.MiddleRight;
            BtnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnInicio.UseVisualStyleBackColor = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // PnlLogo
            // 
            PnlLogo.BackColor = Color.CornflowerBlue;
            PnlLogo.Controls.Add(PicLogo);
            PnlLogo.Controls.Add(LblSubtitulos);
            PnlLogo.Controls.Add(LblTitulo);
            PnlLogo.Dock = DockStyle.Top;
            PnlLogo.Location = new Point(0, 0);
            PnlLogo.Name = "PnlLogo";
            PnlLogo.Size = new Size(290, 80);
            PnlLogo.TabIndex = 0;
            // 
            // PicLogo
            // 
            PicLogo.BackColor = Color.Transparent;
            PicLogo.Image = Properties.Resources._201571;
            PicLogo.Location = new Point(12, 9);
            PicLogo.Name = "PicLogo";
            PicLogo.Size = new Size(103, 60);
            PicLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PicLogo.TabIndex = 2;
            PicLogo.TabStop = false;
            // 
            // LblSubtitulos
            // 
            LblSubtitulos.AutoSize = true;
            LblSubtitulos.BackColor = Color.Transparent;
            LblSubtitulos.Font = new Font("Corbel", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LblSubtitulos.ForeColor = Color.WhiteSmoke;
            LblSubtitulos.Location = new Point(125, 35);
            LblSubtitulos.Name = "LblSubtitulos";
            LblSubtitulos.Size = new Size(159, 23);
            LblSubtitulos.TabIndex = 1;
            LblSubtitulos.Text = "Sistema De Gestion";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = SystemColors.ButtonHighlight;
            LblTitulo.Location = new Point(133, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(125, 26);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "BIBLIOTECA";
            // 
            // PnlSuperior
            // 
            PnlSuperior.BackColor = SystemColors.ControlLight;
            PnlSuperior.Dock = DockStyle.Top;
            PnlSuperior.Location = new Point(290, 0);
            PnlSuperior.Name = "PnlSuperior";
            PnlSuperior.Size = new Size(1074, 80);
            PnlSuperior.TabIndex = 2;
            // 
            // PnlEstado
            // 
            PnlEstado.BackColor = SystemColors.AppWorkspace;
            PnlEstado.Dock = DockStyle.Bottom;
            PnlEstado.Location = new Point(290, 555);
            PnlEstado.Name = "PnlEstado";
            PnlEstado.Size = new Size(1074, 56);
            PnlEstado.TabIndex = 3;
            // 
            // PnlContenido
            // 
            PnlContenido.Dock = DockStyle.Fill;
            PnlContenido.Location = new Point(290, 80);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(1074, 475);
            PnlContenido.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 611);
            Controls.Add(PnlContenido);
            Controls.Add(PnlEstado);
            Controls.Add(PnlSuperior);
            Controls.Add(PnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestion de Biblioteca";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            PnlMenu.ResumeLayout(false);
            PnlMenu.PerformLayout();
            PnlLogo.ResumeLayout(false);
            PnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMenu;
        private Panel PnlSuperior;
        private Panel PnlEstado;
        private Panel PnlLogo;
        private Label LblTitulo;
        private Label LblSubtitulos;
        private PictureBox PicLogo;
        private Panel PnlContenido;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private FontAwesome.Sharp.IconButton BtnLibros;
        private FontAwesome.Sharp.IconButton BtnAutores;
        private FontAwesome.Sharp.IconButton BtnUsuarios;
        private FontAwesome.Sharp.IconButton BtnPrestamos;
        private FontAwesome.Sharp.IconButton BtnEditoriales;
        private FontAwesome.Sharp.IconButton BtnSalida;
        private FontAwesome.Sharp.IconButton BtnReportes;
    }
}
