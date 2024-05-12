//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace ConsoleApp3
//{
//    public static class StaticClass
//    {
//        //Static
//        //we can modify value in static constructor
//        //we can assign value at the time of initilization or static construtor
//        static int Calc = 1;

//        static StaticClass()
//        {
//            Calc = 2;
//        }

//        static void Test()
//        {

//        }
//    }

//    class Constant_ReadOnly_Static
//    {
//        int abc = 4;

//        static void Main(string[] args)
//        {
//            //Constant - can't modification value once declare and initialize
//            const string DBString = "server=remote";
//            const double Arith = 3.5;

//            void DBConnection()
//            {
//                double calculate = Arith * 100;

//                //Get COnnection

//                string conn = DBString;
//            }
//        }

//        private void ReadOnlyMethod()
//        {
//            Console.WriteLine(Calculation);
//            Console.ReadLine();
//        }

//        //Read-Only - we can modify value in non-static constructor
//        // we can assign value at the time of initilization or non static construtor

//        private readonly double Calculation = 4.5;

//        public Constant_ReadOnly_Static()
//        {
//            Calculation = 5.5;
//        }

//    }
//}
