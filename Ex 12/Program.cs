namespace Nr_div_in_interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Capatul inferior al intervalului (a):");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Capatul superior al intervalului (b): ");
            int b=int.Parse(Console.ReadLine());
            int NumereDivizibile = CountDivisibleNumbers(n, a, b);
            Console.WriteLine($"In intervalul [{a}, {b}] sunt {NumereDivizibile} numere divizibile cu {n}");
        }

        private static int CountDivisibleNumbers(int n, int a, int b)
        {
            int count = 0;
            for(int i = a; i <= b; i++) 
            {
                if(i % n == 0)
                {
                    count++;
                }
            }
            return count;

        }
    }
}