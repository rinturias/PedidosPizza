using Pedidos.Evaluation.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Factory
{
    public class PizzaMargarita : IFactoryConcretePedido
    {
        public async Task<dynamic> generarPizza()
        {
            PedidoBuildDTO obj = new PedidoBuildDTO()
            {
                tipoPizza = "PizzaMargarita",
            };

            return obj;
        }
    }
}
