using Pedidos.Evaluation.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Factory
{
  public  class PizzaPersonalizada : IFactoryConcretePedido
    {
        public async Task<dynamic> generarPizza()
        {

                var pizzaPersonalizada = PizzaFluentBuilder.Crear()
                                       .ConMasaSuave()
                                       .ConSalsaRoquefort()
                                       .AñadirMozzarela()
                                       .AñadirParmesano()
                                       .Cocinar();

            PedidoBuildDTO obj = new PedidoBuildDTO()
            {
                tipoPizza = "PizzaPersonalizada",
                detalle= pizzaPersonalizada,
            };

            return obj;
        }
    
    
    }
}
