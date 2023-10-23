using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            Assert.That(result, Is.TypeOf<NotFound>());
          
        }
        [Test]
        [TestCase(5)]
        public void GetCustomer_IdIsNotZero_ReturnOk(int a)
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(a);
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
