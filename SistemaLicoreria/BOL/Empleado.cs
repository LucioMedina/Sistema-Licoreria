using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BOL
{
    public class Empleado
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_listar_empleado", 1);
        }
    }
}
