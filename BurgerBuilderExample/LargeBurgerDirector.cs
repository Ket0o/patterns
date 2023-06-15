using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderExample
{
    public class LargeBurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public LargeBurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.WithCheese();

            _builder.WithBacon();

            _builder.WithTomato();
        }
    }
}
