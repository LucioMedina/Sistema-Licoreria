using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Productos
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarActivosProduc()
        {
            return acceso.getDataFrom("spu_listar_producto", 1);
        }
    }
}
