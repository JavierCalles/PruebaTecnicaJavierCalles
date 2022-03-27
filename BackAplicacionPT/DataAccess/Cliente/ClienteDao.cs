using BackAplicacionPT.DataAccess.Interfaz;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BackAplicacionPT.DataAccess.Cliente
{
    public class ClienteDao:IClienteDao
    {
        IConexion conexion = new Conexion();
        public bool IngresarCliente(BackAplicacionPT.Models.Cliente clientes)
        {

            string query = @"insert into cliente
                            (primerNombre,primerApellido,Edad,documentoIdentidad,FechaIngreso) values (
                            @Nombre,@Apellido,@Edad,@DocIdenti,GETDATE());";
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@Nombre", clientes.priNom);
            sp[1] = new SqlParameter("@Apellido", clientes.priApe);
            sp[2] = new SqlParameter("@Edad", clientes.Edad);
            sp[3] = new SqlParameter("@DocIdenti", clientes.docIdenti);

            return conexion.ejecutar(query,sp);

           
        }

        public List<BackAplicacionPT.Models.Cliente> ConsultarCliente()
        {
            List<BackAplicacionPT.Models.Cliente> clientes = new List<Models.Cliente>();
            string query = @"select idCliente,documentoIdentidad,primerNombre,primerApellido,Edad,CONVERT(varchar,FechaIngreso,5) as FechaIngreso from cliente;";
            SqlParameter[] sp = new SqlParameter[0];
           
            SqlDataReader reader =   conexion.SqlQuery(query, sp);

            while(reader.Read())
            {
                BackAplicacionPT.Models.Cliente cliente = new BackAplicacionPT.Models.Cliente();
                cliente.idCliente = Convert.ToInt32(reader["idCliente"].ToString());
                cliente.docIdenti = reader["documentoIdentidad"].ToString();
                cliente.priNom = reader["primerNombre"].ToString();
                cliente.priApe = reader["primerApellido"].ToString();
                cliente.Edad = Convert.ToInt32(reader["Edad"].ToString());
                cliente.FechaIngreso = reader["FechaIngreso"].ToString();

                clientes.Add(cliente);
            }

            return clientes;

        }

    }
}