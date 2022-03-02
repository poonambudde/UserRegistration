using System;

namespace User_Registration_Using_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Programs using Regex");

            UserRegistration userRegistration = new UserRegistration();

            Console.WriteLine("Note: name starts with Cap and has minimun 3 characters");
            Console.WriteLine("Enter the first name = ");
            string firstName = Console.ReadLine();
            Console.WriteLine(userRegistration.validateFirstName(firstName));
            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine(userRegistration.validateLastName(lastName));            
            Console.WriteLine("Enter the first name = ");
            Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");
            string firstName = Console.ReadLine();
            UserRegistration userRegistration = new UserRegistration();
            Console.WriteLine(userRegistration.validateFirstName(firstName));
        }
    }
}