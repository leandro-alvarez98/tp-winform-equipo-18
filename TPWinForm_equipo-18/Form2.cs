using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_18
{
    public partial class VentanaAñadirArticulo : Form
    {
        private Articulo articulo = null;

        public VentanaAñadirArticulo()
        {
            InitializeComponent();
        }

        public VentanaAñadirArticulo (Articulo articulo)
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
                if(articulo == null)
                    articulo = new Articulo();
                if(articulo.Imagenes == null)
                    articulo.Imagenes = new List<string> ();

                articulo.Codigo = TxtCodigo.Text;
                articulo.Nombre = TxtNombre.Text;
                articulo.Descripcion = TxtDescripcion.Text;
                articulo.Categoria = (Categoria)CbxCategoria.SelectedItem;
                articulo.Marca = (Marca)CbxMarca.SelectedItem;
                articulo.Precio = decimal.Parse(TxtPrecio.Text);
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

                if(articulo != null)
                {
                    TxtCodigo.Text = articulo.Codigo;  
                    TxtNombre.Text = articulo.Nombre;
                    TxtPrecio.Text = articulo.Precio.ToString();
                    CbxMarca.SelectedValue = articulo.Marca.Id;
                    CbxCategoria.SelectedValue = articulo.Categoria.Id;
                    
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
                PbxImagen.Load("https://www.coalitionrc.com/wp-content/uploads/2017/01/placeholder.jpg");
            }
        }
    }
}
