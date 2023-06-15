using Shapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Factories
{
    public abstract class FigureFactory
    {
        public abstract IFigure FactoryMethod();
    }
}
