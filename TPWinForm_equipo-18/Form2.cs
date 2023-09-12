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
            Articulo nuevo_articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                nuevo_articulo.ID = int.Parse(TxtCodigo.Text);
                nuevo_articulo.nombre = TxtNombre.Text;
                nuevo_articulo.descripcion = TxtDescripcion.Text;
                nuevo_articulo.precio = int.Parse(TxtPrecio.Text);

                negocio.agregar(nuevo_articulo);
                MessageBox.Show("Articulo añadido correctamente!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
