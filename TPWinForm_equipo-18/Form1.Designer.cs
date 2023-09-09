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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnDetalleArticulo = new System.Windows.Forms.Button();
            this.DgwListaArticulos = new System.Windows.Forms.DataGridView();
            this.CmbCategorias = new System.Windows.Forms.ComboBox();
            this.LblBusqueda = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCategorias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(154, 112);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 39);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(154, 226);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(80, 37);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(154, 324);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(80, 43);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnDetalleArticulo
            // 
            this.BtnDetalleArticulo.Location = new System.Drawing.Point(154, 428);
            this.BtnDetalleArticulo.Name = "BtnDetalleArticulo";
            this.BtnDetalleArticulo.Size = new System.Drawing.Size(117, 23);
            this.BtnDetalleArticulo.TabIndex = 3;
            this.BtnDetalleArticulo.Text = "Detalle  Articulo";
            this.BtnDetalleArticulo.UseVisualStyleBackColor = true;
            // 
            // DgwListaArticulos
            // 
            this.DgwListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwListaArticulos.Location = new System.Drawing.Point(349, 183);
            this.DgwListaArticulos.Name = "DgwListaArticulos";
            this.DgwListaArticulos.Size = new System.Drawing.Size(606, 268);
            this.DgwListaArticulos.TabIndex = 4;
            // 
            // CmbCategorias
            // 
            this.CmbCategorias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCategorias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbCategorias.FormattingEnabled = true;
            this.CmbCategorias.Items.AddRange(new object[] {
            "manzana",
            "maranja"});
            this.CmbCategorias.Location = new System.Drawing.Point(834, 122);
            this.CmbCategorias.Name = "CmbCategorias";
            this.CmbCategorias.Size = new System.Drawing.Size(121, 21);
            this.CmbCategorias.TabIndex = 5;
            // 
            // LblBusqueda
            // 
            this.LblBusqueda.AutoSize = true;
            this.LblBusqueda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblBusqueda.Location = new System.Drawing.Point(346, 79);
            this.LblBusqueda.Name = "LblBusqueda";
            this.LblBusqueda.Size = new System.Drawing.Size(81, 13);
            this.LblBusqueda.TabIndex = 6;
            this.LblBusqueda.Text = "buscar articulos";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(349, 122);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(409, 20);
            this.TxtBuscar.TabIndex = 7;
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Location = new System.Drawing.Point(834, 78);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(57, 13);
            this.LblCategorias.TabIndex = 8;
            this.LblCategorias.Text = "Categorias";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1152, 635);
            this.Controls.Add(this.LblCategorias);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBusqueda);
            this.Controls.Add(this.CmbCategorias);
            this.Controls.Add(this.DgwListaArticulos);
            this.Controls.Add(this.BtnDetalleArticulo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "Ventana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnDetalleArticulo;
        private System.Windows.Forms.DataGridView DgwListaArticulos;
        private System.Windows.Forms.ComboBox CmbCategorias;
        private System.Windows.Forms.Label LblBusqueda;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblCategorias;
    }
}

