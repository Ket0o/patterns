namespace FactoryMethod.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void GetArea()
        {
            Console.WriteLine($"Area: {Radius * Radius * Math.PI}");
        }
    }
}
