using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        string? name;
        int number;

        Console.Write("What is your name? ");
        name = Console.ReadLine();

        // TODO: Till user enters a name keep on asking for the name.
        Console.Write($"Hello {name}. You want to play game for which table? ");
        number = Convert.ToInt32(Console.ReadLine());

        var multiple = 6; //TODO: Generate a random number between 1 to 12
        Console.Write($"What is {number} X {multiple}? ");
        var answer = Convert.ToInt32(Console.ReadLine());

        if (answer == (number * multiple))
        {
            Console.WriteLine("You are correct!");
        }
        else
        {
            Console.WriteLine("You are wrong :(");
        }
    }
}