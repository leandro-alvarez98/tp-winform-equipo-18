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
                datos.setConsulta("SELECT  a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdMarca as marca, a.IdCategoria as categoria, a.Precio,m.Descripcion as mdescripcion,i.ImagenUrl as link, c.Descripcion as cdescripcion FROM ARTICULOS a INNER JOIN MARCAS m ON m.Id = a.IdMarca  INNER JOIN IMAGENES i ON i.IdArticulo = a.Id  left JOIN CATEGORIAS c ON c.Id = a.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo objetoArticulo = new Articulo();

                    if (!(datos.Lector["id"]is DBNull))
                    {
                      objetoArticulo.ID = (int)datos.Lector["Id"];
                    }
                    if (!(datos.Lector["Codigo"] is DBNull))
                    {
                        objetoArticulo.Codigo = (string)datos.Lector["Codigo"];
                    }
                    if (!(datos.Lector["Nombre"] is DBNull))
                    {
                        objetoArticulo.Nombre = (string)datos.Lector["Nombre"];
                    }
                    else
                    {
                        objetoArticulo.Nombre = "-";
                    }
                    if (!(datos.Lector["Descripcion"] is DBNull))
                    {
                        objetoArticulo.Descripcion = (string)datos.Lector["Descripcion"];
                    }
                    else
                    {
                        objetoArticulo.Descripcion = "-";
                    }

                    objetoArticulo.Marca = new Marca();

                    if (!(datos.Lector["marca"] is DBNull))
                    {
                        objetoArticulo.Marca.Id = (int)datos.Lector["marca"];
                        objetoArticulo.Marca.Descripcion = (string)datos.Lector["mdescripcion"];
                    }

                    objetoArticulo.Categoria = new Categoria();

                    if (!(datos.Lector["categoria"] is DBNull))
                    {
                        objetoArticulo.Categoria.Id = (int)datos.Lector["categoria"];
                    }
                    if (!(datos.Lector["cdescripcion"] is DBNull))
                    {
                        objetoArticulo.Categoria.Descripcion = (string)datos.Lector["cdescripcion"];
                    }else
                    {
                        objetoArticulo.Categoria.Descripcion = "-";
                    }

                    if (!(datos.Lector["Precio"] is DBNull))
                    {
                        objetoArticulo.Precio = (decimal)datos.Lector["Precio"];
                    }

                    objetoArticulo.Imagen = new Imagen();
                    objetoArticulo.Imagen.ImagenUrl = (string)datos.Lector["link"];

                    objetoArticulo.Imagenes = new List<String>();
                    objetoArticulo.Imagenes.Add((string)datos.Lector["link"]);

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
                datos.setConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, IdMarca, IdCategoria, Precio, Descripcion) VALUES (@Codigo, @Nombre, @Marca, @Categoria, @Precio, @Descripcion)");
                datos.setParametro("@Codigo", nuevo_articulo.Codigo);
                datos.setParametro("@Nombre", nuevo_articulo.Nombre);
                datos.setParametro("@Marca", nuevo_articulo.Marca.Id);
                datos.setParametro("@Categoria", nuevo_articulo.Categoria.Id);
                datos.setParametro("@Precio", nuevo_articulo.Precio);
                datos.setParametro("@Descripcion", nuevo_articulo.Descripcion);
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


        public void Modificar (Articulo articulo) 
        {
            AccesoDatos datos = new AccesoDatos (); 

            try
            {
                datos.setConsulta("UPDATE ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion,idMarca = @marca,idCategoria = @categoria ,Precio = @precio where id = @id");
                datos.setParametro("@id", articulo.ID);
                datos.setParametro("@codigo", articulo.Codigo);
                datos.setParametro("@nombre", articulo.Nombre);
                datos.setParametro("@descripcion", articulo.Descripcion);
                datos.setParametro("@precio", articulo.Precio);
                datos.setParametro("@marca", articulo.Marca.Id);
                datos.setParametro("@categoria", articulo.Categoria.Id);

                datos.ejecutarLectura();

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

        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //NUEVO FILTRO AVANZADO - falta optimizar algunas funcionalidades del id al momento de buscar el campo vacio, lo continuo en el siguiente push
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            { 
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Id as marca, m.Descripcion as mdescripcion, c.Id as categoria, c.Descripcion as cdescripcion, a.Precio FROM ARTICULOS a INNER JOIN MARCAS m ON m.Id = a.IdMarca INNER JOIN CATEGORIAS c ON c.Id = a.IdCategoria And ";
                
                switch (campo) {

                    case "ID":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "a.Id > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "a.Id < " + filtro;
                                break;
                            default:
                                consulta += "a.Id = " + filtro;
                                break;
                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "a.Nombre like '" + filtro  + "% ' " ;
                                break;
                            case "Termina con":
                                consulta += "a.Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "a.Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "a.Descripcion > '" + filtro + "% ' ";
                                break;
                            case "Termina con":
                                consulta += "a.Descripcion '%" + filtro + "'";
                                break;
                            default:
                                consulta += "a.Descripcion '%" + filtro + "%'";
                                break;
                        }
                        break;

                    default:
                        break;
                }

                datos.setConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo objetoArticulo = new Articulo();

                    objetoArticulo.ID = (int)datos.Lector["Id"];
                    objetoArticulo.Codigo = (string)datos.Lector["Codigo"];
                    objetoArticulo.Nombre = (string)datos.Lector["Nombre"];
                    objetoArticulo.Descripcion = (string)datos.Lector["Descripcion"];

                    objetoArticulo.Marca = new Marca();

                    objetoArticulo.Marca.Id = (int)datos.Lector["marca"];
                    objetoArticulo.Marca.Descripcion = (string)datos.Lector["mdescripcion"];

                    objetoArticulo.Categoria = new Categoria();

                    objetoArticulo.Categoria.Id = (int)datos.Lector["categoria"];
                    objetoArticulo.Categoria.Descripcion = (string)datos.Lector["cdescripcion"];

                    objetoArticulo.Precio = (decimal)datos.Lector["Precio"];

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

                throw ex;
            }        
        }
    }    
}
