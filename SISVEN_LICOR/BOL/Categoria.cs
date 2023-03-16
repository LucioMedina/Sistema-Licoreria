using DAL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Categoria
    {
        DBAccess acceso = new DBAccess();
        public DataTable listar()
        {
            return acceso.getDataFrom("spu_listar_categoria");
        }

        public int registrar(ECategoria entidad)
        {
            int registrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_registrar_categoria", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@categoria", entidad.categoria);

            registrosAfectados = sqlCommand.ExecuteNonQuery();
            acceso.desconectar();

            return registrosAfectados;
        }
    }
}
