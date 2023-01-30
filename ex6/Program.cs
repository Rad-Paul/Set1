using System;
namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //cele trei numere trebuie sa fie pozitive, oricare doua dintre ele sa fie mai mare decat a treia latura
            int lat1, lat2, lat3;
            Console.WriteLine("Introduceti lungimea laturilor: ");
            lat1 = int.Parse(Console.ReadLine());
            lat2 = int.Parse(Console.ReadLine());
            lat3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Triunghi(lat1,lat2,lat3));
        }

        public static string Triunghi(int a, int b, int c  )

        {
            if ((a + b > c) || (a + c > b) || (b + c > a))
            {
                string da = "Este triunghi.";
                return da;
            }

            else
            {
                string nu = "Nu poate fi triunghi.";
                return nu;
            }
        }
    }
}