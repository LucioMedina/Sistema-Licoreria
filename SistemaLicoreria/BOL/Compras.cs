using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Compras
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_listar_compras", 1);
        }
    }
}
