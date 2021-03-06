using PruebaTecnicaJavierCalles.BusinessLogic.Clientes;
using PruebaTecnicaJavierCalles.BusinessLogic.Interfaz;
using PruebaTecnicaJavierCalles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTecnicaJavierCalles.Controllers
{
    public class ClientesController : Controller
    {
        public IClientesBol clienteBol = new ClientesBol();


        // GET: Clientes
        public ActionResult Index()
        {
            ListadoCliente listadoCliente = clienteBol.ConsultarCliente();

            return View(listadoCliente);
        }

        [HttpGet]
        public void IngresarCliente(string DocIdenti, string PrNom, string PrApe, int Edad)
        {
            try
            {
                ClientesModel clientes = new ClientesModel();
                clientes.docIdenti = DocIdenti;
                clientes.priNom = PrNom;
                clientes.priApe = PrApe;
                clientes.Edad = Edad;

                if (clienteBol.IngresarCliente(clientes))
                {
                    TempData["Mensaje"] = "Exito";
                }
                else
                {
                    TempData["Mensaje"] = "Error";
                }
            }catch (Exception ex)
            {
                TempData["Mensaje"] = "Error";
            }
        }

        [HttpPost]
        public void ActualizarCliente(string DocIdenti, string PrNom, string PrApe, int Edad, string IdCliente)
        {
            try
            {
                ClientesModel clientes = new ClientesModel();
                clientes.docIdenti = DocIdenti;
                clientes.priNom = PrNom;
                clientes.priApe = PrApe;
                clientes.Edad = Edad;
                clientes.idCliente = Convert.ToInt32(IdCliente);

                if (clienteBol.ActualizarCliente(clientes))
                {
                    TempData["Mensaje"] = "Exito";
                }
                else
                {
                    TempData["Mensaje"] = "Error";
                }
            }catch(Exception ex)
            {
                TempData["Mensaje"] = "Error";
            }
        }

        [HttpPost]
        public void EliminarCliente(int IdCliente)
        {
            try
            {
                if (clienteBol.EliminarCliente(IdCliente))
                {
                    TempData["Mensaje"] = "Exito";
                }
                else
                {
                    TempData["Mensaje"] = "Error";
                }
            }catch(System.Exception ex)
            {
                TempData["Mensaje"] = "Error";
            }
        }

    }
}
    