using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void Demerit_ThorwnAnExceptionOutOfRange_OutOfRange(int speed)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() 
                => calculator.CalculateDemeritPoints(speed));
        }

        [Test]
        [TestCase(65)]
        [TestCase(100)]
        public void Demerit_ShouldReturnInt_DemeritPoints(int speed)
        {
            calculator.CalculateDemeritPoints(speed);
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_speedisZeroOrLessthatSpeedLimit_ReturnDemeritPoints(int speed,int excpectedResult)
        {
            int points = calculator.CalculateDemeritPoints(speed);
            Assert.That(points, Is.EqualTo(excpectedResult));
        }

        
    }
}
