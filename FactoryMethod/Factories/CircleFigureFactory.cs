using FactoryMethod.Figures;

namespace FactoryMethod.Factories
{
    public class CircleFigureFactory : FigureFactory
    {
        public override IFigure FactoryMethod()
        {
            Circle circle = new Circle(2.5);
            return circle;
        }
    }
}
