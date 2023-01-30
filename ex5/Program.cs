using System;

class Kodify_Example
{
    static void Main(string[] args)
    {
        //prima incercare
        /* string example = "123456789";
         Console.WriteLine(example);

         int start, finish;
         //Console.WriteLine("Introduceti ")
         start = int.Parse(Console.ReadLine());
         finish = int.Parse(Console.ReadLine());

         string exampleRight = example.Substring(start,finish);


         // Output
         Console.WriteLine(example);
         Console.Write(exampleRight);
        */

        int k;
        Console.WriteLine("123456789");
        string example = ReverseString("123456789");
        Console.WriteLine("Introduceti digitul caracterului: ");
        k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(example);
        Console.WriteLine(example[k]);
        
  
    }

    static string ReverseString(string s)
    {
        // Convert to char array, then call Array.Reverse.
        // ... Finally use string constructor on array.
        char[] array = s.ToCharArray();
        Array.Reverse(array);

        return new string(array);   

    }
}