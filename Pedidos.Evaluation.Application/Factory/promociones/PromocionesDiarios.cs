using Pedidos.Evaluation.Application.DTO;
using Pedidos.Evaluation.Application.Factory.promociones;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Factory
{
    public class PromocionesDiarios: IPromociones
    {
        private List<PromocionesDTO> _listPromocionDelDia;

        public PromocionesDiarios()
        {
            _listPromocionDelDia = new();
        }
        public Task<List<PromocionesDTO>> generarPromocion()
        {
            switch (generateDayLiteral())
            {
                case "1":
                    break;
                case "2":
                    PromocionMartes();
                    break;
                case "3":
                    PromocionMiercoles();
                    break;
                case "4":
                    PromocionJueves();
                    break;
                case "5":
                    break;
                case "6":
                    PromocionSavado();
                    break;
                case "7":
                    break;

            }
            return Task.FromResult( _listPromocionDelDia);
        }

        private  string generateDayLiteral()
        {           

            return  Convert.ToString((int)DateTime.Now.DayOfWeek);
        }

       private void PromocionMartes()
        {
            PromocionesDTO promocionesDTO = new()
            {    codPromocion = 20222,
                descripcionPromocion= "pizzas son 2x1"
            };
            _listPromocionDelDia.Add(promocionesDTO);
          
        }
        private void PromocionMiercoles()
        {
            PromocionesDTO promocionesDTO = new()
            {
                codPromocion = 20222,
                descripcionPromocion = "pizzas son 2x1"
            };
            _listPromocionDelDia.Add(promocionesDTO);

        }
        private void PromocionJueves()
        {
            PromocionesDTO promocionesDTO = new()
            {
                codPromocion = 20224,
                descripcionPromocion = "delivery es gratis"
            };
            _listPromocionDelDia.Add(promocionesDTO);
            
        }
        private void PromocionSavado()
        {
            PromocionesDTO promocionesDTO = new()
            {
                codPromocion = 20226,
                descripcionPromocion = "delivery es gratis"
            };
            _listPromocionDelDia.Add(promocionesDTO);

        }

    }
}
