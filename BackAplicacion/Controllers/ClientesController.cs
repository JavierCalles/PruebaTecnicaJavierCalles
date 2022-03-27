using BackAplicacion.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackAplicacion.Controllers
{
    [Route("api/Clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        [HttpPost, Route("~/api/Clientes/IngresarCliente")]
        public bool IngresarCliente([FromBody] ClienteDto cliente)
       {
            return true;
       }

    }
}
