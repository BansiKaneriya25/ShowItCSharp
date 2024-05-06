//using System;
//using System.IO;

//namespace ConsoleApp3
//{
//    class ToString_ConvertToString
//    {
//        static void Main(string[] args)
//        {
//            //ToString() - can't handle null value

//            string str = "abc";
//            string str1 = str.ToString();
//            Console.WriteLine("ToString():" + str1);

//            //FirstName MiddleName LastName - First:Virat Last:Kohli Middle:null
//            //string strMiddle = null;
//            //string str1Middle = strMiddle.ToString();
//            //Console.WriteLine("ToString():" + str1Middle);

//            //Convert.ToString() - can hanlde null value automatically
//            string cstr = "abc";
//            string cstr1 = Convert.ToString(cstr);
//            Console.WriteLine("Convert.ToString():" + cstr1);

//            //FirstName MiddleName LastName - First:Virat Last:Kohli Middle:null
//            string cstrMiddle = null;
//            string cstr1Middle = Convert.ToString(cstrMiddle);
//            Console.WriteLine("ToString():" + cstr1Middle);
//            Console.ReadLine();
//        }
//    }
//}
