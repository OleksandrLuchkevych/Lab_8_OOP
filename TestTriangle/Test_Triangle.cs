using Lab_8_OOP;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Drawing;

namespace TestTriangle
{
    [TestClass]
    public class Test_Triangle
    {
        [TestMethod]
        public void Distance_point1_0_0_andpoint2_3_4_5returned()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(1, 4);

            double expected = 5;

            Triangle triangle = new Triangle(p1, p2, p3);

            double actual = triangle.Distance(p1,p2);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Perimetr_p1andp2andp2_12returned()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 4);
            Point p3 = new Point(3, 0);

            double expected = 12;

            Triangle triangle = new Triangle(p1, p2, p3);

            double actual = triangle.Perimeter();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Square_p1andp2andp2_8returned()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(2, 4);
            Point p3 = new Point(4, 0);

            double expected = 8;

            Triangle triangle = new Triangle(p1, p2, p3);

            double actual = triangle.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinimalDistance_p1andp2andp2_0returned()
        {
            Point Zero = new Point(0, 0);
            Point p1 = new Point(0, 0);
            Point p2 = new Point(2, 4);
            Point p3 = new Point(4, 0);

            double expected = 0;

            Triangle triangle = new Triangle(p1, p2, p3);

            double actual = triangle.MinimalDistance(Zero);

            Assert.AreEqual(expected, actual);
        }

    }
}