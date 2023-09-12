using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using System.Security.Cryptography;

namespace TPWinForm_equipo_18
{
    public partial class Ventana : Form
    {
        private List<Articulo> listaArticulos;

        public Ventana()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            VentanaAñadirArticulo venatana_agregar = new VentanaAñadirArticulo();
            venatana_agregar.ShowDialog();
            cargar_Componentes();
            
        }

        private void cargar_Componentes()
        {
          
              CategoriaNegocio Categoria_desplegable = new CategoriaNegocio();
              MarcaNegocio Marca_desplegable = new MarcaNegocio();
              ArticuloNegocio negocio = new ArticuloNegocio();

               try
               {
                   //CARGA LAS LISTAS DESPLEGABLES Y LA GRILLA DE ARTICULOS
                   listaArticulos = negocio.listar();
                   DgwListaArticulos.DataSource = listaArticulos;
                   ocultar_Columnas();
                   CbxCategorias.DataSource = Categoria_desplegable.listar();
                   CbxMarcas.DataSource = Marca_desplegable.listar();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());
                   throw;
               }
        }

        private void ocultar_Columnas()
        {
            DgwListaArticulos.Columns["urlimagen"].Visible = false;
        }
        private void Ventana_Load(object sender, EventArgs e)
        {
            cargar_Componentes();
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        bool sideBarExpand = true;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 5;
                if (sideBar.Width <= 48)
                {
                    sideBarExpand = false;
                    sideBarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 186)
                {
                    sideBarExpand = true;
                    sideBarTransition.Stop();
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo articulo_seleccionado;
            articulo_seleccionado = (Articulo)DgwListaArticulos.CurrentRow.DataBoundItem;

            VentanaAñadirArticulo modificar = new VentanaAñadirArticulo(articulo_seleccionado);
            modificar.ShowDialog();
            cargar_Componentes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo_a_eliminar = new Articulo();
            try
            {
                DialogResult desicion = MessageBox.Show("¿Desea eliminar el artículo?+", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(desicion == DialogResult.Yes)
                {
                    articulo_a_eliminar = (Articulo)DgwListaArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(articulo_a_eliminar.ID);
                    cargar_Componentes();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            if(TxtBuscar.Text != "")
            {
                listaFiltrada = listaArticulos.FindAll(articulo => articulo.Nombre.ToLower().Contains(TxtBuscar.Text.ToLower()) || articulo.Marca.Descripcion.ToLower().Contains(TxtBuscar.Text.ToLower()) || articulo.Categoria.Descripcion.ToLower().Contains(TxtBuscar.Text.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            DgwListaArticulos.DataSource = null;
            DgwListaArticulos.DataSource = listaFiltrada;
            ocultar_Columnas();
        }
    }
}
