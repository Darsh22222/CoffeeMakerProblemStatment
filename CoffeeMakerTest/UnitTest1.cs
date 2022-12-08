using NUnit.Framework;
using Moq;
using CoffeeMaker;

namespace CoffeeMakerTest
{
    
    public class Test
    {

        [Test]
        public void OrderACoffee_Should_Return_Recive_Message()
        {
            StarBuckStore store = new StarBuckStore(new FakeStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is recieved", result);

        }
        [Test]
        public void OrderACoffee1_Should_Return_Recieve_Message()
        {
            StarBuckStore store = new StarBuckStore(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is recieved", result);
        }
        [Test]
        public void OrderACoffee_Should_Return_Recieve_MessageUsingMock()
        {
            var service = new Mock<IMakeACoffee>();
            service.Setup(x => x.CheckIngridentAvailablity()).Returns(true);
            service.Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your Order is recieved");
            var store = new StarBuckStore(service.Object);
            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is recieved", result);
        }
    }
}