using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace TPWinForm_equipo_18
{
    public partial class VentanaAñadirArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public VentanaAñadirArticulo()
        {
            InitializeComponent();
        }

        public VentanaAñadirArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                if (articulo.Imagenes == null)
                    articulo.Imagenes = new List<string>();
                if (TxtCodigo.Text != null)
                    articulo.Codigo = TxtCodigo.Text;
                if (TxtNombre.Text != null)
                    articulo.Nombre = TxtNombre.Text;
                if (TxtDescripcion.Text != null)
                    articulo.Descripcion = TxtDescripcion.Text;
                articulo.Categoria = (Categoria)CbxCategoria.SelectedItem;
                articulo.Marca = (Marca)CbxMarca.SelectedItem;
                if (TxtPrecio.Text != null)
                    articulo.Precio = decimal.Parse(TxtPrecio.Text);
                if(txtbxUrlImagen != null)
                articulo.Imagenes.Add(txtbxUrlImagen.Text);
                

                if (articulo.ID != 0)
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Modificado correctamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo añadido correctamente!");
                }
               
                //distingue si las guarda en la base de datos o localmente
                if (archivo != null && !(txtbxUrlImagen.Text.ToUpper().Contains("HTTP")))
                {                 
                    copiar_imagen_localmente();
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void VentanaAñadirArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                CbxMarca.DataSource = marcaNegocio.listar();
                CbxMarca.ValueMember = "Id";
                CbxMarca.DisplayMember = "Descripcion";
                CbxCategoria.DataSource = categoriaNegocio.listar();
                CbxCategoria.ValueMember = "Id";
                CbxCategoria.DisplayMember = "Descripcion";
                cargar_predeterminada();

                if (articulo != null)
                {
                    TxtCodigo.Text = articulo.Codigo;
                    TxtNombre.Text = articulo.Nombre;
                    TxtPrecio.Text = articulo.Precio.ToString();
                    CbxMarca.SelectedValue = articulo.Marca.Id;
                    CbxCategoria.SelectedValue = articulo.Categoria.Id;
                    txtbxUrlImagen.Text = articulo.Imagen.ToString();
                    cargar_imagen(txtbxUrlImagen.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void txtbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargar_imagen(txtbxUrlImagen.Text);
        }
        private void cargar_imagen(string url_imagen)
        {
            try
            {
                PbxImagen.Load(url_imagen);
            }
            catch (Exception)
            {
                cargar_predeterminada();
            }
        }

        private void cargar_predeterminada()
        {
            PbxImagen.Load("https://www.coalitionrc.com/wp-content/uploads/2017/01/placeholder.jpg");
        }

        private void copiar_imagen_localmente()
        {
            try
            {
                //copia la imagen a una carpeta local
                 File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes-app"] + archivo.SafeFileName);
            }
            catch (System.IO.IOException )
            {
                MessageBox.Show("ya hay un achivo con la misma imagen, elija otra por favor :)");
                throw;
            }
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtbxUrlImagen.Text = archivo.FileName;
                cargar_imagen(archivo.FileName);

            }
        } 
    }
}

