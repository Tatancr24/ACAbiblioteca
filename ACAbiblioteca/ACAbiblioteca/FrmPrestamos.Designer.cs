namespace ACAbiblioteca
{
    partial class FrmPrestamos
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
            PnlContenido = new Panel();
            DtpFechaDevolucion = new DateTimePicker();
            DtpFechaPrestamo = new DateTimePicker();
            CmbLibro = new ComboBox();
            CmbUsuario = new ComboBox();
            LblFechaD = new Label();
            LblFechaP = new Label();
            LblLibro = new Label();
            LblUsuario = new Label();
            PnlBotones = new Panel();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            DgvPrestamos = new DataGridView();
            PnlTitulo.SuspendLayout();
            PnlContenido.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.SkyBlue;
            PnlTitulo.Controls.Add(LblTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(1327, 100);
            PnlTitulo.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Transparent;
            LblTitulo.Location = new Point(569, 30);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(279, 39);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "GESTION DE PRESTAMOS";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlContenido
            // 
            PnlContenido.BackColor = SystemColors.ControlLight;
            PnlContenido.Controls.Add(DtpFechaDevolucion);
            PnlContenido.Controls.Add(DtpFechaPrestamo);
            PnlContenido.Controls.Add(CmbLibro);
            PnlContenido.Controls.Add(CmbUsuario);
            PnlContenido.Controls.Add(LblFechaD);
            PnlContenido.Controls.Add(LblFechaP);
            PnlContenido.Controls.Add(LblLibro);
            PnlContenido.Controls.Add(LblUsuario);
            PnlContenido.Dock = DockStyle.Top;
            PnlContenido.Location = new Point(0, 100);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(1327, 314);
            PnlContenido.TabIndex = 1;
            // 
            // DtpFechaDevolucion
            // 
            DtpFechaDevolucion.Location = new Point(662, 224);
            DtpFechaDevolucion.Name = "DtpFechaDevolucion";
            DtpFechaDevolucion.Size = new Size(219, 23);
            DtpFechaDevolucion.TabIndex = 7;
            // 
            // DtpFechaPrestamo
            // 
            DtpFechaPrestamo.Location = new Point(662, 162);
            DtpFechaPrestamo.Name = "DtpFechaPrestamo";
            DtpFechaPrestamo.Size = new Size(219, 23);
            DtpFechaPrestamo.TabIndex = 6;
            // 
            // CmbLibro
            // 
            CmbLibro.FormattingEnabled = true;
            CmbLibro.Location = new Point(662, 107);
            CmbLibro.Name = "CmbLibro";
            CmbLibro.Size = new Size(219, 23);
            CmbLibro.TabIndex = 5;
            // 
            // CmbUsuario
            // 
            CmbUsuario.FormattingEnabled = true;
            CmbUsuario.Location = new Point(662, 56);
            CmbUsuario.Name = "CmbUsuario";
            CmbUsuario.Size = new Size(219, 23);
            CmbUsuario.TabIndex = 4;
            // 
            // LblFechaD
            // 
            LblFechaD.AutoSize = true;
            LblFechaD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFechaD.Location = new Point(462, 224);
            LblFechaD.Name = "LblFechaD";
            LblFechaD.Size = new Size(150, 21);
            LblFechaD.TabIndex = 3;
            LblFechaD.Text = "Fecha Devolución:";
            // 
            // LblFechaP
            // 
            LblFechaP.AutoSize = true;
            LblFechaP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFechaP.Location = new Point(462, 162);
            LblFechaP.Name = "LblFechaP";
            LblFechaP.Size = new Size(134, 21);
            LblFechaP.TabIndex = 2;
            LblFechaP.Text = "Fecha Préstamo:";
            // 
            // LblLibro
            // 
            LblLibro.AutoSize = true;
            LblLibro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLibro.Location = new Point(462, 102);
            LblLibro.Name = "LblLibro";
            LblLibro.Size = new Size(53, 21);
            LblLibro.TabIndex = 1;
            LblLibro.Text = "Libro:";
            LblLibro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            LblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUsuario.Location = new Point(462, 54);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(100, 23);
            LblUsuario.TabIndex = 0;
            LblUsuario.Text = "Usuario: ";
            // 
            // PnlBotones
            // 
            PnlBotones.Controls.Add(BtnCancelar);
            PnlBotones.Controls.Add(BtnEliminar);
            PnlBotones.Controls.Add(BtnEditar);
            PnlBotones.Controls.Add(BtnGuardar);
            PnlBotones.Controls.Add(BtnNuevo);
            PnlBotones.Dock = DockStyle.Top;
            PnlBotones.Location = new Point(0, 414);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1327, 134);
            PnlBotones.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(1038, 59);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(149, 40);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += btnCancelar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Fire;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 25;
            BtnEliminar.Location = new Point(825, 59);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(149, 40);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += btnEditar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            BtnEditar.IconColor = Color.Black;
            BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditar.IconSize = 25;
            BtnEditar.Location = new Point(626, 59);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(149, 40);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar";
            BtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += btnEditar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 25;
            BtnGuardar.Location = new Point(413, 59);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(149, 40);
            BtnGuardar.TabIndex = 1;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += btnGuardar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Building;
            BtnNuevo.IconColor = Color.Black;
            BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnNuevo.IconSize = 25;
            BtnNuevo.Location = new Point(204, 59);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(149, 40);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += btnNuevo_Click;
            // 
            // DgvPrestamos
            // 
            DgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPrestamos.Location = new Point(122, 554);
            DgvPrestamos.Name = "DgvPrestamos";
            DgvPrestamos.Size = new Size(1086, 238);
            DgvPrestamos.TabIndex = 3;
            DgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 818);
            Controls.Add(DgvPrestamos);
            Controls.Add(PnlBotones);
            Controls.Add(PnlContenido);
            Controls.Add(PnlTitulo);
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            PnlTitulo.ResumeLayout(false);
            PnlContenido.ResumeLayout(false);
            PnlContenido.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Panel PnlContenido;
        private Panel PnlBotones;
        private DataGridView DgvPrestamos;
        private Label LblTitulo;
        private Label LblUsuario;
        private Label LblFechaP;
        private Label LblLibro;
        private Label LblFechaD;
        private ComboBox CmbUsuario;
        private DateTimePicker DtpFechaDevolucion;
        private DateTimePicker DtpFechaPrestamo;
        private ComboBox CmbLibro;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
    }
}