namespace P03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (!numbers.Any())
            {
                return;
            }

            Func<int[], int> FindMin = (int[] input) =>
            {
                int smallest = input[0];

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] < smallest)
                    {
                        smallest = input[i];
                    }
                }

                return smallest;
            };

            Console.WriteLine(FindMin(numbers));

        }
    }
}