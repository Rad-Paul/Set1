using System;
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
            int a, b, c, x, rez;
            Console.WriteLine("Program pentru calcularea ecuatiei de tip ax+b = 0");
            Console.WriteLine("Exemplu: 2 * x + 6 = 14");
            Console.Write("Introduceti valoarea lui a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea lui b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea dupa = ");
            rez = int.Parse(Console.ReadLine());
            c = a * 1;
            x = (rez - b) / c;
            Console.WriteLine("Valorea lui x = " + x);



        }
    }
}