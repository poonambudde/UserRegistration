using System;
using System.Collections.Generic;
using System.Text;

namespace User_Registration_Using_Regex
{
    public class UserRegistrationException : Exception
    {
        // enum ExceptionType for constants
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        private readonly ExceptionType type;

        // Parameterized Constructor Initializes a new instance of the class.
        public UserRegistrationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
