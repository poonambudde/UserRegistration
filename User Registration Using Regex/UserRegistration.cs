using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Using_Regex
{
    class UserRegistration
    {
        const string EMAIL_PATTERN = "^[a-z]{2,}[-.+]{1}[0-1]{3}[@]{1}[a-z]{2,5}[.]{1}[a-z]{1,}$";

        public bool ValidateEmail(string email)
        {
            var result = Regex.Match(email, EMAIL_PATTERN);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}