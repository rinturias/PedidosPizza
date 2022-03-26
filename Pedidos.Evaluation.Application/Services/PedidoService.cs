using Pedidos.Evaluation.Application.DTO;
using Pedidos.Evaluation.Application.Factory;
using Pedidos.Evaluation.Application.Factory.promociones;
using Pedidos.Evaluation.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Services
{
    public class PedidoService : IPedidoService
    {


         public PedidoService(){

          
         }

        public async Task<ResulService> GeneratePedido(PedidoRequestDTO pedidoRequestDTO)
        {

            IFactoryConcretePedido objFactory =   FactoryConcretePedido.BuildPedido(pedidoRequestDTO.codProducto);
            if(objFactory==null) return new ResulService { messaje = "Estimado usuario, no contamos con la pizza seleccionada", codError = "404" };
            PedidoBuildDTO result = await objFactory.generarPizza();
            result.promocion =await ContextPromocion.generarPromocion();
           return new ResulService { messaje = "producto creado Correctamente", success = true,data= result, codError = "0" };
        }
    }
}
