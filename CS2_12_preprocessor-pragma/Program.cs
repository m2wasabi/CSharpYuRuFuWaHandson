using System;

namespace CS2_12_preprocessor_pragma
{
    class Program
    {
        /// <summary>#pragma プリプロセッサディレクティブ</summary>
        /// <remarks>特殊な命令をコンパイラに指示できる。
        ///  https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-pragma
        /// </remarks>

        static void Main(string[] args)
        {
#pragma warning disable CS0168
            int i;  // CS0168 の警告（変数未使用）がでない
#pragma warning restore CS0168
            int j;  // CS0168 の警告（変数未使用）がでる

            Console.ReadKey();
        }
    }
}