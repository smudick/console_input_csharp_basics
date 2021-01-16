using System;

namespace Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Input
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            var randomAnimal = new Random().Next(animals.Length);
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            var favColor = Console.ReadLine();
            Console.WriteLine($"Would you like a {favColor} {animals[randomAnimal]}?");

        }
    }
}
