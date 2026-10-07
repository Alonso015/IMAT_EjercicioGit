namespace IMAT_GitTest
{
    internal class Program
    {
        static int Add(int x, int y) => x + y;

        static int Multiply(int x, int y) => x * y;

        static int Subtract(int x, int y) => x - y;

        static void Main(string[] args)
        {
            Console.WriteLine($"La resta es: {Subtract(2, 1)}");
        }
    }
}