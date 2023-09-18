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

        //mapea lo que hay en el formulario al objeto al momento de aceptar la modificacion o el agregado  
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            bool campos_incompletos = false;
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                if (articulo.Imagenes == null)
                    articulo.Imagenes = new List<string>();

                if (TxtCodigo.Text != null)
                    if (!string.IsNullOrEmpty(TxtCodigo.Text))
                        articulo.Codigo = TxtCodigo.Text;
                    else
                        campos_incompletos = true;
                    
                if (TxtNombre.Text != null)
                    if (!string.IsNullOrEmpty(TxtNombre.Text))
                        articulo.Nombre = TxtNombre.Text;
                    else
                        campos_incompletos = true;

                if (TxtDescripcion.Text != null)
                    if (!string.IsNullOrEmpty(TxtDescripcion.Text))
                        articulo.Descripcion = TxtCodigo.Text;
                    else
                        campos_incompletos = true;

                articulo.Categoria = (Categoria)CbxCategoria.SelectedItem;

                articulo.Marca = (Marca)CbxMarca.SelectedItem;

                if (TxtPrecio.Text != null)
                    articulo.Precio = decimal.Parse(TxtPrecio.Text);

                articulo.Imagen = new Imagen();
                if(txtbxUrlImagen != null)
                {
                    if(!string.IsNullOrEmpty(txtbxUrlImagen.Text))
                    {
                        articulo.Imagenes.Add(txtbxUrlImagen.Text);
                        articulo.Imagen.ImagenUrl = txtbxUrlImagen.Text;
                    }
                    else
                        campos_incompletos = true;
                }

                if(campos_incompletos)
                {
                    MessageBox.Show("Los campos no pueden estar vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigo.Focus();
                }
                else
                {
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
            }
            catch (FormatException )
            {
                Lbl_error_precio.Text = "Por favor, cargar sólo numeros";  
                Lbl_error_precio.Visible = true;
            }
        }

        //ventana del segundo formulario al cargar/ modificar
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
                    txtbxUrlImagen.Text = articulo.Imagenes.First();
                    TxtDescripcion.Text = articulo.Descripcion;
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
                MessageBox.Show("Ya hay un archivo con la misma imagen, elija otra por favor :)");
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

