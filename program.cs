using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "MyAwesomeApp";

        Console.WriteLine("Hello World! Let's make your own story. Just fill in the blanks!\n");

        Console.Write("My name is: ");
        string name = Console.ReadLine();

        Console.Write("I love: ");
        string love = Console.ReadLine();

        Console.Write("And I want to learn more about: ");
        string learn = Console.ReadLine();

        Console.Write("But a giant obstacle in my way would be: ");
        string obstacle = Console.ReadLine();

        Console.Write("But I will overcome it by: ");
        string overcome = Console.ReadLine();

        Console.Write("At the end of our story, we all say: ");
        string ending = Console.ReadLine();

        // Print the full story
        Console.WriteLine("\n--- Your Story ---");
        Console.WriteLine($"My name is {name}.");
        Console.WriteLine($"I love {love}.");
        Console.WriteLine($"I want to learn more about {learn}.");
        Console.WriteLine($"A giant obstacle in my way is {obstacle}.");
        Console.WriteLine($"But I will overcome it by {overcome}.");
        Console.WriteLine($"At the end of our story, we all say {ending}.");

        Console.WriteLine("\nThank you for sharing your story! Goodbye World!");
    }
}