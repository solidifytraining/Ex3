using NUnit.Framework;
using Math;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            var sut = new MathCalc();

            var res = sut.Add(2, 3);

            Assert.That(res, Is.EqualTo(5), "This was strange");
        }
    }
}