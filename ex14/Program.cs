using System;
namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
            string x;
            Console.WriteLine("Introduceti numarul pentru a afla daca este palindrom: ");
            x = (Console.ReadLine());
            string newNr = Palindrom(x);

            if(newNr == x)
            {
                Console.WriteLine("Numarul este palindrom.");
            }

            else
            {
                Console.WriteLine("Nu este palindrom.");
            }
        }

        public static string Palindrom(string x) 
        {
            char[] nr = x.ToCharArray();
            Array.Reverse(nr);
            return new string(nr);

        }
    }
}