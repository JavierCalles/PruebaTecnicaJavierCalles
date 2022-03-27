using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnicaJavierCalles.Models
{
    public class ClientesModel
    {
        public int idCliente { get; set; }
        public string docIdenti { get; set; }
        public string priNom { get; set; }
        public string priApe { get; set; }
        public int Edad { get; set; }
        public string FechaIngreso { get; set; }
    }

    public class ListadoCliente
    {
        public List<ClientesModel> clientes { get; set; }
    }

}