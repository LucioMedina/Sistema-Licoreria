using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using ENTITIES;

namespace BOL
{
    public class Persona
    {
        DBAccess acceso = new DBAccess();
        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_listar_personas", 1);
        }

        public DataTable listarclientes()
        {
            return acceso.getDataFrom("spu_dninom_persona", 1);
        }
        

        public int registrar(EPersona entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_registrar_personas", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@apellidos", entidad.apellidos);
            sqlCommand.Parameters.AddWithValue("@nombres", entidad.nombres);
            sqlCommand.Parameters.AddWithValue("@dni", entidad.dni);
            sqlCommand.Parameters.AddWithValue("@telefono", entidad.telefono);
            

            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

        public int editar(EPersona entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_modificar_personas", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@apellidos", entidad.apellidos);
            sqlCommand.Parameters.AddWithValue("@nombres", entidad.nombres);
            sqlCommand.Parameters.AddWithValue("@dni", entidad.dni);
            sqlCommand.Parameters.AddWithValue("@telefono", entidad.telefono);
            sqlCommand.Parameters.AddWithValue("@idpersona",entidad.idpersona);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

        public int eliminar(EPersona entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_eliminar_persona", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;
 
            sqlCommand.Parameters.AddWithValue("@idpersona", entidad.idpersona);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }
    }
}
