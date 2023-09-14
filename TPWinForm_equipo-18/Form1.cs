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
                cargar_imagen(listaArticulos[0].Imagen.ImagenUrl);
                   ocultar_Columnas();

                   //CbxCampo.DataSource = Categoria_desplegable.listar();
                   //CbxCriterio.DataSource = Marca_desplegable.listar();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());
                   throw;
               }
        }

        private void ocultar_Columnas()
        {
            return;
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            cargar_Componentes();
            CbxCampo.Items.Add("ID");
            CbxCampo.Items.Add("Nombre");
            CbxCampo.Items.Add("Descripcion");
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

        //NUEVO FILTRO AVANZADO - falta optimizar algunas funcionalidades del id al momento de buscar el campo vacio, lo continuo en el siguiente push
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
            string campo = CbxCampo.SelectedItem.ToString();
            string criterio = CbxCriterio.SelectedItem.ToString();
            string filtro = txtFiltroAvanzado.Text;
                DgwListaArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

            //ES EL FILTRO ANTERIOR
            /*List<Articulo> listaFiltrada;
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
            ocultar_Columnas();*/
        }

        private void CbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = CbxCampo.SelectedItem.ToString();
            if (opcion == "ID")
            {
                CbxCriterio.Items.Clear();
                CbxCriterio.Items.Add("Mayor a");
                CbxCriterio.Items.Add("Menor a");
                CbxCriterio.Items.Add("Igual a");
            }
            else {
                CbxCriterio.Items.Clear();
                CbxCriterio.Items.Add("Comienza con");
                CbxCriterio.Items.Add("Termina con");
                CbxCriterio.Items.Add("Contiene");
            }

        }

        private void DgwListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articulo_actual = (Articulo)DgwListaArticulos.CurrentRow.DataBoundItem;
            cargar_imagen(articulo_actual.Imagen.ImagenUrl);
        }   
        private void cargar_imagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBox1.Load("https://www.coalitionrc.com/wp-content/uploads/2017/01/placeholder.jpg");
            }
        }
    }
}
