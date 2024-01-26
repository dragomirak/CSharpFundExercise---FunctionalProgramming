namespace P06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> predicate = i => i % divisor != 0;

            List<int> sortedNumbers = numbers
                .Where(n => predicate(n))
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}