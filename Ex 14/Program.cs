namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" n = ");
            int n = int.Parse(Console.ReadLine());
            if (IsPalindrome(n))
            {
                Console.Write($"{n} este numar palindrom.");
            }
            else
            {
                Console.Write($"{n} nu este numar palindrom.");
            }

                

        }

        private static bool IsPalindrome(int n)
        {
            string nString= n.ToString();
            int i = 0;
            int j = nString.Length - 1;
            while (i < j)
            {
                if (nString[i] != nString[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}