namespace Swap_restrictionat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;


            Console.WriteLine($"a={a} b={b}");

        }
    }
}