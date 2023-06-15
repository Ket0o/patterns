using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderExample
{
    public class SmallBurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public SmallBurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.WithCheese();

            _builder.WithTomato();
        }
    }
}
