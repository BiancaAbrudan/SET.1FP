using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.VisualBasic;

namespace AnBisect
{
    class program
    {
        static void Main(string[] args)
        {
            float y; 
            
            Console.Write("introduceti y = ");
            y = float.Parse(Console.ReadLine());

            for (y = 1; y <= 2023; y++)
            {
                  if(AnBisect(y))
                    Console.WriteLine($"{y} este an bisect.");
                  else
                    Console.WriteLine($"{y} nu este an bisect.");
            }
            
        }

        private static bool AnBisect(float y)
        {
            return ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0);
        }
    }
}