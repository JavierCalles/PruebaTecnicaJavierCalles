﻿using PruebaTecnicaJavierCalles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PruebaTecnicaJavierCalles.Controllers.ClientesController;

namespace PruebaTecnicaJavierCalles.BusinessLogic.Interfaz
{
    public interface IClientesBol
    {
        bool IngresarCliente(ClientesModel clientes);
        ListadoCliente ConsultarCliente();
        bool ActualizarCliente(ClientesModel clientes);
        bool EliminarCliente(int idCliente);
    }
}
