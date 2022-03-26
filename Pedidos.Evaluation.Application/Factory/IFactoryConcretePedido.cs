using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Factory
{
  public  interface IFactoryConcretePedido
    {
        Task<dynamic> generarPizza();
    }
}
