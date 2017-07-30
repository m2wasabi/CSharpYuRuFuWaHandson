using System;

namespace CS2_09_restricting_accessor_accessibility
{
    class Program
    {

        static void Main(string[] args)
        {
            A a = new A();
            // a.PropertyA = 1; <- これはできない
            a.SetPropertyA(10);
            int propertyValue = a.PropertyA;
            Console.WriteLine(propertyValue);   // 10

            Console.ReadKey();
        }
    }

    /// <summary>プロパティの get/set 個別のアクセスレベル</summary>
    /// <remarks>プロパティの get アクセサーと set で異なるアクセス レベルを設定できる。
    ///  https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility
    /// </remarks>
    class A
    {
        public int PropertyA { get; private set; }
        public void SetPropertyA(int value) { PropertyA = value; }
    }
}