namespace IMAT_GitTest
{
    internal class Program
    {
        static int Add(int x, int y) => x + y;

        static int Multiply(int x, int y) => x * y;

        static int Divide(int x, int y) => x/y

        static void Main(string[] args)
        {
            Console.WriteLine($"La division es: {Divide(2, 1)}");
        }
    }
}