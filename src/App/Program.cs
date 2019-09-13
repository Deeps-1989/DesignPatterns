using System;
using Microsoft.Extensions.CommandLineUtils;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var app = new CommandLineApplication();
            app.Name = "Implementing Design Patterns using C#";

        }
    }
}