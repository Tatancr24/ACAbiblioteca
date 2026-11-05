namespace ACAbiblioteca
{
    partial class FrmUsuarios
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
            PnlDatos = new Panel();
            TxtCorreo = new TextBox();
            TxtTelefono = new TextBox();
            TxtDocumento = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            LblCorreo = new Label();
            LblTelefono = new Label();
            LblDocumento = new Label();
            LblApellido = new Label();
            LblNombre = new Label();
            PnlBotones = new Panel();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            DgvUsuarios = new DataGridView();
            PnlTitulo.SuspendLayout();
            PnlDatos.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).BeginInit();
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
            LblTitulo.BackColor = Color.SkyBlue;
            LblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.Transparent;
            LblTitulo.Location = new Point(548, 33);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(250, 32);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "GESTIÓN DE USUARIOS";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlDatos
            // 
            PnlDatos.BackColor = SystemColors.ControlLight;
            PnlDatos.Controls.Add(TxtCorreo);
            PnlDatos.Controls.Add(TxtTelefono);
            PnlDatos.Controls.Add(TxtDocumento);
            PnlDatos.Controls.Add(TxtApellido);
            PnlDatos.Controls.Add(TxtNombre);
            PnlDatos.Controls.Add(LblCorreo);
            PnlDatos.Controls.Add(LblTelefono);
            PnlDatos.Controls.Add(LblDocumento);
            PnlDatos.Controls.Add(LblApellido);
            PnlDatos.Controls.Add(LblNombre);
            PnlDatos.Dock = DockStyle.Top;
            PnlDatos.Location = new Point(0, 100);
            PnlDatos.Name = "PnlDatos";
            PnlDatos.Size = new Size(1327, 367);
            PnlDatos.TabIndex = 1;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(622, 285);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(263, 23);
            TxtCorreo.TabIndex = 9;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(622, 227);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(263, 23);
            TxtTelefono.TabIndex = 8;
            // 
            // TxtDocumento
            // 
            TxtDocumento.Location = new Point(622, 181);
            TxtDocumento.Name = "TxtDocumento";
            TxtDocumento.Size = new Size(263, 23);
            TxtDocumento.TabIndex = 7;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(622, 120);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(263, 23);
            TxtApellido.TabIndex = 6;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(622, 73);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(263, 23);
            TxtNombre.TabIndex = 5;
            // 
            // LblCorreo
            // 
            LblCorreo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCorreo.Location = new Point(462, 285);
            LblCorreo.Name = "LblCorreo";
            LblCorreo.Size = new Size(62, 23);
            LblCorreo.TabIndex = 4;
            LblCorreo.Text = "Correo:";
            LblCorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblTelefono
            // 
            LblTelefono.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTelefono.Location = new Point(462, 229);
            LblTelefono.Name = "LblTelefono";
            LblTelefono.Size = new Size(62, 21);
            LblTelefono.TabIndex = 3;
            LblTelefono.Text = "Telefono:";
            LblTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDocumento
            // 
            LblDocumento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDocumento.Location = new Point(462, 182);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new Size(71, 22);
            LblDocumento.TabIndex = 2;
            LblDocumento.Text = "Documento:";
            LblDocumento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblApellido
            // 
            LblApellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblApellido.Location = new Point(462, 121);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(62, 22);
            LblApellido.TabIndex = 1;
            LblApellido.Text = "Apellido:";
            LblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            LblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(462, 70);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(71, 26);
            LblNombre.TabIndex = 0;
            LblNombre.Text = "Nombre:";
            LblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlBotones
            // 
            PnlBotones.Controls.Add(BtnCancelar);
            PnlBotones.Controls.Add(BtnEliminar);
            PnlBotones.Controls.Add(BtnEditar);
            PnlBotones.Controls.Add(BtnGuardar);
            PnlBotones.Controls.Add(BtnNuevo);
            PnlBotones.Dock = DockStyle.Top;
            PnlBotones.Location = new Point(0, 467);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1327, 91);
            PnlBotones.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(1078, 32);
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
            BtnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Fire;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 25;
            BtnEliminar.Location = new Point(869, 32);
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
            BtnEditar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            BtnEditar.IconColor = Color.Black;
            BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditar.IconSize = 25;
            BtnEditar.Location = new Point(636, 32);
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
            BtnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 25;
            BtnGuardar.Location = new Point(399, 32);
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
            BtnNuevo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Building;
            BtnNuevo.IconColor = Color.Black;
            BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnNuevo.IconSize = 25;
            BtnNuevo.Location = new Point(141, 32);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(149, 40);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // DgvUsuarios
            // 
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuarios.Location = new Point(206, 559);
            DgvUsuarios.Name = "DgvUsuarios";
            DgvUsuarios.Size = new Size(969, 258);
            DgvUsuarios.TabIndex = 3;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 818);
            Controls.Add(DgvUsuarios);
            Controls.Add(PnlBotones);
            Controls.Add(PnlDatos);
            Controls.Add(PnlTitulo);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            PnlTitulo.ResumeLayout(false);
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Panel PnlDatos;
        private Panel PnlBotones;
        private Label LblTitulo;
        private Label LblDocumento;
        public Label LblApellido;
        private Label LblNombre;

        public Label LblCorreo;
        public Label LblTelefono;
        private TextBox TxtCorreo;
        private TextBox TxtTelefono;
        private TextBox TxtDocumento;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private DataGridView DgvUsuarios;
    }
}