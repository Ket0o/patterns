using FactoryMethod.Figures;

namespace FactoryMethod.Factories
{
    internal class ReactangleFigureFactory : FigureFactory
    {
        public override IFigure FactoryMethod()
        {
            Rectangle rectangle = new Rectangle(10, 10);
            return rectangle;
        }
    }
}
