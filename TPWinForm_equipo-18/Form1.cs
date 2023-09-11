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
            
            Form2 venatana_agregar = new Form2();
            venatana_agregar.Show();
            
        }

        private void DgwListaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            ArticuloNegocio Articulo_actual = new ArticuloNegocio();
            DgwListaArticulos.DataSource = Articulo_actual.listar();
            /*En data source se guarda una lista*/

            DgwListaArticulos.Columns["codigo"].Visible = false;
            DgwListaArticulos.Columns["precio"].Visible = false;
            DgwListaArticulos.Columns["marca"].Visible = false;
            DgwListaArticulos.Columns["categoria"].Visible = false;
            DgwListaArticulos.Columns["urlimagen"].Visible = false;
        }
    }
}
