//using System;
//using System.Diagnostics;
//using System.IO;
//using System.Text;

//namespace ConsoleApp3
//{ 
//    class String_StringBuilder
//    {
//        static void Main(string[] args)
//        {
//            //string is ReferenceEquals data type
//            //immutable

//            string str = "";
//            Console.WriteLine("Loop Started");
//            var stopwatch = new Stopwatch();
//            stopwatch.Start();

//            for (int i = 0; i < 3000000; i++)
//            {
//                str = "dotnet" + i;
//            }

//            stopwatch.Stop();
//            Console.WriteLine("Loop Ended");
//            Console.WriteLine("Time for sting in MS:" + stopwatch.ElapsedMilliseconds);


//            StringBuilder sb = new StringBuilder();
//            Console.WriteLine("Loop Started for string builder");
//            var stopwatch1 = new Stopwatch();
//            stopwatch1.Start();

//            for (int i = 0; i < 3000000; i++)
//            {
//                sb.Append("dotnet");
//            }

//            stopwatch1.Stop();
//            Console.WriteLine("Loop Ended for string builder");
//            Console.WriteLine("Time for StringBuilder in MS:" + stopwatch1.ElapsedMilliseconds);

//            //Console.WriteLine(str);
//            Console.ReadLine();

//            //string immutable
//            //StringBuilder mutable
//            //SB is fast compare to string
//            //string is create a new obj every time while modification
//            //SB is using same obj every time while modification
//        }
//    }
//}
