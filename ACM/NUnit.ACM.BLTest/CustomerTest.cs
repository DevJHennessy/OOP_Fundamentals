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
    public class CustomerTest
    {
        [Test]
        public void FullNameTestValid()
        {
            //Arrange
            Customer sut = new Customer();
            sut.FirstName = "Bilbo";
            sut.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //Act
            string result = sut.FullName;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer sut = new Customer();
            sut.FirstName = "Bilbo";
            string expected = "Bilbo";

            //Act
            string result = sut.FullName;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer sut = new Customer();
            sut.LastName = "Baggins";
            string expected = "Baggins";

            //Act
            string result = sut.FullName;

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //Act


            //Assert
            Assert.That(Customer.InstanceCount, Is.EqualTo(3));
        }

        [Test]
        public void ValidateValid()
        {
            //Arrange
            var sut = new Customer();
            sut.LastName = "Baggins";
            sut.EmailAddress = "fbaggins@hobbiton.io";

            var expected = true;
            //Act
            var result = sut.Validate();

            //Assert
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void ValidateMissingLastName()
        {
            //Arrange
            var sut = new Customer();
            sut.EmailAddress = "fbaggins@hobbiton.io";

            var expected = false;
            //Act
            var result = sut.Validate();

            //Assert
            Assert.That(result, Is.EqualTo(expected));

        }

    }

}
