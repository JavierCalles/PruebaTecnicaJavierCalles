using PruebaTecnicaJavierCalles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PruebaTecnicaJavierCalles.RemoteServices.Clientes
{
    public class ClientesService : Interfaz.IClientesService
    {
        RestApiConsumer ApiConsumer = new RestApiConsumer("http://localhost:44386/");
        public bool IngresarCliente(ClientesModel clientes)
        {

          var result  = ApiConsumer.Consume<bool>("Cliente", "IngresarCliente", clientes,RestSharp.Method.POST);
            return result;
        }

        public ListadoCliente ConsultarCliente()
        {
            ListadoCliente cliente = new ListadoCliente();
            
          cliente.clientes =  ApiConsumer.Consume<List<ClientesModel>>("Cliente", "ConsultarCliente", RestSharp.Method.GET);
           
            return cliente;
        }

        public bool ActualizarCliente(ClientesModel clientes)
        {

            var result = ApiConsumer.Consume<bool>("Cliente", "ActualizarCliente", clientes, RestSharp.Method.PUT);
            return result;
        }

        public bool EliminarCliente(int idCliente)
        {

            var result = ApiConsumer.Consume<bool>("Cliente", "EliminarCliente", idCliente, RestSharp.Method.DELETE);
            return result;
        }

    }
}