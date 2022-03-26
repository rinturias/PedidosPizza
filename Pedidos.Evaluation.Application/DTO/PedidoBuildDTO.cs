using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.DTO
{
   public class PedidoBuildDTO
    {
        public decimal precio { get; set; }
        public dynamic promocion { get; set; }
        public dynamic detalle { get; set; }

        public string tipoPizza { get; set; }

    }
}
