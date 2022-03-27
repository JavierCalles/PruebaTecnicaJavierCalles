using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BackAplicacionPT.DataAccess
{
    public class Conexion:IConexion
    {

        public bool ejecutar(string query, SqlParameter[] sqlParameter)
        {
            try
            {

                SqlConnection con = new SqlConnection("server = DESKTOP-6MBUAD3\\ARMANDOPC; database = PT_JAVIERCALLES;User ID=usuario;Password=R363teamo");
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

            SqlConnection con = new SqlConnection("server = DESKTOP-6MBUAD3\\ARMANDOPC; database = PT_JAVIERCALLES; integrated security = true");
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