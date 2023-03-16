using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace BOL
{
    public class Venta
    {
        DBAccess acceso = new DBAccess();

        public int registrar(EVenta entidad)
        {
            SqlCommand comando = new SqlCommand("spu_venta_registrar", acceso.getConexion());
            int idobtenido;

            acceso.conectar();

            try
            {
                comando.CommandType = CommandType.StoredProcedure;

                
                SqlParameter idventa = new SqlParameter();
                idventa.ParameterName = "@idventa";
                idventa.DbType = DbType.Int32;
                idventa.Direction = ParameterDirection.Output;

                
                comando.Parameters.Add(idventa);

               
                comando.Parameters.AddWithValue("@tipocomprobante", entidad.tipocomprobante);
                comando.Parameters.AddWithValue("@numcomprobante", entidad.numcomprobante);
                comando.Parameters.AddWithValue("@idcliente", entidad.idpersona);
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

        public bool registrarDetalle(EDventa entidad)
        {
            bool guardadoCorrectamente = false;
            SqlCommand comando = new SqlCommand("spu_detventa_registrar", acceso.getConexion());
            acceso.conectar();

            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idventa", entidad.idventa);
                comando.Parameters.AddWithValue("@idproducto", entidad.idproducto);
                comando.Parameters.AddWithValue("@cantidad", entidad.cantidad);
                comando.Parameters.AddWithValue("@precioventa", entidad.precioventa);

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
