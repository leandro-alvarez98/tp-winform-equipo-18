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
        private OpenFileDialog archivo = null;

        public VentanaAñadirArticulo()
        {
            InitializeComponent();
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

                articulo.codigo = TxtCodigo.Text;
                articulo.nombre = TxtNombre.Text;
                articulo.descripcion = TxtDescripcion.Text;
                articulo.Categoria = (Categoria)CbxCategoria.SelectedItem;
                articulo.Marca = (Marca)CbxMarca.SelectedItem;
                articulo.precio = decimal.Parse(TxtPrecio.Text);

                negocio.agregar(articulo);
                MessageBox.Show("Articulo añadido correctamente!");
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
                CbxCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
