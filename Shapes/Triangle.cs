using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSimulator.Shapes
{
    public class Triangle : Shape
    {
        public double Trianglebase { get; set; }
        public double Height { get; set; }
        public double TriangleAreaFactor = 2.00;

        public Triangle(double trianglebase, double height)
        {
            Trianglebase = trianglebase;
            Height = height;
        }


        public override double Area()
        {
            return (Trianglebase/ TriangleAreaFactor) * Height;
        }
    }
}
