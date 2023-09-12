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
        public Ventana()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            VentanaAñadirArticulo venatana_agregar = new VentanaAñadirArticulo();
            venatana_agregar.ShowDialog();
            Cargar_componentes();
            
        }

        private void Cargar_componentes()
        {
          
              ArticuloNegocio Articulo_actual = new ArticuloNegocio();
              CategoriaNegocio Categoria_desplegable = new CategoriaNegocio();
              MarcaNegocio Marca_desplegable = new MarcaNegocio();

               try
               {
                   //carga las listas desplegables y la datagriv
                   CbxCategorias.DataSource = Categoria_desplegable.listar();
                   CbxMarcas.DataSource = Marca_desplegable.listar();
                   DgwListaArticulos.DataSource = Articulo_actual.listar();

                   DgwListaArticulos.Columns["urlimagen"].Visible = false;
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());
                   throw;
               }
               /*En data source se guarda una lista*/
 
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            ArticuloNegocio Articulo_actual = new ArticuloNegocio();
            CategoriaNegocio Categoria_desplegable = new CategoriaNegocio();
            MarcaNegocio Marca_desplegable = new MarcaNegocio();

            try
            {
                //carga las listas desplegables y la datagriv
                CbxCategorias.DataSource = Categoria_desplegable.listar();
                CbxMarcas.DataSource = Marca_desplegable.listar();
                DgwListaArticulos.DataSource = Articulo_actual.listar();

                DgwListaArticulos.Columns["urlimagen"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            /*En data source se guarda una lista*/

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
            Cargar_componentes();
        }
    }
}
