using System;
using System.IO;

namespace ConsoleApp3
{
    class CommandLineArgument
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"First Arg: {args[0]}");
            //Need to connect with DB
            string connectionString = args[0].ToString();
            Console.ReadLine();
        }
    }
}
