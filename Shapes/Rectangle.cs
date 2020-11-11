using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSimulator.Shapes
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
