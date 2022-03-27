using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackAplicacionPT.DataAccess
{
    internal interface IConexion
    {
        bool ejecutar(string query, SqlParameter[] sqlParameter);
        SqlDataReader SqlQuery(string query, SqlParameter[] parameters);
    }
}
