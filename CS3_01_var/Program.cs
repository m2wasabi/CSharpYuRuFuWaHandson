using System;

namespace CS3_01_var
{
    /// <summary>型推論 (var)</summary>
    /// <remarks>変数の宣言時に暗黙の型指定を行える。コンパイラが型を推論してくれる。
    ///  https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/var
    /// </remarks>

    class Program
    {
        static void Main(string[] args)
        {
            var i = 10; // i は int 型の変数
            i = 20;     // <- これはできる
                        // i = "text"; // これはできない

            Console.WriteLine(i.GetType().Name);

            Console.ReadKey();
        }
    }
}