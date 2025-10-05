namespace AbstractFactory.Figures
{
    internal class Rectangle : IFigure
    {
        private int Height { get; }

        private int Width { get; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public void GetArea()
        {
            Console.WriteLine($"Area: {Height * Width}");
        }
    }
}
