﻿using System;

namespace CS3_09_partial_method
{
    /// <summary>Partial メソッド</summary>
    /// <remarks>Partial クラスの定義時にメソッドのシグネチャと実装を分けられる。定義できるメソッドは void を返す private メソッドのみ。
    ///  https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/partial-method
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            new A().Method();           // 何も出力されない
            Console.WriteLine("====="); // =====
            new B().Method();           // Class B Method

            Console.ReadKey();
        }
    }

    partial class A
    {
        internal void Method()
        {
            this.PartialMethod("Class A Method");
        }

        partial void PartialMethod(string text);
    }

    partial class A
    {
        //partial void PartialMethod(string text)
        //{
        //    Console.WriteLine(text);
        //}
    }

    partial class B
    {
        internal void Method()
        {
            this.PartialMethod("Class B Method");
        }

        partial void PartialMethod(string text);
    }

    partial class B
    {
        partial void PartialMethod(string text)
        {
            Console.WriteLine(text);
        }
    }
}