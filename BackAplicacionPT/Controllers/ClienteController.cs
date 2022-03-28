using BackAplicacionPT.BusinessLogic.Cliente;
using BackAplicacionPT.BusinessLogic.Interfaz;
using BackAplicacionPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackAplicacionPT.Controllers
{
    public class ClienteController : ApiController
    {
        IClienteBol _cliente = new ClienteBol();

        [HttpPost]
        [Route("Cliente/IngresarCliente")]
        public bool IngresarCliente([FromBody] Cliente cliente)
        {
            try
            {
                return _cliente.IngresarCliente(cliente);
            }catch (Exception ex)
            {
                return false;
            }

        }

        [HttpGet]
        [Route("Cliente/ConsultarCliente")]
        public List<Cliente> IngresarCliente()
        {
            try { 
           return _cliente.ConsultarCliente();
            }catch (Exception ex)
            {
                List<Cliente> clientes = new List<Cliente>();
                return clientes;
            }

        }

        [HttpPut]
        [Route("Cliente/ActualizarCliente")]
        public bool ActualizarCliente([FromBody] Cliente cliente)
        {
            try
            {
                return _cliente.ActualizarCliente(cliente);
            }catch(Exception ex)
            {
                return false;
            }

        }


        [HttpDelete]
        [Route("Cliente/EliminarCliente")]
        public bool EliminarCliente([FromBody] int idcliente)
        {
            try
            {
                return _cliente.EliminarCliente(idcliente);
            }catch(Exception ex)
            {
                return false;
            }

        }


    }
}