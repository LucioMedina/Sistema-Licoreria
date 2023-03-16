using ENTITIES;
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
    public class Proveedor
    {
        DBAccess acceso = new DBAccess();

        public DataTable listar()
        {
            return acceso.getDataFrom("spu_proveedor_listar");
        }

        public int registrar(EProveedor entidad)
        {
            int resgistrosAfectados = 0;
            
            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_proveedor_registrar", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@nombreprov", entidad.nombreprov);
            sqlCommand.Parameters.AddWithValue("@direcion", entidad.direccion);
            sqlCommand.Parameters.AddWithValue("@ruc", entidad.ruc);
            sqlCommand.Parameters.AddWithValue("@telefono", entidad.telefono);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }


        public int editar(EProveedor entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_proveedor_editar", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@nombreprov", entidad.nombreprov);
            sqlCommand.Parameters.AddWithValue("@direccion", entidad.direccion);
            sqlCommand.Parameters.AddWithValue("@ruc", entidad.ruc);
            sqlCommand.Parameters.AddWithValue("@telefono", entidad.telefono);
            sqlCommand.Parameters.AddWithValue("@idproveedor", entidad.idproveedor);



            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

    }
}
