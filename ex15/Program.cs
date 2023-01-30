using System;
namespace ex15
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
            int a, b, c;
            int[] nr = new int[4];
            Console.WriteLine("Introduceti 3 valori: ");

            nr[1] = int.Parse(Console.ReadLine());
            nr[2] = int.Parse(Console.ReadLine());
            nr[3] = int.Parse(Console.ReadLine());

            Array.Sort(nr);
            for( int i = 1; i < nr.Length; i++ )
            {
                Console.WriteLine(nr[i]);
            }
        }
    }
}