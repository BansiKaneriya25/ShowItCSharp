//using System;
//using System.IO;

//namespace ConsoleApp3
//{
//    class Recursion
//    {
//        static void Main(string[] args)
//        {
//            //Real time example
//            string rotDir = @"C:\New folder";
//            GetAllFiles(rotDir);

//            fun1(3);
//        }

//        static void GetAllFiles(string rotDir)
//        {
//            string[] allFiles = Directory.GetFiles(rotDir);

//            foreach (var item in allFiles)
//            {
//                Console.WriteLine(item);
//            }

//            string[] allDirectory = Directory.GetDirectories(rotDir);

//            foreach (var item in allDirectory)
//            {
//                GetAllFiles(item);
//            }
//            Console.ReadLine();
//        }

//        public static void fun1(int n)
//        {
//            if (n > 0)
//            {
//                Console.WriteLine(n);
//                fun1(n - 1);
//            }
//        }

//        //public static void fun2(int n)
//        //{
//        //    fun3(n);
//        //}
//        //public static void fun3(int n)
//        //{
//        //    fun4(n);
//        //}
//    }
//}
