using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using ShapeSimulator.Shapes;
using Rectangle = ShapeSimulator.Shapes.Rectangle;

namespace ShapeSimulator
{
    public class ShapeHelper
    {
        public ShapeHelper() { }

        public void GetRectangleArea()
        {

            Console.Write("Enter Height: ");
            var heightInput = Console.ReadLine();
            double height;

            while (!double.TryParse(heightInput, out height))
            {
                Console.WriteLine($"Please enter a valid number.");
                heightInput = Console.ReadLine();
            }


            Console.Write("Enter Width: ");
            var widthInput = Console.ReadLine();
            double width;

            while (!double.TryParse(widthInput, out width))
            {
                Console.WriteLine($"Please enter a valid number.");
                widthInput = Console.ReadLine();
            }

            Rectangle rectangle = new Rectangle(height, width);
            Console.WriteLine($"Area of rectangle is: {rectangle.Area()}");

        }

        public void GetTriangleArea()
        {

            Console.Write("Enter Triangle Base Length: ");
            var inputLength = Console.ReadLine();
            double length;

            while (!double.TryParse(inputLength, out length))
            {
                Console.WriteLine($"Please enter a valid number.");
                inputLength = Console.ReadLine();
            }


            Console.Write("Enter Height: ");
            var inputHeight = Console.ReadLine();
            double height;

            while (!double.TryParse(inputHeight, out height))
            {
                Console.WriteLine($"Please enter a valid number.");
                inputHeight = Console.ReadLine();
            }


            Triangle triangle = new Triangle(length, height);
            Console.WriteLine($"Area of triangle is: {triangle.Area()}");

        }

        public void GetCircleArea()
        {

            Console.Write("Enter circle radius: ");
            var inputRadius = Console.ReadLine();
            double radius;

            while (!double.TryParse(inputRadius, out radius))
            {
                Console.WriteLine($"Please enter a valid number.");
                inputRadius = Console.ReadLine();
            }


            Circle circle = new Circle(radius);
            Console.WriteLine($"Area of circle is: {circle.Area()}");

        }

        public void GetPolygonArea()
        {

            List<PointF> vertices = new List<PointF>();

            var coordinate = new PointF();

            while (true)
            {

                Console.Write("Enter x-coordinate or press enter when finished: ");
                var inputX = Console.ReadLine();
                float x, y;

                if (inputX == string.Empty)
                {
                    break;
                }

                while (!float.TryParse(inputX, out x))
                {
                    Console.Write("Please enter a valid number: ");
                    inputX = Console.ReadLine();

                }
                coordinate.X = x;

                Console.Write("Enter y-coordinate: ");
                var inputY = Console.ReadLine();
                
                // TODO: Reserved for debugging/testing, remove when complete
                //if (inputY == string.Empty)
                //{
                //    break;
                //}

                while (!float.TryParse(inputY, out y))
                {
                    Console.Write("Please enter a valid number: ");
                    
                    inputY = Console.ReadLine();
                }
                coordinate.Y = y;

                vertices.Add(coordinate);
            }

            if (vertices.Count < 3)
            {
                Console.WriteLine("Less than 3 co-ordinates specified. Returning to menu.");
                return;
            }
            
            Console.WriteLine($"Area of polygon is: {CalcArea(vertices)}");
            
        }

        /// <summary>
        /// Calculates the total area by summing the trapezoid area between each pair of co-ordinates and taking the absolute value.
        /// The algorithm gives strange results for polygons where edges cross.
        /// Source https://web.archive.org/web/20120410040052/http://blog.csharphelper.com/2010/01/04/calculate-a-polygons-area-in-c.aspx
        /// </summary>
        /// <param name="vertices"></param>
        /// <returns> area of polygon </returns>
        private static double CalcArea(List<PointF> vertices)
        {
            // Adds the initial co-ordinates to the end of the list to close off the shape
            vertices.Add(vertices[0]);

            
            return (Math.Abs(vertices.Take(vertices.Count - 1)
                .Select((p, i) => (p.X * vertices[i + 1].Y) - (p.Y * vertices[i + 1].X)).Sum() / 2));
        }


    }

    
}

