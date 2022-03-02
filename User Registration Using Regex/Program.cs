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
            Console.WriteLine(userRegistration.validateFirstName(firstName));
            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine(userRegistration.validateLastName(lastName));
            Console.WriteLine("Enter the email = ");
            string email = Console.ReadLine();
            Console.WriteLine(userRegistration.validateEmail(email));
            Console.WriteLine("Enter the mobile no format = ");
            string mobileNoFormat = Console.ReadLine();
            Console.WriteLine(userRegistration.validateMobileNoFormat(mobileNoFormat));
        }
    }
}