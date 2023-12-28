namespace Ex_17
{
    internal class Program
    {
        static int CMMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int CMMMC(int a, int b)
        {
            return (a * b) / CMMDC(a, b);

        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul numar: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            int n2=Convert.ToInt32(Console.ReadLine()); 

            int cmmdc= CMMDC(n1, n2);
            int cmmmc = CMMMC(n1, n2);
            Console.WriteLine($"Cel mai mare divizor comun al {n1}, {n2} este {cmmdc}");
            Console.WriteLine($"Cel mai mare multiplu comun al {n1}, {n2} este {cmmmc}");
        }
       
       
    }
}