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
            
           return  _cliente.IngresarCliente(cliente);

        }

        [HttpGet]
        [Route("Cliente/ConsultarCliente")]
        public List<Cliente> IngresarCliente()
        {

           return _cliente.ConsultarCliente();

        }

        [HttpPut]
        [Route("Cliente/ActualizarCliente")]
        public bool ActualizarCliente([FromBody] Cliente cliente)
        {

            return _cliente.ActualizarCliente(cliente);

        }

    }
}