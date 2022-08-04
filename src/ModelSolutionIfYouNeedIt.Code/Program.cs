using System;

namespace GettingStartedChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.WriteLine("Please enter your age");
            string ageAsString = Console.ReadLine();

            int age;

            age = int.Parse(ageAsString);
            Console.WriteLine($"You are {age} years old");

            //Looking Ahead with conditionals and the weirdness of "TryParse" and "out" parameters
            //if (int.TryParse(ageAsString, out age))
            //{
            //    Console.WriteLine($"You are {age} years old");
            //}
            //else
            //{
            //    Console.WriteLine("Age must be numeric");
            //}

            Console.WriteLine("Please enter your date of birth (DD/MM/YYYY)");
            string dobAsString = Console.ReadLine();
            DateTime dob;

            dob = DateTime.Parse(dobAsString);
            Console.WriteLine($"Your birthday is {dob:D}");
            long numDaysAlive = ((long)(new TimeSpan(DateTime.Now.Ticks - dob.Ticks)).TotalDays);
            Console.WriteLine($"You are {numDaysAlive} days old");

            //Looking Ahead with conditionals and the weirdness of "TryParse" and "out" parameters
            //if (DateTime.TryParse(dobAsString, out dob))
            //{
            //    Console.WriteLine($"Your birthday is {dob:D}");
            //    long numDaysAlive = ((long)(new TimeSpan(DateTime.Now.Ticks - dob.Ticks)).TotalDays);
            //    Console.WriteLine($"You are {numDaysAlive} days old");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Date of birth");
            //}
        }
    }
}
