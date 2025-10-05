using Shapes.Shapes;
using Shapes.Factories;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Create circle --> 1");
            Console.WriteLine("Create rectangle --> 2");
            Console.WriteLine("Exit --> any button");

            var figureType = Console.ReadLine();
            
            if (figureType == null)
                continue;
            
            if (GetFactory(figureType) is not {} factory)
                break;
            
            var figure = factory.FactoryMethod();

            figure.GetArea();
            Console.WriteLine();
        }
        
    }

    private static FigureFactory? GetFactory(string figureType)
    {
        switch(figureType)
        {
            case "1":
                {
                    return new CircleFigureFactory();
                }
                break;
            case "2":
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