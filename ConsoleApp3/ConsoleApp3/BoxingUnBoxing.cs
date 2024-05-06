using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp3
{
    class BoxingUnBoxing
    {
        //Static Memory - Stack
        //Dynamic Memory - Heap        
        public string Name { get; set; }

        static void Main(string[] args)
        {
            BoxingUnBoxing obj = new BoxingUnBoxing();
            obj.Name = "ABC";

            int x = 10;

            object y = x; //Boxing - Converting value type to ref type

            int z = (int)y; //Unboxing - Converting value ref type to value type
        }


    }
}
