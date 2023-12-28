namespace Nr_an_bisecti_y1_y2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul an (y1): ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti ultimul an (y2): ");
            int y2 = int.Parse(Console.ReadLine());
            int NumarAniBisecti = CountLeapYears(y1, y2);
            Console.Write($"Între anii {y1} și {y2} sunt {NumarAniBisecti} ani bisecți.");
        }

        private static int CountLeapYears(int y1, int y2)
        {
            int count = 0;
            for (int y = y1; y <= y2; y++)
            {
                if ((y % 4 == 0) && (y % 100 != 0) || (y % 400 == 0))
                {
                    count++;
                }
            }
            return count;
        }
    }
}