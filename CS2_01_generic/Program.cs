using System;
using System.Collections.Generic;

namespace CS2_01_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            // ints.Add("text"); <- これはできない
            ints.Add(1);
            int i = ints[0];
            Console.WriteLine(i);

            List<string> strings = new List<string>();
            // strings.Add(1); <- これはできない
            strings.Add("text");
            string s = strings[0];
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}