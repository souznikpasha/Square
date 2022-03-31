using SandBox;
using NUnit.Framework;

namespace TestFigure
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Treangle treangle = new Treangle(7,8,4);
            Assert.AreEqual(13.997767679169419, treangle.Square());
        }
        [Test]
        public void Test2()
        {
            Treangle treangle = new Treangle(7,2,4);
            Assert.AreEqual(0, treangle.Square());
        }
        [Test]
        public void Test3()
        {
            Treangle treangle = new Treangle(4,2,2);
            Assert.AreEqual(0, treangle.Square());
        }
    }
}