
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(15)]
        public void GetOutput_ChekingNumberby3_ReturnString(int a)
        {
            var result = FizzBuzz.GetOutput(a);
            Assert.That(result, Does.Contain("FizzBuzz"));
        }
        [Test]
        [TestCase(3)]
        public void GetOutput_ChekingNumberby30_ReturnString(int a)
        {
            var result = FizzBuzz.GetOutput(a);
            Assert.That(result, Does.Contain("Fizz"));
        }
        [Test]
        [TestCase(5)]
        public void GetOutput_ChekingNumberby50_ReturnString(int a)
        {
            var result = FizzBuzz.GetOutput(a);
            Assert.That(result, Does.Contain("Buzz"));
        }

        [Test]
        [TestCase(1)]
        public void GetOutput_ChekingNumberbyNotVisuable_ReturnString(int a)
        {
            var result = FizzBuzz.GetOutput(a);
            Assert.That(result, Does.Contain("1"));
        }
    }
}
