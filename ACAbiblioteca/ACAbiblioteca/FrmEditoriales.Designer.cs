namespace ACAbiblioteca
{
    partial class FrmEditoriales
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
            TxtNombre = new TextBox();
            LblNombre = new Label();
            PnlBotones = new Panel();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnEditar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            DgvEditoriales = new DataGridView();
            PnlTitulo.SuspendLayout();
            PnlContenido.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEditoriales).BeginInit();
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
            LblTitulo.Location = new Point(547, 26);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(279, 39);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "GESTION DE EDITORIALES";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlContenido
            // 
            PnlContenido.BackColor = SystemColors.ControlLight;
            PnlContenido.Controls.Add(TxtNombre);
            PnlContenido.Controls.Add(LblNombre);
            PnlContenido.Dock = DockStyle.Top;
            PnlContenido.Location = new Point(0, 100);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(1327, 209);
            PnlContenido.TabIndex = 1;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(617, 92);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(194, 23);
            TxtNombre.TabIndex = 1;
            // 
            // LblNombre
            // 
            LblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(475, 92);
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
            PnlBotones.Location = new Point(0, 309);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1327, 159);
            PnlBotones.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 25;
            BtnCancelar.Location = new Point(993, 63);
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
            BtnEliminar.Location = new Point(794, 63);
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
            BtnEditar.Location = new Point(596, 63);
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
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 25;
            BtnGuardar.Location = new Point(402, 63);
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
            BtnNuevo.Location = new Point(214, 63);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(149, 40);
            BtnNuevo.TabIndex = 0;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // DgvEditoriales
            // 
            DgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEditoriales.Location = new Point(186, 466);
            DgvEditoriales.Name = "DgvEditoriales";
            DgvEditoriales.Size = new Size(992, 243);
            DgvEditoriales.TabIndex = 3;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 818);
            Controls.Add(DgvEditoriales);
            Controls.Add(PnlBotones);
            Controls.Add(PnlContenido);
            Controls.Add(PnlTitulo);
            Name = "FrmEditoriales";
            Text = "FrmEditoriales";
            PnlTitulo.ResumeLayout(false);
            PnlContenido.ResumeLayout(false);
            PnlContenido.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Panel PnlContenido;
        private Panel PnlBotones;
        private Label LblTitulo;
        private Label LblNombre;
        private TextBox TxtNombre;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private DataGridView DgvEditoriales;
    }
}