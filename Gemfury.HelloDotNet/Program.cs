using System;
using Gemfury.WorldDotNet;

namespace Gemfury.HelloDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            Console.WriteLine(string.Format("Hi, {0}", hello.SayHello()));
        }
    }
}
