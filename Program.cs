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

        Random random = new();

        for (int i = 0; i < 10; i++)
        {
            var factor = random.Next(2, 13);
            Console.WriteLine($"What is {number} X {factor}? ");
            var answer = Convert.ToInt32(Console.ReadLine());

            if (answer == (number * factor))
            {
                Console.WriteLine("Right!");
            }
            else
            {
                Console.WriteLine("Wrong :(");
            }
        }
    }
}