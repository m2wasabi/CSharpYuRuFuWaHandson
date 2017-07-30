using System;

namespace CS2_04_partial_type
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.A1(); // A1
            a.A2(); // A2

            Console.ReadKey();
        }
    }

    partial class A
    {
        public void A1() { Console.WriteLine("A1"); }
    }

    partial class A
    {
        public void A2() { Console.WriteLine("A2"); }
    }
}