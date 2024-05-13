//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp3
//{
//    public class ExceptionHandling
//    {
//        static void Main(string[] args)
//        {
//            //Exception Handling - allows you to deal with unexpected errors in our code
//            //DivideByZeroException
//            //FileNotFoundException
//            //ArgumentNullException
//            //IndexOutOfRangeException
//            //InvalidOperationException 

//            //throw ex vs throw
//            //throw ex - give current exception with original stack trace
//            //throw - give current exception without resetting stack trace

//            try
//            {
//                Test();
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }


//            void Test()
//            {
//                string str = "HelloWorld";
//                string outputStr = "";

//                try
//                {
//                    //var a = str[11];
//                    //int c = 0;
//                    //int i = 10 / c;
//                    //outputStr = str.Substring(0, 15);

//                    //get file C://console.cs

//                    try
//                    {
//                        outputStr = str.Substring(0, 15);
//                    }
//                    catch (Exception)
//                    {
//                        throw;
//                    }
//                }
//                catch (DivideByZeroException ex)
//                {
//                    throw ex;
//                }
//                catch (FileNotFoundException ex)
//                {
//                    try
//                    {

//                    }
//                    catch (Exception)
//                    {
//                        try
//                        {

//                        }
//                        catch (Exception)
//                        {

//                            throw;
//                        }
//                        throw;
//                    }
//                }

//                catch (IndexOutOfRangeException ex)
//                {

//                }
//                catch (InvalidOperationException ex)
//                {

//                }
//                catch (ArgumentNullException ex)
//                {

//                }
//                catch (Exception ex)
//                {
//                    //throw ex;
//                    throw;
//                }
//                finally
//                {
//                    Console.WriteLine("Finally block.");
//                }
//                Console.WriteLine(outputStr);
//                Console.ReadLine();
//            }
//        }

//    }



//}
