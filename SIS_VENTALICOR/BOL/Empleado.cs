using DAL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Empleado
    {
        DBAccess acceso = new DBAccess();
        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_listar_detalleempleado", 1);
        }

        public DataTable personasusuarios()
        {
            return acceso.getDataFrom("spu_personas_activas", 1);
        }

        public DataTable listarempleados()
        {
            return acceso.getDataFrom("spu_empleados_activos", 1);
        }

        


        public int registrar(EEmpleado entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_registrar_empleado", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@nombreusuario", entidad.usuario);
            sqlCommand.Parameters.AddWithValue("@claveacceso", entidad.claveacceso);
            sqlCommand.Parameters.AddWithValue("@idpersona", entidad.idpersona);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

        public int editar(EEmpleado entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_modificar_Empleado", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            
            sqlCommand.Parameters.AddWithValue("@claveacceso", entidad.claveacceso);
            sqlCommand.Parameters.AddWithValue("@idmpleado", entidad.idempleado);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

        public int eliminar(EEmpleado entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_eliminar_empleado", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            
            sqlCommand.Parameters.AddWithValue("@idempleado", entidad.idempleado);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }
    }
}
