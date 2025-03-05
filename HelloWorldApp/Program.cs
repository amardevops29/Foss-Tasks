using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new HelloWorldPrinter();
            printer.PrintHelloWorld();
        }
    }
}
