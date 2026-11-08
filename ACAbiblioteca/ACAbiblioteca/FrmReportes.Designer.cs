namespace ACAbiblioteca
{
    partial class FrmReportes
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
            CmbTipoReporte = new ComboBox();
            LblTipoReporte = new Label();
            PnlBotones = new Panel();
            BtnLimpiar = new FontAwesome.Sharp.IconButton();
            BtnGenerarReporte = new FontAwesome.Sharp.IconButton();
            DgvReportes = new DataGridView();
            PnlTitulo.SuspendLayout();
            PnlContenido.SuspendLayout();
            PnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvReportes).BeginInit();
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
            LblTitulo.Location = new Point(534, 28);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(279, 39);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "GESTIÓN DE REPORTES";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PnlContenido
            // 
            PnlContenido.BackColor = SystemColors.ControlLight;
            PnlContenido.Controls.Add(CmbTipoReporte);
            PnlContenido.Controls.Add(LblTipoReporte);
            PnlContenido.Dock = DockStyle.Top;
            PnlContenido.Location = new Point(0, 100);
            PnlContenido.Name = "PnlContenido";
            PnlContenido.Size = new Size(1327, 193);
            PnlContenido.TabIndex = 1;
            // 
            // CmbTipoReporte
            // 
            CmbTipoReporte.FormattingEnabled = true;
            CmbTipoReporte.Location = new Point(680, 81);
            CmbTipoReporte.Name = "CmbTipoReporte";
            CmbTipoReporte.Size = new Size(275, 23);
            CmbTipoReporte.TabIndex = 1;
            // 
            // LblTipoReporte
            // 
            LblTipoReporte.AutoSize = true;
            LblTipoReporte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTipoReporte.Location = new Point(483, 81);
            LblTipoReporte.Name = "LblTipoReporte";
            LblTipoReporte.Size = new Size(135, 21);
            LblTipoReporte.TabIndex = 0;
            LblTipoReporte.Text = "Tipo de Reporte:";
            // 
            // PnlBotones
            // 
            PnlBotones.Controls.Add(BtnLimpiar);
            PnlBotones.Controls.Add(BtnGenerarReporte);
            PnlBotones.Dock = DockStyle.Top;
            PnlBotones.Location = new Point(0, 293);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(1327, 114);
            PnlBotones.TabIndex = 2;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            BtnLimpiar.IconColor = Color.Black;
            BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLimpiar.IconSize = 25;
            BtnLimpiar.Location = new Point(806, 38);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(149, 40);
            BtnLimpiar.TabIndex = 1;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += btnLimpiar_Click;
            // 
            // BtnGenerarReporte
            // 
            BtnGenerarReporte.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            BtnGenerarReporte.IconColor = Color.Black;
            BtnGenerarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGenerarReporte.IconSize = 25;
            BtnGenerarReporte.Location = new Point(602, 38);
            BtnGenerarReporte.Name = "BtnGenerarReporte";
            BtnGenerarReporte.Size = new Size(149, 40);
            BtnGenerarReporte.TabIndex = 0;
            BtnGenerarReporte.Text = "Generar Reporte";
            BtnGenerarReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGenerarReporte.UseVisualStyleBackColor = true;
            BtnGenerarReporte.Click += btnGenerar_Click;
            // 
            // DgvReportes
            // 
            DgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvReportes.Location = new Point(237, 413);
            DgvReportes.Name = "DgvReportes";
            DgvReportes.Size = new Size(889, 207);
            DgvReportes.TabIndex = 3;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 818);
            Controls.Add(DgvReportes);
            Controls.Add(PnlBotones);
            Controls.Add(PnlContenido);
            Controls.Add(PnlTitulo);
            Name = "FrmReportes";
            Text = "FrmReportes";
            PnlTitulo.ResumeLayout(false);
            PnlContenido.ResumeLayout(false);
            PnlContenido.PerformLayout();
            PnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Label LblTitulo;
        private Panel PnlContenido;
        private Panel PnlBotones;
        private DataGridView DgvReportes;
        private Label LblTipoReporte;
        private ComboBox CmbTipoReporte;
        private FontAwesome.Sharp.IconButton BtnGenerarReporte;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
    }
}