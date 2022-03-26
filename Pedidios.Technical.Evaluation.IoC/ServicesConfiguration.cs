
using Microsoft.Extensions.DependencyInjection;
using Pedidos.Evaluation.Application;
using Pedidos.Evaluation.Application.Interfaces;
using Pedidos.Evaluation.Application.Services;
using System;

namespace Pedidios.Technical.Evaluation.IoC
{
    public static class ServicesConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {

            

           // services.AddScoped<IContextDatabase, ContextDatabase>();
            services.AddScoped<IPedidoService, PedidoService>();

        }
    }
}
