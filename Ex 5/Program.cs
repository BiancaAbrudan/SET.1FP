namespace A_k_a_cifra_a_nr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nr = ");
            int nr = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            while(k > 1)
            {
                k--;
                nr = nr / 10;
            }

            Console.WriteLine($"{nr%10}");


        }
    }
}