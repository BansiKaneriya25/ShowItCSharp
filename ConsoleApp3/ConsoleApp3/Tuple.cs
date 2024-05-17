//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Threading;

//namespace ConsoleApp3
//{
//    public class Tuple
//    {
//        //Tuple
//        // Tuple is data structor
//        //store diff types of data type as sequence of elements
//        // return multiple value as return type in single parameter

//        //Tuple<int, string, int>

//        static void Main(string[] args)
//        {
//            Cal cal = new Cal();
//            Tuple<int, string, int> tuple = cal.ReturnMultipleParam(2, "Test Demo", 4);
//            //Tuple<int, string, int> tuple = new Tuple<int, string, int>(1, "Hello", 3);
//            Console.WriteLine(tuple.Item1);
//            Console.WriteLine(tuple.Item2);
//            Console.WriteLine(tuple.Item3);
//            Console.ReadLine();
//        }

//        public class Cal
//        {
//            public Tuple<int, string, int> ReturnMultipleParam(int v1, string v2, int v3)
//            {
//                Tuple<int, string, int> tuple = new Tuple<int, string, int>(v1, v2, v3);
//                return tuple;
//            }
//        }



//    }



//}
