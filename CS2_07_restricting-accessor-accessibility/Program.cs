using System;

namespace CS2_07_restricting_accessor_accessibility
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

    class A
    {
        public int PropertyA { get; private set; }
        public void SetPropertyA(int value) { PropertyA = value; }
    }
}