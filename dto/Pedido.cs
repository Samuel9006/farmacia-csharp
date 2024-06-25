using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaUnir.dto
{
    public class Pedido
    {
        public required string Nombre { get; set; }
        public required string Tipo { get; set; }
        public required int Cantidad { get; set; }
        public required string Distribuidor { get; set; }
        public required bool SucPrincipal { get; set; }
        public required bool SucSecundaria { get; set; }
    }
}
