using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Using_Regex
{
    class UserRegistration
    {
        public static string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAIL_PATTERN = "^[0-9a-zA-z]+([._+-][0-9a-zA-z]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})$";

        public bool validateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, NAME_PATTERN);
        }
        public bool validateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, NAME_PATTERN);
        }
        public bool validateEmail(String email)
        {
            return Regex.IsMatch(email, NAME_PATTERN);
        }
    }
}
