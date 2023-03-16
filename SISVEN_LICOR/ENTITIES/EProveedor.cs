using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class EProveedor
    {
        public int idproveedor { get; set; }   
        public string nombreprov { get; set; }
        public string direccion { set; get; }
        public char ruc { set; get; }   
        public char telefono { get; set; }
    }
}
