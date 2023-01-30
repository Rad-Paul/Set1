using System;
namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect.
            int an;
            Console.WriteLine("Introduceti anul: ");
            an = int.Parse(Console.ReadLine());
            

            if ((an % 400) == 0)
            {
                Console.WriteLine(an + " este un an bisect.");
            }

            else if((an % 100) == 0)
            {
                Console.WriteLine(an + " nu este un an bisect.");

            }

            else if(an % 4 == 0)
            {
                Console.WriteLine(an + " este un an bisect.");
            }

            else
            {
                Console.WriteLine(an + " nu este un an bisect.");
            }
          

        }
    }
}