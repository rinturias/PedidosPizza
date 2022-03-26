using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Evaluation.Application.DTO;
using Pedidos.Evaluation.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Technical.Evaluation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase

    {
        private readonly IPedidoService _IPedidoService;
        public PedidosController(IPedidoService iPedidoService)
        {
            _IPedidoService = iPedidoService;
        }

        [HttpPost("GenerarPedido")]

        public async Task<IActionResult> GenerarPedido([FromBody] PedidoRequestDTO usuarioRequestDTO)
        {
            string namemethod = "C-GenerarPedido";
            try
            {
                //if (usuarioRequestDTO.Usuario == "") throw new Exception("debe ingresar su usuario");
                //if (usuarioRequestDTO.Clave == "") throw new Exception("Debe ingresar una clave");

                var exchange = await _IPedidoService.GeneratePedido(usuarioRequestDTO);

                return Ok(exchange);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResulService() { success = false, codError = "501", messaje = "Error en la solicitud", error = ex.Message });
            }
        }
    }
}
