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
    public class Cliente
    {
        DBAccess acceso = new DBAccess();

        public DataTable listar()
        {
            return acceso.getDataFrom("spu_clientes_listar_todos");
        }

        public int registrar(ECliente entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_registrar_personas", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@apellidos", entidad.apellidos);
            sqlCommand.Parameters.AddWithValue("@nombres", entidad.nombres);
            sqlCommand.Parameters.AddWithValue("@dni", entidad.dni);
          

            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

        public int editar(ECliente entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_modificar_personas", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@apellidos", entidad.apellidos);
            sqlCommand.Parameters.AddWithValue("@nombres", entidad.nombres);
            sqlCommand.Parameters.AddWithValue("@dni", entidad.dni);
            sqlCommand.Parameters.AddWithValue("@idpersona", entidad.idpersona);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }
    }
}
