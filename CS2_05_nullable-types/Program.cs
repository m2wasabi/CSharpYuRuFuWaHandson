using System;

namespace CS2_05_nullable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = 1;
            a = null;
            Console.WriteLine(a == null);   // True
            a = 1;
            Console.WriteLine(a.Value);     // 1

            Console.ReadKey();
        }
    }
}