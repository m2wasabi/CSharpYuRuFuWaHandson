using System;

namespace CS3_03_auto_implemented_properties
{
    /// <summary>自動実装プロパティ</summary>
    /// <remarks>値の取得または設定時にロジックが必要ない場合、プロパティを簡潔に宣言できる。
    ///  https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
    ///  注意：実行かbン強がWindows コマンドプロンプトの場合文字化けします
    /// </remarks>

    class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Phone();
            p.Name = "窓スマ";
            p.Size = 5.0;
            Console.WriteLine(string.Format("{0}, {1} インチ", p.Name, p.Size));    // 窓スマ, 5 インチ

            Console.ReadKey();
        }
    }

    class Phone
    {
        internal string Name { get; set; }
        internal double Size { get; set; }
    }
}