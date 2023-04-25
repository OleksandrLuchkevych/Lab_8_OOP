using System;
using System.Runtime.CompilerServices;
using static Lab_8_OOP.Program;

namespace Lab_8_OOP
{
    internal class Program
    {
        public struct Point
        {
            public int X;
            public int Y;
            public Point(int x, int y)
            {
                X = x; Y = y;
            }
            public override string ToString()
            {
                return $"Point ({X};{Y})";
            }
        }
        public class Triangle
        {
            private Point _vertex1, _vertex2, _vertex3;


            public Triangle(Point vertex1, Point vertex2, Point vertex3)
            {
                _vertex1 = vertex1;
                _vertex2 = vertex2;
                _vertex3 = vertex3;
            }

            public double Distance(Point first, Point second)
            {
                return Math.Sqrt(Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2));
            }
            public double Perimeter()
            {
                double distance1 = Distance(_vertex1, _vertex2);
                double distance2 = Distance(_vertex1, _vertex3);
                double distance3 = Distance(_vertex2, _vertex3);

                return distance1 + distance2 + distance3;
            }
            public double Square()
            {
                double distance1 = Distance(_vertex1, _vertex2);
                double distance2 = Distance(_vertex1, _vertex3);
                double distance3 = Distance(_vertex2, _vertex3);
                double HalfPerimeter = Perimeter() / 2;

                return Math.Sqrt(HalfPerimeter * (HalfPerimeter - distance1) * (HalfPerimeter - distance2) * (HalfPerimeter - distance3));
            }

            public double MinimalDistance(Point zero)
            {
                double distance1 = Distance(zero, _vertex1);
                double distance2 = Distance(zero, _vertex2);
                double distance3 = Distance(zero, _vertex3);

                return Math.Min(distance1, Math.Min(distance2, distance3));
            }

            public void Print()
            {
                Console.WriteLine($"Vertices of the triangle: {_vertex1}, {_vertex2}, {_vertex3}, Perimetr is {Perimeter()} and Square is {Square()} ");
            }
        }
        static void Main(string[] args)
        {
            Point Zero = new Point(0,0);

            List<Triangle> triangleList = new List<Triangle>
            {
                new Triangle(new Point(0, 0), new Point(2, 4), new Point(4, 0)),
                new Triangle(new Point(9, 0), new Point(0, 4), new Point(2, 0)),
                new Triangle(new Point(4, 7), new Point(2, 6), new Point(1, 0)),

            };
            foreach (Triangle triangle in triangleList)
            {
                triangle.Print();
                Console.WriteLine();
            }

            Triangle closestTriangle = triangleList[0];
            double closestDistance = closestTriangle.MinimalDistance(Zero);

            foreach (Triangle triangle in triangleList)
            {
                double distance = triangle.MinimalDistance(Zero);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestTriangle = triangle;
                }
            }

            Console.WriteLine("Triangle closest to (0, 0):");
            closestTriangle.Print();
        }
    }
}