using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BOL
{
    public class Usuario
    {
        DBAccess acceso = new DBAccess();
        public DataTable iniciarSesion(string usuario)
        {
            DataTable dataTable = new DataTable();

            acceso.conectar();
            SqlCommand sqlCommand = new SqlCommand("spu_login_usuario", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@usuario", usuario);
            // el objeto dataTable carga el resultado obtenido por el comando
            dataTable.Load(sqlCommand.ExecuteReader());

            acceso.desconectar();

            return dataTable;
        }
    }
}
