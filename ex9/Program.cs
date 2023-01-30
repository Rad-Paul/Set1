using System;
namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afisati toti divizorii numarului n. 
            int nr, impartit, div;
            Console.WriteLine("Introduceti numarul pentru a vedea divizorii: ");
            nr = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii lui " + nr + " sunt: ");
            div = 1;
            while (div < nr)
            {
                div++;
                impartit = nr % div;

                if (impartit == 0)
                {
                    Console.WriteLine(div);
                }

            }

               /* for (int div = 1; nr % div == 0; div++)
                {
                Console.WriteLine(div);
                }
               */
        }        
    }
}