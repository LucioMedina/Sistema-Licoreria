using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EDcompra
    {
        public int idcompra { get; set; }
        public int idproducto { get; set; }
        public int cantidad { get; set; }
        public decimal preciocompra { set; get; }
        public decimal precioventa{ set; get; }
    }
}
