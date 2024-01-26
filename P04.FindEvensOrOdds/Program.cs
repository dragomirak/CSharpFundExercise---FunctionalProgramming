namespace P04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayBounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select (int.Parse)
                .ToArray(); 

            string command = Console.ReadLine();

            List<int> numbers = new List<int>();

            for (int i = arrayBounds[0]; i <= arrayBounds[1]; i++)
            {
                numbers.Add (i);
            }

            Predicate<int> predicate = i => true;

            if (command == "even")
            {
                predicate = i => i % 2 == 0;
            }
            else if (command == "odd")
            {
                predicate = i => i % 2 != 0;
            }

            List<int> filteredNumbers = numbers
                .Where(new Func<int, bool>(predicate))
                .ToList();

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}