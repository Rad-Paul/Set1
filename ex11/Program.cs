using System;
namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n. 

            string nr;
            Console.Write("Introduceti un numar format din mai multe cifre:");
            nr = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Reverse(nr));

        }

        static string Reverse(string nr)
        {
            char[] array = nr.ToCharArray();
            Array.Reverse(array);

            return new string(array);
        }
    }
}