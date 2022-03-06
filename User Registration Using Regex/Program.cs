using System;

namespace User_Registration_Using_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Programs using Regex");

            UserRegistration userRegistration = new UserRegistration();

            Console.WriteLine("Enter the first name = ");
            string firstName = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateFirstName(firstName));

            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateLastName(lastName));

            Console.WriteLine("Enter the email = ");
            string email = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateEmail(email));

            Console.WriteLine("Enter the phoneNumber = ");
            string mobileNoFormat = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateMobileNoFormat(mobileNoFormat));

            Console.WriteLine("Enter the password = ");
            string password = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidatePassword(password));
        }
    }
}
