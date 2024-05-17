//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp3
//{
//    public class Employee
//    {
//        public string Name { get; set; }
//    }
//    public class Ref_Out
//    {
//        //Ref
//        // - Passing arguments by reference. it means any changes made to this arg in the method it will reflected with original variable
//        // - bi-direction works
//        // - not complusory to initized param value

//        //Out
//        // - Passing arg by ref as similar ref keywork but in calling method parameter value must be initizied
//        // - unidirection
//        // - complusory to initized param value

//        public static string GetNextNumber(ref int i)
//        {
//            i++;
//            //List<Employee> 10 total - 2 failed - ref - 8 list & need to return 2 failed emp list
//            //failed emp - remove
//            return "Success";
//        }

//        public static void GetNextGrade(out int j)
//        {
//            j = 1; // - complusory to initized param value
//            j++;
//        }


//        static void Main(string[] args)
//        {
//            int num = 1;
//            string returnStr = GetNextNumber(ref num);

//            int j;
//            GetNextGrade(out j);
//            Console.WriteLine(num);
//            Console.WriteLine(j);
//            Console.ReadLine();
//        }

//    }



//}
