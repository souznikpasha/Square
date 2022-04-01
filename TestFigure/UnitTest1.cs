using Figure;
using NUnit.Framework;

namespace TestFigure
{
    public class Tests
    {
        [Test]
        public void Square1()
        {
            Triangle triangle = new Triangle(7,8,4);
            Assert.AreEqual(13.997767679169419, triangle.Square());
        }
        [Test]
        public void Square2()
        {
            Triangle triangle = new Triangle(7,2,4);
            Assert.AreEqual(0, triangle.Square());
        }
        [Test]
        public void Square3()
        {
            Triangle triangle = new Triangle(4,2,2);
            Assert.AreEqual(0, triangle.Square());
        }
        [Test]
        public void RightTriangle1()
        {
            Triangle triangle = new Triangle(7,8,4);
            Assert.AreEqual(false, triangle.IsCorrectRectangle());
        }
        [Test]
        public void RightTriangle2()
        {
            Triangle triangle = new Triangle(7,2,4);
            Assert.AreEqual(false, triangle.IsCorrectRectangle());
        }
        [Test]
        public void RightTriangle3()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            Assert.AreEqual(true, triangle.IsCorrectRectangle());
        }
        [Test]
        public void Circle1()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(15.707963267948966d, circle.Square());
        }
        [Test]
        public void Circle2()
        {
            Circle circle = new Circle(20);
            Assert.AreEqual(62.831853071795862d , circle.Square());
        }
    }
}