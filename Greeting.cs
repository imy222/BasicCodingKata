using System;
namespace BasicCodingKata
{
    public class Greeting
    {
        public static void HelloName()
        {
            Console.WriteLine("Hello! What is your name?");
            String userInput = Console.ReadLine();
            Console.WriteLine($"Hello {userInput}! Have a good day!");
        }
    }
}