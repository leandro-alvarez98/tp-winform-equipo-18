using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int ID {  get; set; }
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal precio { get; set; }
        public string urlImagen { get; set; }
    }
}
