using System;
using System.Collections.Generic;

namespace CS2_03_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in Values())
            {
                Console.WriteLine(number.ToString());    // 1
                                                         // 2
                                                         // 3
            }

            Console.ReadKey();
        }

        public static IEnumerable<int> Values()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}