using System;

namespace CS3_02_implicitly_typed_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new[] { 0, 20, 30 }; // ints は int 型の配列
            ints[0] = 10;     // <- これはできる
                              // ints[0] = "text"; <- これはできない
            foreach (var i in ints)
            {
                Console.WriteLine(i); // 10
                                      // 20
                                      // 30
            }

            Console.ReadKey();
        }
    }
}