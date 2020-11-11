using System;
using System.Threading.Channels;
using ShapeSimulator.Shapes;

namespace ShapeSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"Select (A-C) for a pre-defined shape, (D) for a polygon or ESC to exit:
                (A) Rectangle
                (B) Triangle
                (C) Circle
                (D) Polygon");

                var key = Console.ReadKey();
                Console.WriteLine();

                ShapeHelper shape = new ShapeHelper();

                switch (key.Key)
                {
                    case ConsoleKey.A:
                        shape.GetRectangleArea();
                        break;
                    case ConsoleKey.B:
                        shape.GetTriangleArea();
                        break;
                    case ConsoleKey.C:
                        shape.GetCircleArea();
                        break;
                    case ConsoleKey.D:
                        shape.GetPolygonArea();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Exiting..");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }
        }
    }
}
