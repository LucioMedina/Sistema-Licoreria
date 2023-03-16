using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class ECompra
    {
        public int idcompra { get; set; }
        public int idproveedor { get; set; }
        public char tipocomporbante { get; set; }
        public int numcomprobante { get; set; }
        public string tipopago { get; set; }
    }
}
