using Pedidos.Evaluation.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Factory
{
    public class PizzaHawaiana : IFactoryConcretePedido
    {
        public async Task<dynamic> generarPizza()
        {
            PedidoBuildDTO obj = new PedidoBuildDTO()
            {
                tipoPizza = "PizzaHawaiana",
            };

            return obj;
        }
    }
}
