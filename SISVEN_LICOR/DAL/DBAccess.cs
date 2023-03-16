using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBAccess
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VENTAS_LICOR"].ConnectionString);


        public SqlConnection getConexion()
        {
            return this.conn;
        }

        public void conectar()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                this.conn.Open();
            }
        }

        public void desconectar()
        {
            if (this.conn.State == ConnectionState.Open)
            {
                this.conn.Close();
            }
        }

        
        public DataTable getDataFrom(string spu)
        {
            DataTable dt = new DataTable();
            conectar();

            SqlCommand sqlCommand = new SqlCommand(spu, getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;
            dt.Load(sqlCommand.ExecuteReader());

            desconectar();
            return dt;
        }

        public int consultarlogin(string usuario, string clave)
        {
            int contar;

            conn.Open();
            string Query = "Select count(*) from usuarios where usuario ='" + usuario + "'" +
                "and clave = '" + clave + "'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            contar = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return contar;

        }

        public DataTable getDataWithCondition(string spu, string key, string value)
        {
            DataTable dt = new DataTable();
            conectar();

            SqlCommand sqlCommand = new SqlCommand(spu, getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue(key, value);
            dt.Load(sqlCommand.ExecuteReader());

            desconectar();
            return dt;
        }
    }
}

