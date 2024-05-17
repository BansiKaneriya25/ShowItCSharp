using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    delegate void Calculator(int x, int y);
    delegate void AnonymousCalculator(int x, int y);
    public class Delegate
    {
        // Delegate:
        // Delegate is variable that holds the reference to method
        // Can refer to more than one methods of same return type and param

        //Type:
        //Single
        //Multicast
        //Anonymous

        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Main(string[] args)
        {

            Calculator calc = new Calculator(Add);
            calc += Mul; //Multicast

            calc(20, 30);

            //Anonymous
            AnonymousCalculator anonymousCalculator = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            anonymousCalculator(50, 60);

            Console.ReadLine();

        }



    }

}
