using System;

namespace CS2_10_namespace_alias_qualifer
{
    class Program
    {
        /// <summary>:: 演算子</summary>
        /// <remarks>名前空間エイリアス修飾子として global を指定すると、常にグローバル名前空間で検索が実行される。
        ///  https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/namespace-alias-qualifer
        /// </remarks>

        static void Main(string[] args)
        {
            System.Console.WriteLine("csharp");         // MyMethod
            global::System.Console.WriteLine("csharp"); // csharp

            global::System.Console.ReadKey();
        }
    }

    class System
    {
        internal class Console
        {
            internal static void WriteLine(string text)
            {
                global::System.Console.WriteLine("MyMethod");
            }
        }
    }
}