using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("SELECT ARTICULOS.Id, ARTICULOS.Nombre, ARTICULOS.Descripcion from ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo objetoArticulo = new Articulo();

                    objetoArticulo.ID = (int)datos.Lector["Id"];
                    objetoArticulo.nombre = (string)datos.Lector["Nombre"];
                    objetoArticulo.descripcion = (string)datos.Lector["Descripcion"];

                    //IMAGENES
                    //objetoArticulo.urlImagen = (string)datos.Lector["ImagenUrl"];
                    //if (!(datos.Lector["UrlImagen"] is DBNull))
                      //  objetoArticulo.urlImagen = (string)datos.Lector["ImagenUrl"];

                    lista.Add(objetoArticulo);
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo_articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }    
}
