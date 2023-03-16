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
    public class Compra
    {
        DBAccess acceso = new DBAccess();

        public int registrar(ECompra entidad)
        {
            SqlCommand comando = new SqlCommand("spu_compra_registrar", acceso.getConexion());
            int idobtenido;

            acceso.conectar();

            try
            {
                comando.CommandType = CommandType.StoredProcedure;


                SqlParameter idventa = new SqlParameter();
                idventa.ParameterName = "@idcompra";
                idventa.DbType = DbType.Int32;
                idventa.Direction = ParameterDirection.Output;


                comando.Parameters.Add(idventa);

                comando.Parameters.AddWithValue("@idproveedor", entidad.idproveedor);
                comando.Parameters.AddWithValue("@tipocomprobante", entidad.tipocomporbante);
                comando.Parameters.AddWithValue("@numcomprobante", entidad.numcomprobante);
                comando.Parameters.AddWithValue("tipopago", entidad.tipopago);

                comando.ExecuteNonQuery();


                idobtenido = Convert.ToInt32(idventa.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                idobtenido = -1;
            }
            finally
            {
                acceso.desconectar();
            }

            return idobtenido;
        }

        public bool registrarDetalle(EDcompra entidad)
        {
            bool guardadoCorrectamente = false;
            SqlCommand comando = new SqlCommand("spu_detcompra_registrar", acceso.getConexion());
            acceso.conectar();

            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idcompra", entidad.idcompra);
                comando.Parameters.AddWithValue("@idproducto", entidad.idproducto);
                comando.Parameters.AddWithValue("@cantidad", entidad.cantidad);
                comando.Parameters.AddWithValue("@precioventa", entidad.precioventa);
                comando.Parameters.AddWithValue("@preciocompra", entidad.preciocompra);

                if (comando.ExecuteNonQuery() > 0)
                {
                    guardadoCorrectamente = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                guardadoCorrectamente = false;
            }
            finally
            {
                acceso.desconectar();
            }

            return guardadoCorrectamente;
        }
    }

}

