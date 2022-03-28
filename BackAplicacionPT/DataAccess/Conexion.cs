using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BackAplicacionPT.DataAccess
{
    public class Conexion:IConexion
    {
        string cadena = ConfigurationManager.ConnectionStrings["SqlConexion"].ToString();
        public bool ejecutar(string query, SqlParameter[] sqlParameter)
        {
            try
            {

                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddRange(sqlParameter);
                
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public SqlDataReader SqlQuery(string query, SqlParameter[] parameters)
        {
            try
            {

            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddRange(parameters);

            return  cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                SqlDataReader sqlDataReader = null;
                return sqlDataReader;
            }

        }

      

    }
}