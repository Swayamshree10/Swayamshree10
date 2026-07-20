using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(-2, 2, 0)]
        [TestCase(100, 200, 300)]
        [TestCase(0, 0, 0)]
        public void Add_Test(int num1, int num2, int expected)
        {
            int actual = calculator.Add(num1, num2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}