using NUnit.Framework;
using TestNinja.Fundamentals;
using System;
using System.Linq;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTest
    {
        private Fundamentals.Math math;
        
        [SetUp]
        public void SetUp()
        {
            math = new Fundamentals.Math();
        }

        [Test]
        public void Add_WhenCalleed_ReturnTheSumOfArguments()
        {
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }


        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturningThatGreaterResult(int a,int b, int expectedResult)
        {    
            var result = math.Max(a, b);
            Assert.That(result , Is.EqualTo(expectedResult));
        }


        [Test]
        public void GetOddNumber_LimitIsGreaterThanZero_ReturhOddNumbersupTpLimit()
        {
            var result = math.GetOddNumbers(5);

            Assert.That (result , Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5, }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}
