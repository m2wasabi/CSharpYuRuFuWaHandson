using System;

namespace CS2_13_Conditional_attribute
{
    class Program
    {
        /// <summary>Conditional 属性</summary>
        /// <remarks>条件付きコンパイル シンボルによる条件付きメソッドを定義ができる。シンボルが定義されていない場合、メソッドの呼び出しが行われない。
        ///  https://msdn.microsoft.com/ja-jp/library/aa664622(v=vs.71).aspx
        /// </remarks>

        static void Main(string[] args)
        {
            WriteDebug();   // デバッグ時のみ実行される
            Console.WriteLine("END");

            Console.ReadKey();
        }

        [System.Diagnostics.Conditional("DEBUG")]
        public static void WriteDebug()
        {
            Console.WriteLine("Debug Mode");
        }
    }
}