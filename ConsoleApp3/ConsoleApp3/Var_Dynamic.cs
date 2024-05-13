//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp3
//{
//    public class Var_Dynamic
//    {
//        class ABC
//        {
//            public int ID { get; set; }
//            public string Name { get; set; }
//        }

//        static void Main(string[] args)
//        {
//            //Var - static data type
//            // must initized value while declare
//            // support intellisense in visualstudio
//            // if variable doesn't initiazed then throw error 
//            // compile time error throw

//            //Dynamic - dynamic data type
//            // initized value not required  while declare
//            // does not support intellisense in visualstudio
//            // if variable doesn't initiazed then it will not throw error
//            // run time error throw

//            var abc = new ABC();
//            abc.Name = "abc";
//            abc.ID = 1;

//            dynamic abc1 = new ABC();
//            abc1.Name = "abc";
//            abc1.ID = 1;
//            abc1.Grade = "A";
//        }

//    }



//}
