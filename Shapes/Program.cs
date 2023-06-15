using Shapes.Shapes;
using Shapes.Factories;

class Program
{
    static void Main()
    {
        Console.WriteLine("Create rectangle --> 3");
        Console.WriteLine("Create circle --> 1");

        var figureType = int.Parse(Console.ReadLine());

        FigureFactory factory = GetFactory(figureType);

        IFigure figure = factory.FactoryMethod();

        figure.GetArea();
    }

    private static FigureFactory GetFactory(int figureType)
    {
        switch(figureType)
        {
            case 1:
                {
                    return new CircleFigureFactory();
                }
                break;
            case 3:
                {
                    return new ReactangleFigureFactory();
                }
                break;
            default:
                {
                    return null;
                }
        }
    }
}