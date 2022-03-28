using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackAplicacionPT.BusinessLogic.Interfaz;
using BackAplicacionPT.DataAccess.Cliente;
using BackAplicacionPT.DataAccess.Interfaz;

namespace BackAplicacionPT.BusinessLogic.Cliente
{
    public class ClienteBol:IClienteBol
    {
        IClienteDao ClientesService = new ClienteDao();
        public bool IngresarCliente(BackAplicacionPT.Models.Cliente clientes)
        {
          return  ClientesService.IngresarCliente(clientes);
           
        }

        public List<BackAplicacionPT.Models.Cliente> ConsultarCliente()
        {
           return ClientesService.ConsultarCliente();
         
        }

        public bool ActualizarCliente(BackAplicacionPT.Models.Cliente clientes)
        {
            return ClientesService.ActualizarCliente(clientes);

        }

        public bool EliminarCliente(int idCliente)
        {
            return ClientesService.EliminarCliente(idCliente);

        }


    }
}