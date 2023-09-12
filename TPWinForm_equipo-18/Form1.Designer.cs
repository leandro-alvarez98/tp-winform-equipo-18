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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.BtnCambiarImagen = new System.Windows.Forms.Button();
            this.DgwListaArticulos = new System.Windows.Forms.DataGridView();
            this.CbxCategorias = new System.Windows.Forms.ComboBox();
            this.LblBusqueda = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.Cbx = new System.Windows.Forms.ComboBox();
            this.ImgLmagenes = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaArticulos)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
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
            this.DgwListaArticulos.Location = new System.Drawing.Point(202, 211);
            this.DgwListaArticulos.Name = "DgwListaArticulos";
            this.DgwListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwListaArticulos.Size = new System.Drawing.Size(861, 294);
            this.DgwListaArticulos.TabIndex = 4;
            // 
            // CbxCategorias
            // 
            this.CbxCategorias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxCategorias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxCategorias.FormattingEnabled = true;
            this.CbxCategorias.Items.AddRange(new object[] {
            "manzana",
            "maranja"});
            this.CbxCategorias.Location = new System.Drawing.Point(653, 95);
            this.CbxCategorias.Name = "CbxCategorias";
            this.CbxCategorias.Size = new System.Drawing.Size(121, 21);
            this.CbxCategorias.TabIndex = 5;
            // 
            // LblBusqueda
            // 
            this.LblBusqueda.AutoSize = true;
            this.LblBusqueda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblBusqueda.Location = new System.Drawing.Point(192, 69);
            this.LblBusqueda.Name = "LblBusqueda";
            this.LblBusqueda.Size = new System.Drawing.Size(82, 13);
            this.LblBusqueda.TabIndex = 6;
            this.LblBusqueda.Text = "Buscar articulos";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(192, 96);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(409, 20);
            this.TxtBuscar.TabIndex = 7;
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Location = new System.Drawing.Point(650, 69);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(57, 13);
            this.LblCategorias.TabIndex = 8;
            this.LblCategorias.Text = "Categorias";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(861, 69);
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
            this.Cbx.Location = new System.Drawing.Point(864, 96);
            this.Cbx.Name = "Cbx";
            this.Cbx.Size = new System.Drawing.Size(121, 21);
            this.Cbx.TabIndex = 13;
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
            this.label1.Location = new System.Drawing.Point(199, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "aca podria ir  una lista de imagenes entonces podemos mostrar todas las imagenes " +
    "que querramos pero bueno cambiandolas con el boton so easy";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.LightYellow;
            this.Header.Controls.Add(this.lblTitulo);
            this.Header.Controls.Add(this.btnHam);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1145, 66);
            this.Header.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Beige;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblTitulo.Location = new System.Drawing.Point(72, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 17);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestor de Articulos";
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.Transparent;
            this.btnHam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHam.BackgroundImage")));
            this.btnHam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.Location = new System.Drawing.Point(12, 20);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(40, 40);
            this.btnHam.TabIndex = 0;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregar.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(0, 25);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(186, 50);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "                   Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FloralWhite;
            this.sideBar.Controls.Add(this.BtnAgregar);
            this.sideBar.Controls.Add(this.BtnModificar);
            this.sideBar.Controls.Add(this.BtnEliminar);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 66);
            this.sideBar.Name = "sideBar";
            this.sideBar.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.sideBar.Size = new System.Drawing.Size(186, 553);
            this.sideBar.TabIndex = 17;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(0, 75);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(186, 50);
            this.BtnModificar.TabIndex = 19;
            this.BtnModificar.Text = "                   Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(0, 125);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(186, 50);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "                   Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 10;
            this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
            // 
            // Ventana
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1145, 619);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCambiarImagen);
            this.Controls.Add(this.Cbx);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblCategorias);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBusqueda);
            this.Controls.Add(this.CbxCategorias);
            this.Controls.Add(this.DgwListaArticulos);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1161, 658);
            this.Name = "Ventana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.Load += new System.EventHandler(this.Ventana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaArticulos)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCambiarImagen;
        private System.Windows.Forms.DataGridView DgwListaArticulos;
        private System.Windows.Forms.ComboBox CbxCategorias;
        private System.Windows.Forms.Label LblBusqueda;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblCategorias;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.ComboBox Cbx;
        private System.Windows.Forms.ImageList ImgLmagenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Timer sideBarTransition;
    }
}

