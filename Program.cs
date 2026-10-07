namespace IMAT_GitTest
{
    internal class Program
    {
        static int Add(int x, int y) => x + y;

        static int Multiply(int x, int y) => x * y;

        static void Main(string[] args)
        {
            Console.WriteLine($"La suma es: {Multiply(2, 1)}");
        }
    }
}