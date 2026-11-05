namespace ACAbiblioteca
{
    partial class FrmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlTitulo = new Panel();
            LblTitulo = new Label();
            PnlBusqueda = new Panel();
            BtnBuscar = new Button();
            TxtBuscarISBN = new TextBox();
            LblBuscar = new Label();
            PnlDatos = new Panel();
            CmbEditorial = new ComboBox();
            CmbAutor = new ComboBox();
            TxtExistencias = new TextBox();
            TxtAño = new TextBox();
            TxtCategoria = new TextBox();
            TxtTitulo = new TextBox();
            TxtISBN = new TextBox();
            LblExistencias = new Label();
            LblAño = new Label();
            LblCategoria = new Label();
            LblEditorial = new Label();
            LblAutor = new Label();
            LblTituloL = new Label();
            LblISBN = new Label();
            PnlBotones = new Panel();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            DgvLibros = new DataGridView();
            PnlTitulo.SuspendLayout();
            PnlBusqueda.SuspendLayout();
            PnlDatos.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLibros).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.SkyBlue;
            PnlTitulo.Controls.Add(LblTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(1327, 60);
            PnlTitulo.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(610, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(243, 32);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "GESTION DE LIBROS";
            // 
            // PnlBusqueda
            // 
            PnlBusqueda.BackColor = Color.WhiteSmoke;
            PnlBusqueda.Controls.Add(BtnBuscar);
            PnlBusqueda.Controls.Add(TxtBuscarISBN);
            PnlBusqueda.Controls.Add(LblBuscar);
            PnlBusqueda.Dock = DockStyle.Top;
            PnlBusqueda.Location = new Point(0, 60);
            PnlBusqueda.Name = "PnlBusqueda";
            PnlBusqueda.Size = new Size(1327, 74);
            PnlBusqueda.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(822, 24);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscarISBN
            // 
            TxtBuscarISBN.Location = new Point(628, 24);
            TxtBuscarISBN.Name = "TxtBuscarISBN";
            TxtBuscarISBN.Size = new Size(145, 23);
            TxtBuscarISBN.TabIndex = 1;
            TxtBuscarISBN.Click += BtnBuscar_Click;
            // 
            // LblBuscar
            // 
            LblBuscar.AutoSize = true;
            LblBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBuscar.Location = new Point(518, 32);
            LblBuscar.Name = "LblBuscar";
            LblBuscar.Size = new Size(34, 15);
            LblBuscar.TabIndex = 0;
            LblBuscar.Text = "ISBN";
            // 
            // PnlDatos
            // 
            PnlDatos.BackColor = SystemColors.ControlLight;
            PnlDatos.Controls.Add(CmbEditorial);
            PnlDatos.Controls.Add(CmbAutor);
            PnlDatos.Controls.Add(TxtExistencias);
            PnlDatos.Controls.Add(TxtAño);
            PnlDatos.Controls.Add(TxtCategoria);
            PnlDatos.Controls.Add(TxtTitulo);
            PnlDatos.Controls.Add(TxtISBN);
            PnlDatos.Controls.Add(LblExistencias);
            PnlDatos.Controls.Add(LblAño);
            PnlDatos.Controls.Add(LblCategoria);
            PnlDatos.Controls.Add(LblEditorial);
            PnlDatos.Controls.Add(LblAutor);
            PnlDatos.Controls.Add(LblTituloL);
            PnlDatos.Controls.Add(LblISBN);
            PnlDatos.Dock = DockStyle.Top;
            PnlDatos.Location = new Point(0, 134);
            PnlDatos.Name = "PnlDatos";
            PnlDatos.Size = new Size(1327, 359);
            PnlDatos.TabIndex = 2;
            // 
            // CmbEditorial
            // 
            CmbEditorial.FormattingEnabled = true;
            CmbEditorial.Location = new Point(660, 148);
            CmbEditorial.Name = "CmbEditorial";
            CmbEditorial.Size = new Size(171, 23);
            CmbEditorial.TabIndex = 16;
            // 
            // CmbAutor
            // 
            CmbAutor.FormattingEnabled = true;
            CmbAutor.Location = new Point(660, 101);
            CmbAutor.Name = "CmbAutor";
            CmbAutor.Size = new Size(171, 23);
            CmbAutor.TabIndex = 15;
            // 
            // TxtExistencias
            // 
            TxtExistencias.Location = new Point(660, 260);
            TxtExistencias.Name = "TxtExistencias";
            TxtExistencias.Size = new Size(171, 23);
            TxtExistencias.TabIndex = 14;
            // 
            // TxtAño
            // 
            TxtAño.Location = new Point(660, 221);
            TxtAño.Name = "TxtAño";
            TxtAño.Size = new Size(171, 23);
            TxtAño.TabIndex = 13;
            // 
            // TxtCategoria
            // 
            TxtCategoria.Location = new Point(660, 185);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(171, 23);
            TxtCategoria.TabIndex = 12;
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(660, 64);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(171, 23);
            TxtTitulo.TabIndex = 9;
            // 
            // TxtISBN
            // 
            TxtISBN.Location = new Point(660, 23);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(171, 23);
            TxtISBN.TabIndex = 8;
            // 
            // LblExistencias
            // 
            LblExistencias.AutoSize = true;
            LblExistencias.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblExistencias.Location = new Point(517, 268);
            LblExistencias.Name = "LblExistencias";
            LblExistencias.Size = new Size(67, 15);
            LblExistencias.TabIndex = 7;
            LblExistencias.Text = "Existencias:";
            // 
            // LblAño
            // 
            LblAño.AutoSize = true;
            LblAño.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAño.Location = new Point(552, 229);
            LblAño.Name = "LblAño";
            LblAño.Size = new Size(32, 15);
            LblAño.TabIndex = 6;
            LblAño.Text = "Año:";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCategoria.Location = new Point(524, 193);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(60, 15);
            LblCategoria.TabIndex = 5;
            LblCategoria.Text = "Categoria:";
            // 
            // LblEditorial
            // 
            LblEditorial.AutoSize = true;
            LblEditorial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEditorial.Location = new Point(533, 156);
            LblEditorial.Name = "LblEditorial";
            LblEditorial.Size = new Size(53, 15);
            LblEditorial.TabIndex = 4;
            LblEditorial.Text = "Editorial:";
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAutor.Location = new Point(546, 109);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(40, 15);
            LblAutor.TabIndex = 3;
            LblAutor.Text = "Autor:";
            // 
            // LblTituloL
            // 
            LblTituloL.AutoSize = true;
            LblTituloL.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTituloL.Location = new Point(547, 67);
            LblTituloL.Name = "LblTituloL";
            LblTituloL.Size = new Size(41, 15);
            LblTituloL.TabIndex = 2;
            LblTituloL.Text = "Titulo:";
            // 
            // LblISBN
            // 
            LblISBN.AutoSize = true;
            LblISBN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblISBN.Location = new Point(550, 31);
            LblISBN.Name = "LblISBN";
            LblISBN.Size = new Size(37, 15);
            LblISBN.TabIndex = 1;
            LblISBN.Text = "ISBN:";
            // 
            // PnlBotones
            // 
            PnlBotones.Controls.Add(BtnCancelar);
            PnlBotones.Controls.Add(BtnEliminar);
            PnlBotones.Controls.Add(BtnEditar);
            PnlBotones.Controls.Add(BtnGuardar);
            PnlBotones.Controls.Add(BtnNuevo);
            PnlBotones.Location = new Point(0, 480);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1327, 74);
            PnlBotones.TabIndex = 3;
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(1013, 19);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(149, 40);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Fire;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 25;
            BtnEliminar.Location = new Point(816, 19);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(149, 40);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            BtnEditar.IconColor = Color.Black;
            BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditar.IconSize = 25;
            BtnEditar.Location = new Point(610, 19);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(149, 40);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar";
            BtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnGuardar.IconSize = 25;
            BtnGuardar.Location = new Point(423, 19);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(149, 40);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Building;
            BtnNuevo.IconColor = Color.Black;
            BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnNuevo.IconSize = 25;
            BtnNuevo.Location = new Point(237, 19);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(149, 40);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click_1;
            // 
            // DgvLibros
            // 
            DgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLibros.Location = new Point(158, 560);
            DgvLibros.Name = "DgvLibros";
            DgvLibros.Size = new Size(1111, 260);
            DgvLibros.TabIndex = 4;
            DgvLibros.CellDoubleClick += DgvLibros_CellDoubleClick;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 818);
            Controls.Add(DgvLibros);
            Controls.Add(PnlBotones);
            Controls.Add(PnlDatos);
            Controls.Add(PnlBusqueda);
            Controls.Add(PnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            Load += FrmLibros_Load;
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            PnlBusqueda.ResumeLayout(false);
            PnlBusqueda.PerformLayout();
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Label LblTitulo;
        private Panel PnlBusqueda;
        private Button BtnBuscar;
        private TextBox TxtBuscarISBN;
        private Label LblBuscar;
        private Panel PnlDatos;
        private Label LblTituloL;
        private Label LblISBN;
        private Label LblAño;
        private Label LblCategoria;
        private Label LblEditorial;
        private Label LblAutor;
        private ComboBox CmbAutor;
        private TextBox TxtExistencias;
        private TextBox TxtAño;
        private TextBox TxtCategoria;
        private TextBox TxtTitulo;
        private TextBox TxtISBN;
        private Label LblExistencias;
        private ComboBox CmbEditorial;
        private Panel PnlBotones;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private DataGridView DgvLibros;
        
        private FontAwesome.Sharp.IconButton iconButton2;
        
    }
}