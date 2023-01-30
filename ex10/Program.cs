using System;
namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //determinati daca un nr. n este prim

            int nr;
            nr = int.Parse(Console.ReadLine());

            if ((nr == 2) || (nr == 3) || (nr == 5) || (nr == 7))
            {
                Console.WriteLine("Numarul este prim.");
            }

            else if ((nr % 2 == 0) || (nr % 3 == 0))
            {
                Console.WriteLine("Numarul nu este prim.");
            }

            else
            {
                Console.WriteLine("Numarul este prim.");
            }

            /*if ((nr/2 > 1) || (nr/3 > 1))
            {
                Console.WriteLine("Numarul nu este prim.");
            }

            else if((nr/5 == 1) || (nr/7 == 1))
            {
                Console.WriteLine("Numarul este prim.");
            }

            else
            {
                Console.WriteLine("Numarul este prim.");
            }
            */

        }      
        
    }
}