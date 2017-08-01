using System;

namespace CS3_04_extension_methods
{
    /// <summary>拡張メソッド</summary>
    /// <remarks>既存の型に外からメソッドを追加できる。
    ///  既存の型に外からメソッドを追加できる。
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            string s = "text";
            Console.WriteLine(s.HasValue());    // True
            s = null;
            Console.WriteLine(s.HasValue());    // False

            Console.ReadKey();
        }
    }

    static class StringExtensions
    {
        internal static bool HasValue(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}