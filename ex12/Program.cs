using System;
namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 

            int a, b, n;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = a; i <= b; i++)
            {
                if(i % n == 0)
                {
                    count++;
                }
            }
            
            Console.WriteLine(count);

        }
    }
}