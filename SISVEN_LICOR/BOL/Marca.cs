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
    public class Marca
    {
        DBAccess acceso = new DBAccess();
        public DataTable listar()
        {
            return acceso.getDataFrom("spu_listar_marca");
        }

        public int registrar(EMarca entidad)
        {
            int registrosAfectados = 0;

            acceso.conectar();
            SqlCommand sqlCommand = new SqlCommand("spu_registrar_marca", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("marca", entidad.marca);

            registrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return registrosAfectados;
        }

        public int editar(EMarca entidad)
        {
            int registrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_editar_marca", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@marca", entidad.marca);
            sqlCommand.Parameters.AddWithValue("idmarca", entidad.idmarca);

            registrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return registrosAfectados;
        }

    }
}
