namespace Ex_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti cele 5 numere:");

            int numar1 = Convert.ToInt32(Console.ReadLine());
            int numar2 = Convert.ToInt32(Console.ReadLine());
            int numar3 = Convert.ToInt32(Console.ReadLine());
            int numar4 = Convert.ToInt32(Console.ReadLine());
            int numar5 = Convert.ToInt32(Console.ReadLine());

            if (numar1 > numar2)
            {
                int temp = numar1;
                numar1 = numar2;
                numar2 = temp;
            }

            if (numar2 > numar3)
            {
                int temp = numar2;
                numar2 = numar3;
                numar3 = temp;
            }

            if (numar3 > numar4)
            {
                int temp = numar3;
                numar3 = numar4;
                numar4 = temp;
            }

            if (numar4 > numar5)
            {
                int temp = numar4;
                numar4 = numar5;
                numar5 = temp;
            }

            if (numar1 > numar2)
            {
                int temp = numar1;
                numar1 = numar2;
                numar2 = temp;
            }

            if (numar2 > numar3)
            {
                int temp = numar2;
                numar2 = numar3;
                numar3 = temp;
            }

            if (numar3 > numar4)
            {
                int temp = numar3;
                numar3 = numar4;
                numar4 = temp;
            }

            if (numar1 > numar2)
            {
                int temp = numar1;
                numar1 = numar2;
                numar2 = temp;
            }

            Console.WriteLine($"Numerele in ordine crescatoare sunt: {numar1}, {numar2}, {numar3}, {numar4}, {numar5}");
        }
    }
}