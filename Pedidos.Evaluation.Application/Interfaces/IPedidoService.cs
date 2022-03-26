using Pedidos.Evaluation.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Interfaces
{
   public interface IPedidoService
    {

        Task<ResulService> GeneratePedido(PedidoRequestDTO pedidoRequestDTO);

    }
}
