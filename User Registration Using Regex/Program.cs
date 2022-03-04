using System;

namespace User_Registration_Using_Regex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration Programs using Regex");

            UserRegistration userRegistration = new UserRegistration();

            Console.WriteLine("abc@yahoo.com is :- " + userRegistration.ValidateEmail("abc@yahoo.com"));
            Console.WriteLine("abc-100@yahoo.com is :- " + userRegistration.ValidateEmail("abc-100@yahoo.com"));
            Console.WriteLine("abc.100@yahoo.com is :- " + userRegistration.ValidateEmail("abc.100@yahoo.com"));
            Console.WriteLine("abc111@abc.com is :- " + userRegistration.ValidateEmail("abc111@abc.com"));
            Console.WriteLine("abc-100@abc.net is :- " + userRegistration.ValidateEmail("abc-100@abc.net"));
            Console.WriteLine("abc.100@abc.com.au is :- " + userRegistration.ValidateEmail("abc.100@abc.com.au"));
            Console.WriteLine("abc111@abc.com is :- " + userRegistration.ValidateEmail("abc111@abc.com"));
            Console.WriteLine("abc@1.com is :- " + userRegistration.ValidateEmail("abc@1.com"));
            Console.WriteLine("abc@gmail.com.com is :- " + userRegistration.ValidateEmail("abc@gmail.com.com"));
            Console.WriteLine("abc+100@gmail.com is :- " + userRegistration.ValidateEmail("abc+100@gmail.com"));
        }
    }
}
