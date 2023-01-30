using System;
namespace ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

            int raspuns = 0;
            int upperLimit = 1024;
            int lowerLimit = 1;
            int nr = 512;

            Console.WriteLine("Programul ghiceste numarul dorit intre 1 si 1024: ");
            while (raspuns < 3) 
            {
                Console.WriteLine("Numarul este mai mare decat " + nr + " \n 1 pentru da\n 2 pentru nu\n 3 pentru raspuns corect");
                raspuns = int.Parse(Console.ReadLine());
                if(raspuns == 1)
                {
                    lowerLimit = nr;
                    nr = lowerLimit + (lowerLimit / 2);
                }

                else if(raspuns == 2)
                {
                    upperLimit = nr;
                    nr = upperLimit / 2;
                    Console.WriteLine(nr);
                }

                else if(raspuns == 3)
                {
                    Console.WriteLine(nr);
                }
            }
            

        }
    }
}


