using System;
namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, a1, b1;
            Console.Write("Prima valoare: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("A doua valoare: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + " " + b);
            a1 = b;
            b1 = a;
            Console.WriteLine(a1 + " " + b1);

        }
    }
}