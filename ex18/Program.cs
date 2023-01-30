using System;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr;
            Console.WriteLine("Introduceti numarul: ");
            nr = int.Parse(Console.ReadLine());
            int count2, count3, count5, count7;
            count2 = count3 = count5 = count7 = 0;

            for(int i = 1; i <= nr; i++)
            {
                if(nr % 2 == 0)
                {
                    count2++;
                    nr = nr / 2;
                }

                else if(nr % 3 == 0)
                {
                    count3++;
                    nr = nr / 3;
                }

                else if(nr % 5 == 0)
                {
                    count5++;
                    nr = nr / 5;
                }

                else if (nr % 7 == 0)
                {
                    count7++;
                    nr = nr / 7;
                }

            }

            Console.WriteLine(count2 + " " + count3 + " " + count5 + " " + count7);
        }
    }
}
