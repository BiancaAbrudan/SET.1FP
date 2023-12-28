namespace descpompunere_in_factori_primi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Descpompunerea in factori primi ai lui {n} este: ");
            descpompunere_in_factori_primi(n);
                Console.ReadLine();
                
        }

        private static void descpompunere_in_factori_primi(int n)
        {
            while(n % 2 == 0)
            {
                Console.Write(" 2 ");
                n /= 2;
            }
            for(int i = 3; i <= Math.Sqrt(n); i+= 2)
            {
                while(n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;

                }
            }
            if(n>2)
            {
                Console.Write(n);
            }
        }
    }
}