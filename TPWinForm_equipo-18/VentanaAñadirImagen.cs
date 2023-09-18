using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_18
{
    public partial class VentanaAñadirImagen : Form
    {
        private OpenFileDialog archivo = null;
        private Articulo articulo = null;
        public VentanaAñadirImagen(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Añadiendo Imagen...";
        }
        private void BtnCargarNuevaImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtbxUrlImagen.Text = archivo.FileName;
                cargar_imagen(archivo.FileName);

            }
        }
        private void cargar_imagen(string url_imagen)
        {
            try
            {
                PbxNuevaImagen.Load(url_imagen);
            }
            catch (Exception)
            {
                cargar_predeterminada();
            }
        }
        private void cargar_predeterminada()
        {
            PbxNuevaImagen.Load("https://www.coalitionrc.com/wp-content/uploads/2017/01/placeholder.jpg");
        }
        private void copiar_imagen_localmente()
        {
            try
            {
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes-app"] + archivo.SafeFileName);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Ya hay un achivo con la misma imagen, elija otra por favor :)");
                throw;
            }
        }
        private void txtbxUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargar_imagen(txtbxUrlImagen.Text);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            try
            {
                if (txtbxUrlImagen != null)
                {
                    if (!string.IsNullOrEmpty(txtbxUrlImagen.Text))
                    {
                        articulo.Descripcion = txtbxUrlImagen.Text;
                        articulo.Imagenes.Add(txtbxUrlImagen.Text);
                        negocio.añadir(articulo);
                           /*
                            Quise hacer una función para detectar la imagen default, 
                            para así eliminarla de la base de datos una vez carguemos una nueva imagen.
                            No funciona.
                                if (negocio.Tiene_ImagenDefault(articulo))
                                    negocio.eliminar_imagen(articulo);
                            */
                        if (archivo != null && !(txtbxUrlImagen.Text.ToUpper().Contains("HTTP")))
                        {
                            copiar_imagen_localmente();
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Los campos no pueden estar vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbxUrlImagen.Focus();
                    }
                }
            }
            catch (System.IO.IOException)
            {
                throw;
            }
        }
    }
}
