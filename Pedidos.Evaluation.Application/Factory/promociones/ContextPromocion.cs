using Pedidos.Evaluation.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Factory.promociones
{
   public class ContextPromocion
    {
        private static IPromociones _promociones;
        public async static Task<List<PromocionesDTO>> generarPromocion()
        {
            _promociones = new PromocionesDiarios();
          return await  _promociones.generarPromocion();
        }

    }
}
