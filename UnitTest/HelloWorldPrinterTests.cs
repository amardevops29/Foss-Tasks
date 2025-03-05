// HelloWorldPrinterTests.cs
using System;
using HelloWorldApp;
using Xunit;
using System.IO;

namespace UnitTest
{
    public class HelloWorldPrinterTests
    {
        // Test that GetMessage returns the expected "Hello World" string
        [Fact]
        public void GetMessage_ReturnsHelloWorld()
        {
            // Arrange
            var printer = new HelloWorldPrinter();

            // Act
            var message = printer.GetMessage();

            // Assert
            Assert.Equal("Hello World", message);
        }

        // Test that PrintHelloWorld prints "Hello World" to the console
        [Fact]
        public void PrintHelloWorld_PrintsCorrectMessage()
        {
            // Arrange
            var printer = new HelloWorldPrinter();
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);  // Redirect Console output

                // Act
                printer.PrintHelloWorld();
                var result = sw.ToString().Trim();  // Capture and clean up output

                // Assert
                Assert.Equal("Hello World", result);
            }
        }

        // Test that GetMessage does not contain extra spaces
        [Fact]
        public void GetMessage_DoesNotContainExtraWhitespace()
        {
            // Arrange
            var printer = new HelloWorldPrinter();

            // Act
            var message = printer.GetMessage();

            // Assert
            Assert.DoesNotContain("  ", message);  // Check for double spaces
        }

        // Test that PrintHelloWorld method does not print extra spaces
        [Fact]
        public void PrintHelloWorld_PrintsNoExtraWhitespace()
        {
            // Arrange
            var printer = new HelloWorldPrinter();
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);  // Redirect Console output

                // Act
                printer.PrintHelloWorld();
                var result = sw.ToString().Trim();  // Capture and clean up output

                // Assert
                Assert.DoesNotContain("  ", result);  // Ensure no extra spaces
            }
        }
    }
}
