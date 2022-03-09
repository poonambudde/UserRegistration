using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registration_Using_Regex;

namespace User_Registration_Using_MSTest
{
    [TestClass]
    public class UserRegistrationTestCase
    {
        // UC10 - Test Case for Givens the first name of the message when happy return entry sucessful for first name.      
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessful_ForFirstName(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForFirstName();
            Assert.AreEqual(expected, "Entry is successful");
        }
       
        // UC10 - Test case for given message when sad then return entry unsuccessfull for first name.
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessful_ForFirstName(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForFirstName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        
        // UC10 - Test case for given message when happy entry successfull for last name.
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessful_ForLastName(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck. CheckForLastName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        
        // UC10 - Test case for given message when sad then return entry unsuccessfull for last name.
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessful_ForLastName(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForLastName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        
        // UC10 - Test case for given message when happy then entry successfull for email.
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessful_ForEmail(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForEmail();
            Assert.AreEqual(expected, "Entry is successful");
        }
       
        // UC1O - Test case for given message when sad then return entry unsuccessfull for email.
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessful_ForEmail(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForEmail();
            Assert.AreEqual(expected, "Entry is not successful");
        }

        // UC10 - Test case for given message when happy then entry successfull for mobile.
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessful_ForMobile(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForPhoneNumber();
            Assert.AreEqual(expected, "Entry is successful");
        }
        
        // UC10 - Test case for given message when sad then return entry unsuccessfull for mobile.
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessful_ForMobile(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForPhoneNumber();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        
        // UC10 - Test case for given message when happy then entry successfull for password.
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessful_ForPassword(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForPassword();
            Assert.AreEqual(expected, "Entry is successful");
        }
        
        // UC10 - Test case for given message when sad then return entry unsuccessfull for password.
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessful_ForPassword(string message)
        {
            RegistrationCheck registrationCheck = new RegistrationCheck(message);
            string expected = registrationCheck.CheckForPassword();
            Assert.AreEqual(expected, "Entry is not successful");
        }


        // UC11 - Givens the parameterized test when validate multiple entries returns the entry is sucessful.
        [TestMethod]
        public void GivenParameterizedTest_ToCheckValidMultipleEntries_ReturnEntryIsSucessful()
        {
            RegistrationCheck registrationCheck = new RegistrationCheck();
            var result = registrationCheck.CheckMultipleEntriesOfEmail("abc@yahoo.com", "abc-100@yahoo.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc@1.com");
            Assert.AreEqual(result, "Entry is successful");
        }


        // UC12 - Givens the first name when invalid then should throw invalid first name exception.
        [TestMethod]
        [DataRow("poonam")]
        public void GivenFirstName_WhenInvalid_ThenShouldThrow_InvalidFirstNameException(string firstName)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckFirstName(firstName);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid First Name Format", ex.Message);
            }
        }

        // UC12 - Givens the last name when invalid then should throw invalid last name exception.
        [TestMethod]
        [DataRow("budde")]
        public void GivenLastName_WhenInvalid_ThenShouldThrow_InvalidLastNameException(string lastName)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckLastName(lastName);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Last Name Format", exception.Message);
            }
        }

        // UC12 - Givens the email when invalid then should throw invalid email exception.
        [TestMethod]
        [DataRow("abc@.com.my")]
        public void GivenEmail_WhenInvalid_ThenShouldThrow_InvalidEmailException(string email)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckEmail(email);
            }
            catch (UserRegistrationException exception)
            {
                Assert.AreEqual("Invalid Email Format", exception.Message);
            }
        }

        // UC12 - Givens the mobile format when invalid then should throw invalid mobile format exception.
        [TestMethod]
        [DataRow("649713160")]
        public void GivenMobileFormat_WhenInvalid_ThenShouldThrow_InvalidMobileFormatException(string phoneNumber)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckMobile(phoneNumber);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid Mobile Number Format", ex.Message);
            }
        }

        // UC12 - Givens the password format when invalid then should throw invalid password format exception.
        [TestMethod]
        [DataRow("pass@123")]
        public void GivenPasswordFormat_WhenInvalid_ThenShouldThrow_InvalidPasswordFormatException(string Password)
        {
            try
            {
                RegistrationCheck registrationCheck = new RegistrationCheck();
                registrationCheck.CheckPassword(Password);
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid Password Format", ex.Message);
            }
        }

        // UC13 - Givens the first name when valid then should return true using lambda.
        [TestMethod]
        [DataRow("Poonam")]
        public void GivenFirstName_Whenvalid_ThenShouldReturn_TrueUsingLambda(string firstName)
        {
            UserRegistration userRegistration = new UserRegistration();
            bool validateFirstName = userRegistration.IsValidFirstName(firstName);
            Assert.AreEqual(true, validateFirstName);
        }
        
        // UC13 - Givens the last name when valid then should return true using lambda.
        [TestMethod]
        [DataRow("Budde")]
        public void GivenLastName_WhenValid_ThenShouldReturn_TrueUsingLambda(string lastName)
        {
            UserRegistration userRegistration = new UserRegistration();
            bool validateLastName = userRegistration.IsValidLastName(lastName);
            Assert.AreEqual(true, validateLastName);
        }
      
        // UC13 - Givens the email when valid then should return true using lambda.
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        public void GivenEmail_WhenValid_ThenShouldReturn_TrueUsingLambda(string email)
        {
            UserRegistration userRegistration = new UserRegistration();
            bool validateEmail = userRegistration.IsValidEmail(email);
            Assert.AreEqual(true, validateEmail);
        }
        
        // UC13 - Givens the mobile format when valid then should return true using lambda.
        [TestMethod]
        [DataRow("91 8345678906")]
        public void GivenMobileFormat_WhenValid_ThenShouldReturn_TrueUsingLambda(string phoneNumber)
        {
            UserRegistration userRegistration = new UserRegistration();
            bool validateMobileFormat = userRegistration.IsValidMobileNumber(phoneNumber);
            Assert.AreEqual(true, validateMobileFormat);
        }
        
        // UC13 - Givens the password format when valid then should return true using lambda.
        [TestMethod]
        [DataRow("Pass@123")]
        public void GivenPasswordFormat_WhenValid_ThenShouldReturn_TrueUsingLambda(string Password)
        {
            UserRegistration userRegistration = new UserRegistration();
            bool validatePassword = userRegistration.IsValidPassword(Password);
            Assert.AreEqual(true, validatePassword);
        }
    }
}
