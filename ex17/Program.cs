using System;
namespace ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
            // a = bq + r
            int a, b, q, r, start, multiplu;
            int i = 2;
            multiplu = 0;
            Console.Write("Introduceti numarul mai mare dintre cele doua: "); //10, 5
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti celalalt numar: ");
            b = int.Parse(Console.ReadLine());

                if (a == 2 * b)
                {
                    i = a;
                }

                else if (i != 2 * b)
                {
                    i = a * b;
                }

            Console.WriteLine(i);


            while (a % b > 0) //algoritmul lui euclid
            {

                if (a % 2 == 0)
                {
                    q = 2;
                    r = a % b;
                    a = b;
                    b = r;
                }

                else if (a % 3 == 0)
                {
                    q = 3;
                    r = a % b;
                    a = b;
                    b = r;
                }

                else
                {
                    q = 1;
                    r = a % b;
                    a = b;
                    b = r;
                }

            }
            Console.WriteLine(b);
        }
    }
}



//1200,500
//1200, 2 * 500 r 200
//500,200
//500, 2 * 200 r 100
//200,100
//