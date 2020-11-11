using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSimulator.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) => Radius = radius;


        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
