using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Name();
            Email();
            ValidateUserInput();
            Date();
        }

        static void ValidateUserInput()
        {
            Regex pattern = new Regex(@"(\d{3}-)(\d{3}-)(\d{4})");
            Console.WriteLine("phone number");
            var phoneNumber = Console.ReadLine();

            if (pattern.IsMatch(phoneNumber))
            {
                Console.WriteLine("is a number");
            }
            else
            {
                Console.WriteLine("not a number");
            }
        }

        static void Name()
        {
            Regex patternN = new Regex(@"^[A-Z][a-z]{1,30}");
            Console.WriteLine("name");
            var name = Console.ReadLine();

            if (patternN.IsMatch(name))
            {
                Console.WriteLine("is a name");
            }
            else
            {
                Console.WriteLine("not a name");
            }

        }

        static void Email()
        {
            Regex patternE = new Regex(@"(\w+)@(\w+)(\.(\w{2,3}))");
            Console.WriteLine("Email");
            var email = Console.ReadLine();

            if (patternE.IsMatch(email))
            {
                Console.WriteLine("is a email");
            }
            else
            {
                Console.WriteLine("not a email");
            }

        }

        static void Date()
        {
            Regex patternD = new Regex(@"(\d{2})\/(\d{2})\/(\d{4})");
            Console.WriteLine("date");
            var date = Console.ReadLine();

            if (patternD.IsMatch(date))
            {
                Console.WriteLine("is a date");
            }
            else
            {
                Console.WriteLine("not a date");
            }

        }
    }
}
