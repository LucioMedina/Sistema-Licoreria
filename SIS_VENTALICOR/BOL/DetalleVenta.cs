using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class DetalleVenta
    {
        DBAccess acceso = new DBAccess();
        public DataTable listarActivos()
        {
            return acceso.getDataFrom("", 1);
        }


    }
}
