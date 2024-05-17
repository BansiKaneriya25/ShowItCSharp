//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Threading;

//namespace ConsoleApp3
//{
//    public class AbstractClass
//    {
//        //Abstract Class
//        // abstract and non abstract method we can create inside it
//        // by default it's public
//        // we cann't create object
//        // abstract method implementation in child class


//        static void Main(string[] args)
//        {
//            Display obj = new Display();
//            obj.Id = 10;

//            //Calculator obj1 = new Calculator();

//            obj.Addition(2, 5);
//            obj.Multipilcation(10, 4);
//            Console.ReadLine();
//        }

//        abstract class Calculator
//        {
//            public readonly int Age;
//            public int Id;

//            public Calculator()
//            {
//                Age = 30;
//                Console.WriteLine("Constructor is called.");
//            }

//            //non abstract method
//            public void Addition(int a, int b)
//            {
//                Id = 10;
//                Console.WriteLine("Sum:" + (a + b));
//            }

//            //abstract method
//            public abstract void Multipilcation(int a, int b);
//        }

//        //display as child
//        class Display : Calculator // base
//        {
//            public override void Multipilcation(int a, int b)
//            {
//                Console.WriteLine("Mul:" + (a * b));
//            }
//        }


//    }



//}
