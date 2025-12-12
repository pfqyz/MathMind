using NUnit.Framework;

namespace MathMind.Tests
{
    [TestFixture]
    public class SimpleTests
    {
        [Test]
        public void AdditionTest()
        {
            Assert.AreEqual(10, 5 + 5);
        }

        [Test]
        public void TrueTest()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void FalseTest()
        {
            Assert.IsFalse(false);
        }
    }
}