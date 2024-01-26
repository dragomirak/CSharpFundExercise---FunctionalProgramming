namespace P08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>();
            for (int i = 1; i <= upperLimit; i++)
            {
                numbers.Add(i);
            }

            Func<int[], int, bool> predicate = (arr, i) =>
            {
                bool isDivisible = true;
                foreach (int n in arr)
                {
                    if (i % n != 0)
                    {
                        isDivisible = false;
                    }
                }

                return isDivisible;
            };

            var sortedNumbers = numbers
                .Where(n => predicate(divisors, n))
                .ToList();

            Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}