using System;
namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, temp;
            int num1, num2, num3, num4, num5;
            temp = 0;
            num1 = num2 = num3 = num4 = num5 = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            if (a > b) { temp = a; }
            if (b > a) { temp = b; }
            if (c > temp) { temp = c;}
            if (d > temp) { temp = d;}
            if (e > temp) { temp = e;}



            for(int i = 0; i <= temp; i++)
            {
                if ((i == a) && (a < num4) || (i == b) && (b < num4) || (i == c) && (c < num4) || (i == d) && (d < num4) || (i == e) && (e < num4))
                {
                    num5 = i;
                }

                else if ((i == a) && (a < num3) || (i == b) && (b < num3) || (i == c) && (c < num3) || (i == d) && (d < num3) || (i == e) && (e < num3))
                {
                    num4 = i;
                }

                else if ((i == a) && (a < num2) || (i == b) && (b < num2) || (i == c) && (c < num2) || (i == d) && (d < num2) || (i == e) && (e < num2))
                {
                    num3 = i;
                }

                else if ((i == a) && (a < num1) || (i == b) && (b < num1) || (i == c) && (c < num1) || (i == d) && (d < num1) || (i == e) && (e < num1))
                {
                    num2 = i;
                }

                else if ((i == a) || (i == b) || (i == c) || (i == d) || (i == e)) 
                {
                    num1 = i;
                }
            }

            Console.WriteLine(num1 + " " + num2 + " " + num3 + " " + num4 + " " + num5);
            
        }
    }
}