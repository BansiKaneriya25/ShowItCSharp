//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace ConsoleApp3
//{
//    class EntentionMethod
//    {
//        static void Main(string[] args)
//        {
//            //Extension method allow you to add new methods to existing types without modifying original type

//            string str = "HelloWorld";

//            string outputStr = str.Substring(0, 5);
//            string outputStringExtension = str.RightSubString(5);

//            int intCount = 0;
//            string outputStringExtension1 = intCount.RightIntString(5);


//            string strNew = "Hello";  //He //llo
//            string outputStringExtension2 = strNew.RightSubString(5); //He
//            string outputStringExtension3 = strNew.RightSubString(3); //llo

//            Console.WriteLine(outputStr);
//            Console.WriteLine(outputStringExtension);
//            Console.ReadLine();
//        }

//    }

//    public static class StringExtension
//    {
//        public static string RightSubString(this String s, int count)
//        {
//            return s.Substring(s.Length - count, count);
//        }

//        public static string RightIntString(this Int32 s, int count)
//        {
//            return "";
//        }
//    }

//}
