using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace verificatriunghi

{
    internal class Program
    {
        static void Main(string[] args)
        {

            float a, b, c;
            
          
            Console.Write(" Introduceti a = ");
                 a = float.Parse(Console.ReadLine());

            Console.Write(" Introduceti b = ");
                 b = float.Parse(Console.ReadLine());

            Console.Write(" Introduceti c = ");
                 c = float.Parse(Console.ReadLine());

            if(EsteTriunghi(a, b, c))
            { 
                Console.WriteLine(" Este triunghi."); 
            }
            else {
                Console.WriteLine("Nu este triunghi.");
            }

            static bool EsteTriunghi(float a, float b, float c) 
            {
                return (a + b > c) && (b + c > a) && (a + c > b);
            }

        }
    }
}