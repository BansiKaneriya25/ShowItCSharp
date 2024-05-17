//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp3
//{
//    public class Generic
//    {
//        //Generic
//        // generic allows us to make classes and methods -  type independent or type safe


//        static void Main(string[] args)
//        {
//            //Method Level
//            bool result = Calculator.AreEqual<int>(4, 4);
//            bool resultStr = Calculator.AreEqual<string>("Test", "Test");
//            bool resultDecimal = Calculator.AreEqual<double>(0.5, 0.5);

//            //Class Level
//            bool resultClass = CalculatorClass<int>.AreEqual(4, 4);
//        }

//        //Method Level
//        public static class Calculator
//        {
//            public static bool AreEqual<T>(T value1, T value2)
//            {
//                return value1.Equals(value2);
//            }

//            //public static bool AreEqual(int value1, int value2)
//            //{
//            //    return value1.Equals(value2);
//            //}

//            //public static bool AreEqual(string value1, string value2)
//            //{
//            //    return value1.Equals(value2);
//            //}
//        }

//        public static class CalculatorClass<T>
//        {
//            public static bool AreEqual(T value1, T value2)
//            {
//                return value1.Equals(value2);
//            }
//        }

//    }



//}
