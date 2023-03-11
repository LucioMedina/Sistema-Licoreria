using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EProducto
    {
        public int idproducto { get; set; }

        public string nombreproducto{ get; set; }
        public string idmarca { get; set; }
        public string idcategoria { get; set; }
        public string descripcion { get; set; }
        public string codigo { get; set; }
        public string precio { get; set; }
        public string stock { get; set; }
        public string caducidad { get; set; }
    }
}
