using NUnit.Framework;
using Calculator.Logger;
using Moq;
using Moq.Language.Flow;

namespace Calculator.Tests
{
    public class SimpleCalculatorUnitTests
    {
        public ISimpleCalculator Calculator;
        public Mock<ILogger> MockLogger;
        
        [SetUp]
        public void Setup()
        {
            Calculator = new SimpleCalculator();
            MockLogger = new Mock<ILogger>(MockBehavior.Strict);
        }

        [TestCase(1, 5, 6)]
        [TestCase(100, 200, 300)]
        [TestCase(-63, 54, -9)]
        [TestCase(-50, -50, -100)]
        public void Add_Normal_ReturnsExpectedResult(int start, int amount, int expectedResult)
        {
            var result = Calculator.Add(start, amount);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1, 5, -4)]
        [TestCase(100, 200, -100)]
        [TestCase(-63, 54, -117)]
        [TestCase(-50, -50, 0)]
        public void Subtract_Normal_ReturnsExpectedResult(int start, int amount, int expectedResult)
        {
            var result = Calculator.Subtract(start, amount);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1, 5, 5)]
        [TestCase(100, 200, 20000)]
        [TestCase(-63, 54, -3402)]
        [TestCase(-50, -50, 2500)]
        public void Multiply_Normal_ReturnsExpectedResult(int start, int by, int expectedResult)
        {
            var result = Calculator.Multiply(start, by);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(36, 6, 6)]
        [TestCase(-84, 7, -12)]
        [TestCase(100, 200, 0)]
        [TestCase(-63, 54, -1)]
        [TestCase(-50, -50, 1)]
        public void Divide_Normal_ReturnExpectedResult(int start, int by, int expectedResult)
        {
            var result = Calculator.Divide(start, by);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}