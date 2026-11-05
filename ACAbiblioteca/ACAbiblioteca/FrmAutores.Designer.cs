namespace ACAbiblioteca
{
    partial class FrmAutores
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
            LabelTitulo = new Label();
            PnlContenido = new Panel();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            LblApellido = new Label();
            LblNombre = new Label();
            PnlBotones = new Panel();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            DgvAutores = new DataGridView();
            PnlTitulo.SuspendLayout();
            PnlContenido.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvAutores).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.SkyBlue;
            PnlTitulo.Controls.Add(LabelTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(1327, 100);
            PnlTitulo.TabIndex = 0;
            // 
            // LabelTitulo
            // 
            LabelTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTitulo.ForeColor = Color.Transparent;
            LabelTitulo.Location = new Point(546, 27);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(279, 39);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "GESTION DE AUTORES";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlContenido
            // 
            PnlContenido.BackColor = SystemColors.ControlLight;
            PnlContenido.Controls.Add(TxtApellido);
            PnlContenido.Controls.Add(TxtNombre);
            PnlContenido.Controls.Add(LblApellido);
            PnlContenido.Controls.Add(LblNombre);
            PnlContenido.Dock = DockStyle.Top;
            PnlContenido.Location = new Point(0, 100);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(1327, 257);
            PnlContenido.TabIndex = 1;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(659, 159);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(193, 23);
            TxtApellido.TabIndex = 3;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(659, 78);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(193, 23);
            TxtNombre.TabIndex = 2;
            // 
            // LblApellido
            // 
            LblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblApellido.Location = new Point(463, 159);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(100, 23);
            LblApellido.TabIndex = 1;
            LblApellido.Text = "Apellido:";
            LblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            LblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(463, 78);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(100, 23);
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
            PnlBotones.Location = new Point(0, 357);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1327, 146);
            PnlBotones.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(976, 57);
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
            BtnEliminar.Location = new Point(789, 57);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(149, 40);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += btnEliminar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            BtnEditar.IconColor = Color.Black;
            BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditar.IconSize = 25;
            BtnEditar.Location = new Point(602, 57);
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
            BtnGuardar.Location = new Point(414, 57);
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
            BtnNuevo.Location = new Point(232, 57);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(149, 40);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += btnNuevo_Click;
            // 
            // DgvAutores
            // 
            DgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAutores.Location = new Point(194, 504);
            DgvAutores.Name = "DgvAutores";
            DgvAutores.Size = new Size(945, 255);
            DgvAutores.TabIndex = 3;
            DgvAutores.CellDoubleClick += DgvAutores_CellDoubleClick;
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 818);
            Controls.Add(DgvAutores);
            Controls.Add(PnlBotones);
            Controls.Add(PnlContenido);
            Controls.Add(PnlTitulo);
            Name = "FrmAutores";
            Text = "FrmAutores";
            Load += FrmAutores_Load;
            PnlTitulo.ResumeLayout(false);
            PnlContenido.ResumeLayout(false);
            PnlContenido.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvAutores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Panel PnlContenido;
        private Panel PnlBotones;
        private Label LabelTitulo;
        private Label LblNombre;
        private Label LblApellido;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private DataGridView DgvAutores;
    }
}