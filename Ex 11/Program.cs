namespace Ordine_inversa_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" n = ");
            int n= int.Parse(Console.ReadLine());
            Console.Write($"{n} Cifrele in ordine inversa sunt:");
            PrintDigitsInReverseOrder(n);
        }

        private static void PrintDigitsInReverseOrder(int n)
        {
            string nString = n.ToString();
            for(int i = nString.Length-1;i>=0;i--)
            {
                Console.Write(nString[i] + " ");
            }
          
        }
    }
}