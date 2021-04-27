using System;

namespace ImplicitConversionPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float myFloatValue = 10;
            int myIntValue = (int) myFloatValue;
            Console.WriteLine("myIntValue is " + myIntValue);
        }
    }
}
