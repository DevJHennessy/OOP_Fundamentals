using ACM.BL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.ACM.BLTest
{
    [TestFixture]
    public class CustomerRepositoryTest
    {
        [Test]
        public void RetrieveExisting()
        {
            //Assign
            var sut = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.io",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //Act
            var result = sut.Retrieve(1);

            //Assert
            Assert.That(result.CustomerId, Is.EqualTo(expected.CustomerId));
            Assert.That(result.EmailAddress, Is.EqualTo(expected.EmailAddress));
            Assert.That(result.FirstName, Is.EqualTo(expected.FirstName));
            Assert.That(result.LastName, Is.EqualTo(expected.LastName));

        }
    }
}
