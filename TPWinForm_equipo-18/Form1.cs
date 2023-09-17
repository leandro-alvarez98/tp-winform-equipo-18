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
        bool sideBarExpand = true;
        public Ventana()
        {
            InitializeComponent();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            VentanaAñadirArticulo ventana_agregar = new VentanaAñadirArticulo();
            ventana_agregar.ShowDialog();
            cargar_Componentes();
        }
        private void cargar_Componentes()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();

                agrupar_imagenes(listaArticulos);

                eliminar_repetidos(listaArticulos);
                
                DgwListaArticulos.DataSource = listaArticulos;

                cargar_imagen(listaArticulos[0].Imagenes[0]);

                ocultar_Columnas();

                DgwListaArticulos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void ocultar_Columnas()
        {
           // DgwListaArticulos.Columns["ID"].Visible = false;
            DgwListaArticulos.Columns["IMAGEN"].Visible = false;
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
                DialogResult desicion = MessageBox.Show("¿Desea eliminar el artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (desicion == DialogResult.Yes)
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
        private bool validarFiltro() {

            if (CbxCampo.SelectedIndex < 0) {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (CbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (CbxCampo.SelectedItem.ToString() == "ID") {

                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text)) {
                    MessageBox.Show("Debes cargar el filtro para numericos...");
                    return true;
                }

                if (!(soloNumeros(txtFiltroAvanzado.Text))) {
                    MessageBox.Show("Solo numeros para filtrar por el campo numerico...");
                    return true;
                }
            }
            return false;
        }
        private bool soloNumeros(string cadena) 
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro()) 
                {
                    return;
                }
                string campo = CbxCampo.SelectedItem.ToString();
                string criterio = CbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                List<Articulo> lista_filtrada = new List<Articulo>();
                lista_filtrada = negocio.filtrar(campo, criterio, filtro);
                agrupar_imagenes(lista_filtrada);
                eliminar_repetidos(lista_filtrada);
                DgwListaArticulos.DataSource = lista_filtrada;

                if (DgwListaArticulos.CurrentRow == null)
                {
                    BtnCambiarImagen.Enabled = false;
                    BtnImagenanterior.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            try
            {
                if (DgwListaArticulos.CurrentRow != null)
                {
                    Articulo articulo_actual = (Articulo)DgwListaArticulos.CurrentRow.DataBoundItem;
                    if(articulo_actual.Imagenes != null)
                        cargar_imagen(articulo_actual.Imagenes[0]);
                    else 
                        cargar_predeterminada();
                }
            }
            catch (Exception)
            {
                cargar_predeterminada();
            }
        }
        private void eliminar_repetidos(List<Articulo> lista)
        {
            List<Articulo> repetidos = new List<Articulo>();
            repetidos = get_repetidos(lista);
            foreach (Articulo repetido in repetidos)
            {
                lista.Remove(repetido);
            }
        }
        private void agrupar_imagenes(List<Articulo> lista)
        {
            List<Articulo> repetidos = new List<Articulo>();
            repetidos = get_repetidos(lista);
            foreach (Articulo articulo in lista)
            {
                foreach (Articulo repetido in repetidos)
                {
                    if (repetido.ID == articulo.ID)
                    {
                        articulo.Imagenes.Add(repetido.Imagenes[0]);
                    }
                }
            }
        }
        private List<Articulo> get_repetidos(List<Articulo> lista)
        {
            HashSet<int> ids_revisados = new HashSet<int>();

            List<Articulo> repetidos = new List<Articulo>();

            foreach (Articulo articulo_actual in lista)
            {
                if (!ids_revisados.Add(articulo_actual.ID))
                {
                    repetidos.Add(articulo_actual);
                }
            }
            return repetidos;
        }
        private void cargar_imagen(string url)
        {
            try
            {
                pictureBox1.Load(url);
            }
            catch (Exception)
            {
                cargar_predeterminada();
            }
        }
        private void cargar_predeterminada()
        {
            pictureBox1.Load("https://www.coalitionrc.com/wp-content/uploads/2017/01/placeholder.jpg");
        }
        
        private int cont_imagen = 0;
        private void BtnCambiarImagen_Click(object sender, EventArgs e)
        {
          try
          {
                cont_imagen++;
                Articulo articulo_actual = (Articulo)DgwListaArticulos.CurrentRow.DataBoundItem;
                cargar_imagen(articulo_actual.Imagenes[cont_imagen]);

          }
          catch (Exception)
          {
                cont_imagen = 0;
                Articulo articulo_actual = (Articulo)DgwListaArticulos.CurrentRow.DataBoundItem;
                cargar_imagen(articulo_actual.Imagenes[cont_imagen]);
          }

        }
        private void BtnImagenanterior_Click(object sender, EventArgs e)
        {
            try
            {Articulo articulo_actual = (Articulo)DgwListaArticulos.CurrentRow.DataBoundItem;

                if (articulo_actual.Imagenes.Count > 0)
                {
                    cont_imagen--;

                    if (cont_imagen < 0)
                    {
                        cont_imagen = articulo_actual.Imagenes.Count - 1; // Vuelve al último índice si llega a 0
                    }

                    cargar_imagen(articulo_actual.Imagenes[cont_imagen]);
                }
            }
            catch (Exception)
            {
                cont_imagen = 0;
                Articulo articulo_actual = (Articulo)DgwListaArticulos.CurrentRow.DataBoundItem;
                cargar_imagen(articulo_actual.Imagenes[cont_imagen]);
                

            }
        }
        


    }
}
