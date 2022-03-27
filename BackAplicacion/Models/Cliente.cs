using System;
using System.Collections.Generic;

namespace BackAplicacion.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
