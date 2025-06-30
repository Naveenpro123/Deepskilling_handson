using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCommLib.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> _mockMailSender = null!;
        private CustomerComm _customerComm = null!;

        [OneTimeSetUp]
        public void Init()
        {
            _mockMailSender = new Mock<IMailSender>();
            _mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            _customerComm = new CustomerComm(_mockMailSender.Object);
        }

        [Test]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            var result = _customerComm.SendMailToCustomer();
            Assert.IsTrue(result);
        }
    }
}
