using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student("Phelippe", "Santos", "22345", "phelippe@mail.com");
            var subscription = new Subscription(null);
            student.AddSubscription(subscription);
        }
    }
}