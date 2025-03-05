// HelloWorldPrinter.cs
using System;

namespace HelloWorldApp
{
    public class HelloWorldPrinter
    {
        public string GetMessage()
        {
            return "Hello World";
        }

        public void PrintHelloWorld()
        {
            Console.WriteLine(GetMessage());
        }
    }
}
