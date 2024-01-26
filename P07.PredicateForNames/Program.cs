namespace P07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namesLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> predicate = (s, i) => s.Length <= i;

            string[] filteredNames = names
                .Where(n => predicate(n, namesLength))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, filteredNames));

        }
    }
}