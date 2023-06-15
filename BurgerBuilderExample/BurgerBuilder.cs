using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderExample
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;

        public BurgerBuilder()
        {
            _burger = new();
        }

        public void WithCheese()
        {
            _burger.Cheese = true;
        }
        
        public void WithBacon()
        {
            _burger.Bacon = true;
        }
        
        public void WithTomato()
        {
            _burger.Tomato = true;
        }

        public Burger GetBurger()
        {
            Burger burger = _burger;

            _burger = new();

            return burger;
        }
    }
}
