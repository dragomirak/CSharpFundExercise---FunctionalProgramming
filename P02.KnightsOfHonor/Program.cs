namespace P02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string> print = s => Console.WriteLine($"Sir {s}");

            Array.ForEach(names, print);
        }
    }
}