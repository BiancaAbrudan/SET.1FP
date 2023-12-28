namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            int aux=0;
            
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"a={a} b={b}");
        }
    }
}