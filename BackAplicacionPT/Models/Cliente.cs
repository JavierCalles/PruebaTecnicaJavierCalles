using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackAplicacionPT.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string docIdenti { get; set; }
        public string priNom { get; set; }
        public string priApe { get; set; }
        public int Edad { get; set; }
        public string FechaIngreso { get; set; }
    }
}