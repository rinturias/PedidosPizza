using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Evaluation.Application.Factory
{
   public class FactoryConcretePedido
    {

        public static class TYPE_PIZZA
        {
            public const int
            PizzaHawaiana = 1,
            PizzaMargarita = 2,
            PizzaNapolitana = 3,
            PizzaPersonalizadas=4;
        }



        public static IFactoryConcretePedido BuildPedido(int typeCurrency)
        {


            switch (typeCurrency)
            {
                case TYPE_PIZZA.PizzaHawaiana: return new PizzaHawaiana();

                case TYPE_PIZZA.PizzaMargarita: return new PizzaMargarita();

                case TYPE_PIZZA.PizzaNapolitana: return new PizzaNapolitana();

                case TYPE_PIZZA.PizzaPersonalizadas: return new PizzaPersonalizada();

                default: return null;

            }


        }



    }
}
