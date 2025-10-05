using AbstractFactory.Figures;

namespace AbstractFactory.Factories
{
    public abstract class FigureFactory
    {
        public abstract IFigure FactoryMethod();
    }
}
