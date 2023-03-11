﻿using System;
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
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["VENTAS_LICORERIA"].ConnectionString);

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

        public DataTable getDataFrom(string spu, int estado)
        {
            DataTable dt = new DataTable();
            conectar();

            SqlCommand sqlCommand = new SqlCommand(spu, getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@estado", estado);
            dt.Load(sqlCommand.ExecuteReader());

            desconectar();
            return dt;
        }

        //public bool SumarStock(int idproducto, int cantidad)
        //{
        //    return prod.SumarStock(idproducto, cantidad);
        //}
    }
}
