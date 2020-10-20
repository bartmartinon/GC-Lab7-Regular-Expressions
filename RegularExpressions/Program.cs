using System;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Regular Expressions Lab.");
            MakeLineSpace(1);

            // Validate Name
            bool nameValid = false;
            do
            {
                Console.Write("Please input your name: ");
                string name = Console.ReadLine();
                nameValid = ValidateName(name);
                MakeLineSpace(1);
            } 
            while (!nameValid);

            // Validate Email
            bool emailValid = false;
            do
            {
                Console.Write("Please input your email address: ");
                string email = Console.ReadLine();
                emailValid = ValidateEmail(email);
                MakeLineSpace(1);
            }
            while (!emailValid);

            // Validate Phone Number
            bool phoneValid = false;
            do
            {
                Console.Write("Please input your phone number: ");
                string phoneNum = Console.ReadLine();
                phoneValid = ValidatePhone(phoneNum);
                MakeLineSpace(1);
            }
            while (!phoneValid);

            // Validate Date
            bool dateValid = false;
            do
            {
                Console.Write("Please input your birthdate: ");
                string date = Console.ReadLine();
                dateValid = ValidateDate(date);
                MakeLineSpace(1);
            }
            while (!dateValid);

            // Validate HTML
            bool htmlValid = false;
            do
            {
                Console.Write("Please input your favorite HTML tag: ");
                string tag = Console.ReadLine();
                htmlValid = ValidateHTML(tag);
                MakeLineSpace(1);
            }
            while (!htmlValid);       
        }

        // Takes a string and returns a boolean based on whether the input matches the format for Names
        public static bool ValidateName(string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z][a-z]{1,30}$"))
            {
                Console.WriteLine("Name confirmed!");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Please enter a name starting with a capital letter, containing no numbers and less than 30 characters.");
                return false;
            }
        }

        // Takes a string and returns a boolean based on whether the input matches the format for Emails
        public static bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[0-z]{5,30}@[0-z]{5,10}\.[0-z]{2,3}$"))
            {
                Console.WriteLine("Email confirmed!");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid email address. (5-30 alphanumerics)@(5-10 alphanumerics).(2-3 alphanumerics)");
                return false;
            }
        }

        // Takes a string and returns a boolean based on whether the input matches the format for Phone Numbers
        public static bool ValidatePhone(string phoneNum)
        {
            if (Regex.IsMatch(phoneNum, @"^\d{3}-\d{3}-\d{4}$"))
            {
                Console.WriteLine("Phone Number confirmed!");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Please enter a phone number in ddd-ddd-dddd format.");
                return false;
            }
        }

        // Takes a string and returns a boolean based on whether the input matches the format for Dates
        public static bool ValidateDate(string date)
        {
            if (Regex.IsMatch(date, @"^\d{2}\/\d{2}\/\d{4}$"))
            {
                if (!DateTime.TryParse(date, out DateTime result))
                {
                    Console.WriteLine("Error: Date entry format correct, invalid values! Please enter a real date!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Date confirmed!");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a date in dd/mm/yyyy format.");
                return false;
            }
        }

        // Takes a string and returns a boolean based on whether the input matches the format for HTML Tags
        public static bool ValidateHTML(string tag)
        {
            if (Regex.IsMatch(tag, @"^<([0-9a-z]+)>\s<\/\1+>$"))
            {
                Console.WriteLine("HTML Tag confirmed!");
                return true;
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid tag in <tag>(whitespace)</tag> format.");
                return false;
            }
        }

        // Adds empty lines in console for formatting
        public static void MakeLineSpace(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(" ");
            }
        }
    }
}
