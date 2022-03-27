using PruebaTecnicaJavierCalles.BusinessLogic.Interfaz;
using PruebaTecnicaJavierCalles.Models;
using PruebaTecnicaJavierCalles.RemoteServices.Clientes;
using PruebaTecnicaJavierCalles.RemoteServices.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static PruebaTecnicaJavierCalles.Controllers.ClientesController;

namespace PruebaTecnicaJavierCalles.BusinessLogic.Clientes
{
    public class ClientesBol: IClientesBol
    {
        IClientesService ClientesService = new ClientesService();
        public bool IngresarCliente(ClientesModel clientes)
        {
           return  ClientesService.IngresarCliente(clientes);
            
        }

        public ListadoCliente ConsultarCliente()
        {
           return  ClientesService.ConsultarCliente();  
        }
    }
}