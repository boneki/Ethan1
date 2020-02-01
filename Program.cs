using System;

namespace UserInputEthanAnderson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Ethan Anderson.");

            Console.WriteLine("Type something and hit enter: ");

            string userString;

            userString = Console.ReadLine();

            Console.WriteLine("You typed: " + userString);
        }
    }
}
