using System;
namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, count;

            //Determinati cati ani bisecti sunt intre anii y1 si y2.
            /*dacă (year nu este divizibil cu 4) atunci (an obișnuit)
            altfel dacă (year nu este divizibil cu 100) atunci (an bisect)
            altfel dacă (year nu este divizibil cu 400) atunci (an obișnuit)
            altfel (an bisect)                        
            */

            Console.WriteLine("Anul de inceput: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anul final: ");
            y2 = int.Parse(Console.ReadLine());

            count = 0;

            for (int i = y1; i <= y2; i++)
            {

                if ((i % 400 == 0) && (i != 0))
                {
                    count++;
                    Console.WriteLine("An bisect: " + i);
                }

                else if (i % 100 == 0)
                {

                }

                else if ((i % 4 == 0) && (i != 0))
                {
                    count++;
                    Console.WriteLine("An bisect: " + i);
                }

            }

            Console.WriteLine("Nr de ani bisecti: " + count);
        }
    }
}

   
