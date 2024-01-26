namespace P05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int> function = x => x;
            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "add")
                {
                    function = x => x + 1;
                }
                else if (input == "multiply")
                {
                    function = x => x * 2;
                }
                else if (input == "subtract")
                {
                    function = x => x - 1;
                }
                else if (input == "print")
                {
                    print(numbers);
                    continue;
                }

                numbers = numbers.Select(x => function(x)).ToArray();
            }
        }
    }
}