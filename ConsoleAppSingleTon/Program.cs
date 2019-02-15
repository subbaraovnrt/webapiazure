using System;

namespace ConsoleAppSingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var singleTonObj = SingleTon.GetInstance();

            Console.WriteLine($"Increment Value1: {singleTonObj.GetIncrement()}");

            Console.WriteLine($"Increment Value2: {singleTonObj.GetIncrement()}");

            Console.WriteLine($"Increment Value3: {singleTonObj.GetIncrement()}");

            Console.ReadLine();
        }
    }
}
