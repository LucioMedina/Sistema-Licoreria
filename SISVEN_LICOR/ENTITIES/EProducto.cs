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
        public string nombre { get; set; }
        public string codigo { get; set; }
        public int stock { get; set; }
        public int idmarca { get; set; }
        public int idcategoria { get; set; }
        public decimal precio { get; set; }
    }
}
