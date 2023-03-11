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
        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_listar_producto", 1);
        }


        public DataTable listarproductos()
        {
            return acceso.getDataFrom("spu_nombre_produc", 1);
        }
        
        public int registrar(EProducto entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_registrar_producto", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@idmarca", entidad.idmarca);
            sqlCommand.Parameters.AddWithValue("@idcategoria", entidad.idcategoria);
            sqlCommand.Parameters.AddWithValue("@nombreproducto", entidad.nombreproducto);
            sqlCommand.Parameters.AddWithValue("@codigo", entidad.codigo);
            sqlCommand.Parameters.AddWithValue("@descripcion", entidad.descripcion);
            sqlCommand.Parameters.AddWithValue("@precio", entidad.precio);
            sqlCommand.Parameters.AddWithValue("@stock", entidad.stock);
            sqlCommand.Parameters.AddWithValue("@caducidad", entidad.caducidad);

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

            sqlCommand.Parameters.AddWithValue("@idmarca", entidad.idmarca);
            sqlCommand.Parameters.AddWithValue("@idcategoria", entidad.idcategoria);
            sqlCommand.Parameters.AddWithValue("@nombreproducto", entidad.nombreproducto);
            sqlCommand.Parameters.AddWithValue("@descripcion", entidad.descripcion);
            sqlCommand.Parameters.AddWithValue("@codigo", entidad.codigo);
            sqlCommand.Parameters.AddWithValue("@precio", entidad.precio);
            sqlCommand.Parameters.AddWithValue("@stock", entidad.caducidad);
            sqlCommand.Parameters.AddWithValue("@caducidad", entidad.caducidad);
            sqlCommand.Parameters.AddWithValue("@idproducto", entidad.idproducto);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

        public int eliminar(EProducto entidad)
        {
            int resgistrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_producto_eliminar", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@codigo", entidad.codigo);


            resgistrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();
            return resgistrosAfectados;
        }

        //public DataTable registrar(string idmarca, string idcategoria, string nombre, string descripcion, string precio, string stock, string caducidad, string codigo)
        //{
        //    DataTable data = new DataTable();

        //    acceso.conectar();

        //    SqlCommand cmd = new SqlCommand("spu_registrar_producto", acceso.getConexion());
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@idmarca", idmarca);
        //    cmd.Parameters.AddWithValue("@idcategoria", idcategoria);
        //    cmd.Parameters.AddWithValue("@nombreproducto", nombre);
        //    cmd.Parameters.AddWithValue("@descripcion", descripcion);
        //    cmd.Parameters.AddWithValue("@precio", precio);
        //    cmd.Parameters.AddWithValue("@stock", stock);
        //    cmd.Parameters.AddWithValue("@caducidad", caducidad);
        //    cmd.Parameters.AddWithValue("@codigo", codigo);


        //    data.Load(cmd.ExecuteReader());

        //    acceso.desconectar();

        //    return data;
        //}

        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (acceso.getConexion())
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @cantidad where idproducto = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), acceso.getConexion());
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    acceso.conectar();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }
    }
}
