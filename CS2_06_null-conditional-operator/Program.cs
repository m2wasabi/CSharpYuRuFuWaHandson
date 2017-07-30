using System;

namespace CS2_06_null_conditional_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a";
            string b = null;
            Console.WriteLine(a);   // a
            Console.WriteLine(b ?? "b is null");    // b is null

            Console.ReadKey();
        }
    }
}