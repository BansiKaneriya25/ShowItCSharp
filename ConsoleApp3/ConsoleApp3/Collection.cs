//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Threading;

//namespace ConsoleApp3
//{
//    public class Collection
//    {
//        //Collaction
//        //store, manage multiple data


//        //Array
//        //ArrayList
//        //List
//        //HashTable
//        //Dictonary

//        static void Main(string[] args)
//        {
//            //Array
//            //ArrayList

//            //Array - we can define index while initialize obj

//            //ArrayList - we can store diff data type of data 
//            // only value we can store

//            int[] arr = new int[5];

//            arr[0] = 1;
//            arr[1] = 5;
//            arr[2] = 3;
//            arr[3] = 8;
//            arr[4] = 9;

//            int aa = arr.Count();


//            ArrayList arrayList = new ArrayList();
//            arrayList.Add(1);
//            arrayList.Add(5);
//            arrayList.Add("HEllo");
//            arrayList.Add(0.5);

//            int cnt = arrayList.Count;


//            //List - we can store only one data type of data

//            List<string> lst = new List<string>();
//            lst.Add("ABC");
//            lst.Add("XYZ");

//            List<int> lstInt = new List<int>();
//            lstInt.Add(11);
//            lstInt.Add(12);

//            int lstCnt = lstInt.Count;

//            //HashTable - key and value pair
//            // store diff data types of data and key also
//            // key must be uniqu

//            Hashtable ht = new Hashtable();
//            ht.Add(1, "ABC");
//            ht.Add("QA", "XYZ");
//            ht.Add(3.5, "WSWS");
//            ht.Add(4, 56);
//            ht.Add(5.5, 6.654);

//            int htCnt = ht.Count;

//            //Dictionary
//            // we can store 2 types of data type but we need to declare first
//            // key value pair


//            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
//            keyValuePairs.Add(1, "Hello");
//            keyValuePairs.Add(2, "Hello Q");

//            int keyCnt = keyValuePairs.Count;

//            Console.ReadLine();


//        }


//    }



//}
