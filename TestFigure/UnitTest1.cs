using Figure;
using NUnit.Framework;

namespace TestFigure
{
    public class Tests
    {
        [Test]
        public void Square1()
        {
            Treangle treangle = new Treangle(7,8,4);
            Assert.AreEqual(13.997767679169419, treangle.Square());
        }
        [Test]
        public void Square2()
        {
            Treangle treangle = new Treangle(7,2,4);
            Assert.AreEqual(0, treangle.Square());
        }
        [Test]
        public void Square3()
        {
            Treangle treangle = new Treangle(4,2,2);
            Assert.AreEqual(0, treangle.Square());
        }
        [Test]
        public void RightTriangle1()
        {
            Treangle treangle = new Treangle(7,8,4);
            Assert.AreEqual(false, treangle.IsCorrectRectangle());
        }
        [Test]
        public void RightTriangle2()
        {
            Treangle treangle = new Treangle(7,2,4);
            Assert.AreEqual(false, treangle.IsCorrectRectangle());
        }
        [Test]
        public void RightTriangle3()
        {
            Treangle treangle = new Treangle(6, 8, 10);
            Assert.AreEqual(true, treangle.IsCorrectRectangle());
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