namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string? sNumber = Console.ReadLine();
            int Number = -int.Parse(sNumber);
            Console.WriteLine(Number);
            Console.ReadKey();
        }
    }
}