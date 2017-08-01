using System;

namespace CS4_03_named_arguments
{
    /// <summary>名前付き引数</summary>
    /// <remarks>メソッドなどを呼び出す際、パラメーターを名前付きで記述できる。パラメーターを任意の順に指定できる。
    ///  https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
    ///  注意：実行環境がWindows コマンドプロンプトの場合文字化けします
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            AddAndWriteLine(10, 20, "計算結果 => {0}");             // 計算結果 => 30
                                                                // AddAndWriteLine(10, "計算結果 => {0}", 20);          // <- これはできない
            AddAndWriteLine(10, format: "計算結果 => {0}", b: 20);    // <- パラメーターを任意の順序で指定できる
            AddAndWriteLine(10, format: "計算結果 => {0}");         // <- 途中のパラメーターを省略できる
            AddAndWriteLine(10, 20, format: "計算結果 => {0}");      // 引数の意味が分かりやすくなる

            Console.ReadKey();
        }

        static int AddAndWriteLine(int a, int b = 2, string format = "結果は {0} です.")
        {
            var c = a + b;
            Console.WriteLine(string.Format(format, c));
            return c;
        }
    }
}