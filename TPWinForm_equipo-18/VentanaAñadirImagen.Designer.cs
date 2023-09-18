namespace TPWinForm_equipo_18
{
    partial class VentanaAñadirImagen
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
            this.BtnCargarNuevaImagen = new System.Windows.Forms.Button();
            this.txtbxUrlImagen = new System.Windows.Forms.TextBox();
            this.lblNuevaImagen = new System.Windows.Forms.Label();
            this.PbxNuevaImagen = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNuevaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarNuevaImagen
            // 
            this.BtnCargarNuevaImagen.Location = new System.Drawing.Point(377, 13);
            this.BtnCargarNuevaImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCargarNuevaImagen.Name = "BtnCargarNuevaImagen";
            this.BtnCargarNuevaImagen.Size = new System.Drawing.Size(38, 26);
            this.BtnCargarNuevaImagen.TabIndex = 19;
            this.BtnCargarNuevaImagen.Text = " +";
            this.BtnCargarNuevaImagen.UseVisualStyleBackColor = true;
            this.BtnCargarNuevaImagen.Click += new System.EventHandler(this.BtnCargarNuevaImagen_Click);
            // 
            // txtbxUrlImagen
            // 
            this.txtbxUrlImagen.BackColor = System.Drawing.Color.Silver;
            this.txtbxUrlImagen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUrlImagen.Location = new System.Drawing.Point(282, 49);
            this.txtbxUrlImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxUrlImagen.Name = "txtbxUrlImagen";
            this.txtbxUrlImagen.Size = new System.Drawing.Size(236, 27);
            this.txtbxUrlImagen.TabIndex = 17;
            this.txtbxUrlImagen.TextChanged += new System.EventHandler(this.txtbxUrlImagen_TextChanged);
            // 
            // lblNuevaImagen
            // 
            this.lblNuevaImagen.AutoSize = true;
            this.lblNuevaImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaImagen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaImagen.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNuevaImagen.Location = new System.Drawing.Point(278, 14);
            this.lblNuevaImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaImagen.Name = "lblNuevaImagen";
            this.lblNuevaImagen.Size = new System.Drawing.Size(91, 21);
            this.lblNuevaImagen.TabIndex = 18;
            this.lblNuevaImagen.Text = "UrlImagen";
            // 
            // PbxNuevaImagen
            // 
            this.PbxNuevaImagen.BackColor = System.Drawing.Color.Transparent;
            this.PbxNuevaImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxNuevaImagen.Location = new System.Drawing.Point(13, 14);
            this.PbxNuevaImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxNuevaImagen.Name = "PbxNuevaImagen";
            this.PbxNuevaImagen.Size = new System.Drawing.Size(240, 160);
            this.PbxNuevaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxNuevaImagen.TabIndex = 20;
            this.PbxNuevaImagen.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.BtnCancelar.Location = new System.Drawing.Point(384, 225);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 32);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(162)))), ((int)(((byte)(136)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(13, 225);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(128, 32);
            this.BtnAgregar.TabIndex = 22;
            this.BtnAgregar.Text = "Añadir";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // VentanaAñadirImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(534, 271);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.PbxNuevaImagen);
            this.Controls.Add(this.BtnCargarNuevaImagen);
            this.Controls.Add(this.txtbxUrlImagen);
            this.Controls.Add(this.lblNuevaImagen);
            this.MaximumSize = new System.Drawing.Size(550, 310);
            this.MinimumSize = new System.Drawing.Size(550, 305);
            this.Name = "VentanaAñadirImagen";
            this.Text = "VentanaAñadirImagen";
            ((System.ComponentModel.ISupportInitialize)(this.PbxNuevaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarNuevaImagen;
        private System.Windows.Forms.TextBox txtbxUrlImagen;
        private System.Windows.Forms.Label lblNuevaImagen;
        private System.Windows.Forms.PictureBox PbxNuevaImagen;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}