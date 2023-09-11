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
        public int codigo { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public String marca { get; set; }
        public String categoria { get; set; }
        public double precio { get; set; }
        public string urlImagen { get; set; }
    }
}
