namespace Normal_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int m=int.Parse(Console.ReadLine());

            Console.WriteLine(n+m);
        }
    }
}