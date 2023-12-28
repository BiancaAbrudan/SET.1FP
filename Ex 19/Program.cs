namespace Ex_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            if (AreDoarDouaCifreRepetate(numar))
            {
                Console.WriteLine($"{numar} este format doar cu doua cifre care se pot repeta.");
            }
            else
            {
                Console.WriteLine($"{numar} nu este format doar cu doua cifre care se pot repeta.");
            }
        }

        static bool AreDoarDouaCifreRepetate(int numar)
        {
            string numarString = numar.ToString();

            return numarString.Length == 2 && numarString[0] == numarString[1];
        }
    }
}