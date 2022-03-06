using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Using_Regex;

namespace User_Registration_Using_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        // test case for First Name
        [TestMethod]
        public void GivenWrongFirstName_ShouldReturnFalse()
        {
            //Arrange
            string firstName = "poonam";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidateFirstName(firstName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectFirstName_ShouldReturnTrue()
        {
            //Arrange
            string firstName = "Poonam";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidateFirstName(firstName);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // test case for last name
        [TestMethod]
        public void GivenWrongLastName_ShouldReturnFalse()
        {
            //Arrange
            string lastName = "budde";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidateLastName(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectLastName_ShouldReturnTrue()
        {
            //Arrange       
            string lastName = "Budde";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidateLastName(lastName);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Test case for Email
        [TestMethod]
        public void GivenWrongEmail_ShouldReturnFalse()
        {
            //Arrange
            string Email = "poonam@gmail.com";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidateEmail(Email);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectEmail_ShouldReturnTrue()
        {
            //Arrange
            string Email = "buddepoonam123@gmail.com";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidateEmail(Email);
            //Assert         
            Assert.AreEqual(expected, actual);
        }

        //Test case for Phone Number
        [TestMethod]
        public void GivenWrongPhoneNumber_ShouldReturnFalse()
        {
            //Arrange
            string phoneNumber = "952911129589";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidateMobileNoFormat(phoneNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectPhoneNumber_ShouldReturnTrue()
        {
            //Arrange
            string phoneNumber = "91 9529111295";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = true;
            //Act
            bool actual = userRegistration.ValidateMobileNoFormat(phoneNumber);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        // Test case for Password
        [TestMethod]
        public void GivenWrongPassword_ShouldReturnFalse()
        {
            //Arrange
            string Password = "pass123";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = false;
            //Act
            bool actual = userRegistration.ValidatePassword(Password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectPassword_ShouldReturnTrue()
        {
            //Arrange
            string Password = "Pass@123";
            UserRegistration userRegistration = new UserRegistration();
            bool expected = true;           
            //Act
            bool actual = userRegistration.ValidatePassword(Password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
