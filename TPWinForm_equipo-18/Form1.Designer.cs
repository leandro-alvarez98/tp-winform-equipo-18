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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.BtnCambiarImagen = new System.Windows.Forms.Button();
            this.DgwListaArticulos = new System.Windows.Forms.DataGridView();
            this.CbxCampo = new System.Windows.Forms.ComboBox();
            this.LblCampo = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnImagenanterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaArticulos)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCambiarImagen
            // 
            this.BtnCambiarImagen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarImagen.Location = new System.Drawing.Point(1108, 412);
            this.BtnCambiarImagen.Name = "BtnCambiarImagen";
            this.BtnCambiarImagen.Size = new System.Drawing.Size(99, 25);
            this.BtnCambiarImagen.TabIndex = 7;
            this.BtnCambiarImagen.Text = "Siguiente imagen";
            this.BtnCambiarImagen.UseVisualStyleBackColor = true;
            this.BtnCambiarImagen.Click += new System.EventHandler(this.BtnCambiarImagen_Click);
            // 
            // DgwListaArticulos
            // 
            this.DgwListaArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.DgwListaArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(55)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(140)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwListaArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgwListaArticulos.ColumnHeadersHeight = 35;
            this.DgwListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgwListaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgwListaArticulos.EnableHeadersVisualStyles = false;
            this.DgwListaArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.DgwListaArticulos.Location = new System.Drawing.Point(202, 165);
            this.DgwListaArticulos.MultiSelect = false;
            this.DgwListaArticulos.Name = "DgwListaArticulos";
            this.DgwListaArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(140)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwListaArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(140)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DgwListaArticulos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgwListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwListaArticulos.Size = new System.Drawing.Size(745, 272);
            this.DgwListaArticulos.TabIndex = 0;
            this.DgwListaArticulos.SelectionChanged += new System.EventHandler(this.DgwListaArticulos_SelectionChanged);
            // 
            // CbxCampo
            // 
            this.CbxCampo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxCampo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxCampo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCampo.FormattingEnabled = true;
            this.CbxCampo.Location = new System.Drawing.Point(1086, 86);
            this.CbxCampo.Name = "CbxCampo";
            this.CbxCampo.Size = new System.Drawing.Size(121, 23);
            this.CbxCampo.TabIndex = 2;
            this.CbxCampo.SelectedIndexChanged += new System.EventHandler(this.CbxCampo_SelectedIndexChanged);
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.BackColor = System.Drawing.Color.Transparent;
            this.LblCampo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(999, 88);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(70, 21);
            this.LblCampo.TabIndex = 9;
            this.LblCampo.Text = "Campo";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.BackColor = System.Drawing.Color.Transparent;
            this.LblCriterio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCriterio.Location = new System.Drawing.Point(999, 130);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(66, 21);
            this.LblCriterio.TabIndex = 10;
            this.LblCriterio.Text = "Criterio";
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxCriterio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Location = new System.Drawing.Point(1086, 126);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(121, 23);
            this.CbxCriterio.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(282, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 11;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Header.Controls.Add(this.lblTitulo);
            this.Header.Controls.Add(this.btnHam);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1255, 66);
            this.Header.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(78, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestor de Articulos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(0, 25);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(186, 50);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "          Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.sideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideBar.Controls.Add(this.BtnAgregar);
            this.sideBar.Controls.Add(this.BtnModificar);
            this.sideBar.Controls.Add(this.BtnEliminar);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 66);
            this.sideBar.Name = "sideBar";
            this.sideBar.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.sideBar.Size = new System.Drawing.Size(186, 402);
            this.sideBar.TabIndex = 1;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(0, 75);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(186, 50);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "          Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(0, 125);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(186, 50);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "          Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 10;
            this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(907, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filtrar por:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(140)))), ((int)(((byte)(139)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(704, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LblFiltroAvanzado
            // 
            this.LblFiltroAvanzado.AutoSize = true;
            this.LblFiltroAvanzado.BackColor = System.Drawing.Color.Transparent;
            this.LblFiltroAvanzado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltroAvanzado.ForeColor = System.Drawing.Color.Black;
            this.LblFiltroAvanzado.Location = new System.Drawing.Point(198, 91);
            this.LblFiltroAvanzado.Name = "LblFiltroAvanzado";
            this.LblFiltroAvanzado.Size = new System.Drawing.Size(46, 21);
            this.LblFiltroAvanzado.TabIndex = 23;
            this.LblFiltroAvanzado.Text = "Filtro";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(202, 122);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(474, 21);
            this.txtFiltroAvanzado.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(987, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // BtnImagenanterior
            // 
            this.BtnImagenanterior.BackColor = System.Drawing.Color.Transparent;
            this.BtnImagenanterior.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagenanterior.Location = new System.Drawing.Point(987, 414);
            this.BtnImagenanterior.Name = "BtnImagenanterior";
            this.BtnImagenanterior.Size = new System.Drawing.Size(92, 23);
            this.BtnImagenanterior.TabIndex = 6;
            this.BtnImagenanterior.Text = "Anterior";
            this.BtnImagenanterior.UseVisualStyleBackColor = false;
            this.BtnImagenanterior.Click += new System.EventHandler(this.BtnImagenanterior_Click);
            // 
            // Ventana
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(118)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1255, 468);
            this.Controls.Add(this.BtnImagenanterior);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.LblFiltroAvanzado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCambiarImagen);
            this.Controls.Add(this.CbxCriterio);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.CbxCampo);
            this.Controls.Add(this.DgwListaArticulos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximumSize = new System.Drawing.Size(1271, 507);
            this.MinimumSize = new System.Drawing.Size(1271, 507);
            this.Name = "Ventana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.Load += new System.EventHandler(this.Ventana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwListaArticulos)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCambiarImagen;
        private System.Windows.Forms.DataGridView DgwListaArticulos;
        private System.Windows.Forms.ComboBox CbxCampo;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.ComboBox CbxCriterio;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnImagenanterior;
    }
}

