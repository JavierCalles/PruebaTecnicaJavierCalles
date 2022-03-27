using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackAplicacionPT.BusinessLogic.Interfaz
{
    public interface IClienteBol
    {
        bool IngresarCliente(BackAplicacionPT.Models.Cliente clientes);
        List<BackAplicacionPT.Models.Cliente> ConsultarCliente();
    }
}
