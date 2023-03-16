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
    public class Producto
    {
        DBAccess acceso = new DBAccess();

        public DataTable listar()
        {
            return acceso.getDataFrom("spu_productos_listar_todos");
        }

        public DataTable listarproduc()
        {
            return acceso.getDataFrom("spu_listar_productomodi");
        }

        
        public DataTable buscarCodigo(string codigo)
        {
            return acceso.getDataWithCondition("spu_productos_buscar_codigo", "@codigo", codigo);
        }

        public int registrar(EProducto entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_registrar_producto", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@codigo", entidad.codigo);
            sqlCommand.Parameters.AddWithValue("@idmarca", entidad.idmarca);
            sqlCommand.Parameters.AddWithValue("@idcategoria", entidad.idcategoria);
            sqlCommand.Parameters.AddWithValue("@nombre", entidad.nombre);
            sqlCommand.Parameters.AddWithValue("@precio", entidad.precio);
            sqlCommand.Parameters.AddWithValue("@stock", entidad.stock);
            

            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

        public int editar(EProducto entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_editar_producto", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@codigo", entidad.codigo);
            sqlCommand.Parameters.AddWithValue("@idmarca", entidad.idmarca);
            sqlCommand.Parameters.AddWithValue("@idcategoria", entidad.idcategoria);
            sqlCommand.Parameters.AddWithValue("@nombre", entidad.nombre);  
            sqlCommand.Parameters.AddWithValue("@precio", entidad.precio);
            sqlCommand.Parameters.AddWithValue("@stock", entidad.stock);
            sqlCommand.Parameters.AddWithValue("@idproducto", entidad.idproducto);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }
    }
}
