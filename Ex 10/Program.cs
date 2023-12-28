using System;

namespace test_primalitate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" n = ");
            int n = int.Parse(Console.ReadLine());
            if (EstePrim(n))
            {
                Console.Write($"{n} Este numar prim.");

            }
            else
            {
                Console.Write($"{n} Nu este numar prim.");
            }
        }
            static bool EstePrim(int n)
            {
                if (n <= 1)
                {
                    return false;
                }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
                    return true;
                
            }
        
    }
}