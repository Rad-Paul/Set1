using System;
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
            // exemplu: x^2 - 5x +6 = 0

            int a, b, c, delta, x1, x2;
            a = 1;
            b = -5;
            c = -6;

            Console.WriteLine("x^2 - 5x +6 = 0");
            delta = b * b - 4 * a * c;
            Console.WriteLine("Delta = " + delta);
            x1 = (-b + 49 / 7) / 2;
            x2 = (-b - 49 / 7) / 2;
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);

        }
    }
}