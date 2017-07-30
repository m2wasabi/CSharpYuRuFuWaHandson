using System;

namespace CS2_14_fixed_size_buffers
{
    /// <summary>固定サイズ バッファー (fixed)</summary>
    /// <remarks>DLL や COM を扱う際に使える、固定サイズの配列を持ったバッファーを作成することができる。
    ///  https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/unsafe-code-pointers/fixed-size-buffers
    ///  コンパイルする際にプロジェクトの設定＞ビルドの設定で『アンセーフコードの許可』のチェックが必要になります。
    /// </remarks>

    class Program
    {

        static void Main(string[] args)
        {
            MyClass myC = new MyClass();

            unsafe
            {
                // Pin the buffer to a fixed location in memory.
                fixed (char* charPtr = myC.myBuffer.fixedBuffer)
                {
                    *charPtr = 'A';
                }
            }
        }
    }

    internal unsafe struct MyBuffer
    {
        public fixed char fixedBuffer[128];
    }

    internal unsafe class MyClass
    {
        public MyBuffer myBuffer = default(MyBuffer);
    }
}