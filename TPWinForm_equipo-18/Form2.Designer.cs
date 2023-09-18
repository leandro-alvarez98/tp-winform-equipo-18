namespace TPWinForm_equipo_18
{
    partial class VentanaAñadirArticulo
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.txtbxUrlImagen = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.Lbl_error_precio = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LblCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblCodigo.Location = new System.Drawing.Point(65, 61);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(133, 21);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo Articulo";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblNombre.Location = new System.Drawing.Point(69, 128);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(73, 21);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblDescripcion.Location = new System.Drawing.Point(68, 503);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.BackColor = System.Drawing.Color.Transparent;
            this.LblMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblMarca.Location = new System.Drawing.Point(69, 202);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(62, 21);
            this.LblMarca.TabIndex = 3;
            this.LblMarca.Text = "Marca";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.LblCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblCategoria.Location = new System.Drawing.Point(70, 275);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(91, 21);
            this.LblCategoria.TabIndex = 4;
            this.LblCategoria.Text = "Categoria";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPrecio.Location = new System.Drawing.Point(74, 351);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(57, 21);
            this.LblPrecio.TabIndex = 5;
            this.LblPrecio.Text = "Precio";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.Silver;
            this.TxtCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(224, 58);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodigo.MaxLength = 50;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(294, 27);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.UseWaitCursor = true;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtDescripcion.Location = new System.Drawing.Point(69, 528);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescripcion.MaxLength = 150;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(430, 145);
            this.TxtDescripcion.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.Silver;
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(224, 125);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(294, 27);
            this.TxtNombre.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(552, 641);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 32);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Modificar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.BtnCancelar.Location = new System.Drawing.Point(785, 641);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 32);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CbxMarca
            // 
            this.CbxMarca.BackColor = System.Drawing.Color.Silver;
            this.CbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.Location = new System.Drawing.Point(224, 199);
            this.CbxMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(294, 29);
            this.CbxMarca.TabIndex = 2;
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.BackColor = System.Drawing.Color.Silver;
            this.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(224, 272);
            this.CbxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(294, 29);
            this.CbxCategoria.TabIndex = 3;
            // 
            // PbxImagen
            // 
            this.PbxImagen.BackColor = System.Drawing.Color.Transparent;
            this.PbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxImagen.Location = new System.Drawing.Point(552, 58);
            this.PbxImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(390, 399);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 13;
            this.PbxImagen.TabStop = false;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.Color.Silver;
            this.TxtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(224, 351);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(294, 27);
            this.TxtPrecio.TabIndex = 4;
            // 
            // txtbxUrlImagen
            // 
            this.txtbxUrlImagen.BackColor = System.Drawing.Color.Silver;
            this.txtbxUrlImagen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUrlImagen.Location = new System.Drawing.Point(224, 427);
            this.txtbxUrlImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxUrlImagen.Name = "txtbxUrlImagen";
            this.txtbxUrlImagen.Size = new System.Drawing.Size(236, 27);
            this.txtbxUrlImagen.TabIndex = 5;
            this.txtbxUrlImagen.Leave += new System.EventHandler(this.txtbxUrlImagen_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblUrlImagen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUrlImagen.Location = new System.Drawing.Point(69, 427);
            this.lblUrlImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(91, 21);
            this.lblUrlImagen.TabIndex = 15;
            this.lblUrlImagen.Text = "UrlImagen";
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Location = new System.Drawing.Point(480, 428);
            this.BtnCargarImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(38, 26);
            this.BtnCargarImagen.TabIndex = 16;
            this.BtnCargarImagen.Text = " +";
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // Lbl_error_precio
            // 
            this.Lbl_error_precio.AutoSize = true;
            this.Lbl_error_precio.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_error_precio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_error_precio.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_error_precio.Location = new System.Drawing.Point(235, 383);
            this.Lbl_error_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_error_precio.Name = "Lbl_error_precio";
            this.Lbl_error_precio.Size = new System.Drawing.Size(114, 21);
            this.Lbl_error_precio.TabIndex = 18;
            this.Lbl_error_precio.Text = "mensaje error";
            this.Lbl_error_precio.Visible = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(955, 40);
            this.Header.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 652);
            this.panel1.TabIndex = 20;
            // 
            // VentanaAñadirArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(955, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Lbl_error_precio);
            this.Controls.Add(this.BtnCargarImagen);
            this.Controls.Add(this.txtbxUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.CbxMarca);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(971, 731);
            this.MinimumSize = new System.Drawing.Size(971, 731);
            this.Name = "VentanaAñadirArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Articulos";
            this.Load += new System.EventHandler(this.VentanaAñadirArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CbxMarca;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox txtbxUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.Label Lbl_error_precio;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel1;
    }
}