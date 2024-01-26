namespace P01.ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string> print = s => Console.WriteLine(s);

            Array.ForEach(names, print);
        }
    }
}