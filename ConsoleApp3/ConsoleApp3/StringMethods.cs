//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace ConsoleApp3
//{
//    //https://www.javatpoint.com/c-sharp-strings
//    class StringMethods
//    {
//        static void Main(string[] args)
//        {
//            //https://www.javatpoint.com/c-sharp-strings

//            //convert char to string
//            char[] ch = { 's', 'h', 'o', 'w', ' ', 'i', 't' };//0 - 6
//            string output = new string(ch);
//            Console.WriteLine(output);

//            //Clone
//            var abc = output.Clone();

//            //CompareTo
//            int a = output.CompareTo(abc);

//            //Substring
//            string abc1 = output.Substring(1);
//            string abc2 = output.Substring(1, output.Length - 2); // return first and last char

//            //Contains
//            bool result = output.Contains('s');

//            string input = "This is test line data.";
//            //i - how many occurance

//            char[] chStr = input.ToCharArray();
//            int count = 0;
//            for (int i = 0; i < chStr.Length; i++)
//            {
//                if (chStr[i] == 'i')
//                {
//                    count++;
//                }
//            }

//            int counts = 0;
//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i].ToString() == "i")
//                {
//                    counts++;
//                }
//            }
//            Console.WriteLine("i - char how many occurance:" + count);
//            Console.WriteLine("i - string how many occurance:" + counts);

//            //Concat
//            string str1 = "abc";
//            string str2 = "xyz";
//            string str3 = "pqr";

//            string results = string.Concat(str1, str2, str3);

//            //CopyTo
//            char[] chDestination = new char[18];
//            input.CopyTo(5, chDestination, 0, 18);

//            //Equals
//            bool strReturn = str1.Equals(str2);

//            //EndsWith
//            bool strReturn1 = input.EndsWith("data");
//            bool strReturn2 = input.Contains("data");

//            //IndexOf
//            int index = input.IndexOf("i"); //-1 means no index exists

//            //Insert
//            string stroutpur = str1.Insert(2, "-");

//            string strValue = "     ";

//            // IsNullOrWhiteSpace
//            if (string.IsNullOrWhiteSpace(strValue))
//            {
//                Console.WriteLine("White space");
//            }

//            //IsNullOrEmpty
//            if (string.IsNullOrEmpty(strValue))
//            {
//                Console.WriteLine("Null or Empty space");
//            }

//            //Trim
//            string strTrim = " This data ";
//            string x = strTrim.Trim();
//            string y = strTrim.TrimStart();
//            string z = strTrim.TrimEnd();

//            //Split
//            string firstName = "ViratKohli";
//            string[] strLst = firstName.Split(" ");
//            string middleName = strLst.LastOrDefault();

//            //Join
//            string[] strArray = { "ABC", "XYZ", "PQR" };
//            string strJoin = string.Join("", strArray);

//            //Replace
//            string strReplace = input.Replace("test", "demo");

//            //StartsWith
//            bool StartsWith = input.StartsWith("This");

//            //Remove
//            string strRemove1 = "Hello C# Demo";
//            string strRemove2 = strRemove1?.Remove(2);
//            string strRemove3 = strRemove1?.Remove(6, 3);

//            //ToLower() 
//            //ToUpper()

//            string strLowerUpper = null;
//            string lower = strLowerUpper?.ToLower();
//            string upper = strLowerUpper?.ToUpper();

//            string newStr = "Hello";
//            string abc2StrNew = newStr.Substring(0, 1); 
//            //string abc2StrNew = newStr.Substring(0, 2); 
//            //string abc2StrNew = newStr.Substring(0, 3); 


//            Console.ReadLine();

//        }
//    }
//}
