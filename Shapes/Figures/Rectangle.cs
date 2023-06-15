using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    internal class Rectangle : IFigure
    {
        public int Height { get; set; }

        public int Width { get; set; }

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
