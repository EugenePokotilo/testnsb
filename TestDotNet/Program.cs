using System;
using logic;

namespace TestDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name!");
            var name = Console.ReadLine();
            var message = HelloWorld.GetMessage(name);
            Console.WriteLine(message);
        }
    }
}
