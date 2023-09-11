namespace TPWinForm_equipo_18
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                 components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCambiarImagen = new System.Windows.Forms.Button();
            this.DgwListaArticulos = new System.Windows.Forms.DataGridView();
            this.CbxCategorias = new System.Windows.Forms.ComboBox();
            this.LblBusqueda = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.Cbx = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ImgLmagenes = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaArticulos)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(44, 117);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 39);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(44, 247);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(80, 37);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(44, 384);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(80, 43);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnCambiarImagen
            // 
            this.BtnCambiarImagen.Location = new System.Drawing.Point(998, 564);
            this.BtnCambiarImagen.Name = "BtnCambiarImagen";
            this.BtnCambiarImagen.Size = new System.Drawing.Size(111, 25);
            this.BtnCambiarImagen.TabIndex = 3;
            this.BtnCambiarImagen.Text = "Cambiar Imagen";
            this.BtnCambiarImagen.UseVisualStyleBackColor = true;
            // 
            // DgwListaArticulos
            // 
            this.DgwListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwListaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgwListaArticulos.Location = new System.Drawing.Point(248, 117);
            this.DgwListaArticulos.Name = "DgwListaArticulos";
            this.DgwListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwListaArticulos.Size = new System.Drawing.Size(861, 294);
            this.DgwListaArticulos.TabIndex = 4;
            this.DgwListaArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwListaArticulos_CellContentClick);
            // 
            // CbxCategorias
            // 
            this.CbxCategorias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxCategorias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxCategorias.FormattingEnabled = true;
            this.CbxCategorias.Items.AddRange(new object[] {
            "manzana",
            "maranja"});
            this.CbxCategorias.Location = new System.Drawing.Point(720, 61);
            this.CbxCategorias.Name = "CbxCategorias";
            this.CbxCategorias.Size = new System.Drawing.Size(121, 21);
            this.CbxCategorias.TabIndex = 5;
            // 
            // LblBusqueda
            // 
            this.LblBusqueda.AutoSize = true;
            this.LblBusqueda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblBusqueda.Location = new System.Drawing.Point(245, 26);
            this.LblBusqueda.Name = "LblBusqueda";
            this.LblBusqueda.Size = new System.Drawing.Size(82, 13);
            this.LblBusqueda.TabIndex = 6;
            this.LblBusqueda.Text = "Buscar articulos";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(248, 61);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(409, 20);
            this.TxtBuscar.TabIndex = 7;
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Location = new System.Drawing.Point(717, 26);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(57, 13);
            this.LblCategorias.TabIndex = 8;
            this.LblCategorias.Text = "Categorias";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(939, 26);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(37, 13);
            this.LblMarca.TabIndex = 10;
            this.LblMarca.Text = "Marca";
            // 
            // Cbx
            // 
            this.Cbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cbx.FormattingEnabled = true;
            this.Cbx.Items.AddRange(new object[] {
            "manzana",
            "maranja"});
            this.Cbx.Location = new System.Drawing.Point(942, 61);
            this.Cbx.Name = "Cbx";
            this.Cbx.Size = new System.Drawing.Size(121, 21);
            this.Cbx.TabIndex = 13;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.BtnModificar);
            this.Panel1.Controls.Add(this.BtnEliminar);
            this.Panel1.Controls.Add(this.BtnAgregar);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(186, 639);
            this.Panel1.TabIndex = 14;
            // 
            // ImgLmagenes
            // 
            this.ImgLmagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImgLmagenes.ImageSize = new System.Drawing.Size(100, 100);
            this.ImgLmagenes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(319, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "aca podria ir  una lista de imagenes entonces podemos mostrar todas las imagenes " +
    "que querramos pero bueno cambiandolas con el boton so easy";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1145, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCambiarImagen);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Cbx);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblCategorias);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBusqueda);
            this.Controls.Add(this.CbxCategorias);
            this.Controls.Add(this.DgwListaArticulos);
            this.MaximumSize = new System.Drawing.Size(1161, 658);
            this.Name = "Ventana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.Load += new System.EventHandler(this.Ventana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaArticulos)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnCambiarImagen;
        private System.Windows.Forms.DataGridView DgwListaArticulos;
        private System.Windows.Forms.ComboBox CbxCategorias;
        private System.Windows.Forms.Label LblBusqueda;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblCategorias;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.ComboBox Cbx;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ImageList ImgLmagenes;
        private System.Windows.Forms.Label label1;
    }
}

