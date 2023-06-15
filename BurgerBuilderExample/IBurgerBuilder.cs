using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerBuilderExample
{
    public interface IBurgerBuilder
    {
        void WithCheese();

        void WithBacon();

        void WithTomato();

    }
}
