using NUnit.Framework;
using TestNinja.Mocking;
using Moq;

namespace TestNinja.UnitTests.Mock
{
    [TestFixture]
    public  class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_whenCalled_StoreTheOrder() {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            var order = new Order();
            service.PlaceOrder(order);
            storage.Verify(s => s.Store(order));
        }
    }
}
