using System;

namespace CS2_02_anonymous_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //　[推奨されません(※)] delegate をインライン コードで生成できる。 (※)C# 3.0 で追加されたラムダ式を使用してください。
            System.Threading.Timer t = new System.Threading.Timer(
                delegate (object state) { Console.WriteLine("delegate"); } // 匿名メソッド
                , null, 0, 1000
                );
            // "delegate" を繰り返し出力

            Console.ReadKey();
        }
    }
}