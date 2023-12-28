using System.ComponentModel.Design;

namespace ordine_cresc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write(" c = ");
            int c = int.Parse(Console.ReadLine());
            if ((a <= b) && (a <= c))
            {
                { Console.Write(a + " "); }
                if (b <= c)
                {
                    Console.Write(b + " ");
                    Console.Write(c);
                }
                else
                {
                    Console.Write(c + " ");
                    Console.Write(b);
                }
            }
            else
            {
                if ((b <= a) && (b <= c))
                {
                    Console.Write(b + " ");
                    if (a <= c)
                        Console.Write(a + " ");
                    Console.Write(c);
                }
                else
                {
                    Console.Write(c + " ");
                    Console.Write(a);
                }
                if (a <= b) 
                { 
                    Console.Write(b + " ");
                    Console.Write(a);
                }
                else
                {
                    Console.Write( a + " ");
                    Console.Write(b);
                }


                Console.ReadLine();
            }
        }
    }
}