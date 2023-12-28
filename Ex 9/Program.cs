namespace Divizorii_lui_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }
    }
}