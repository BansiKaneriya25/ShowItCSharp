//using System;

//namespace ConsoleApp3
//{
//    class Employee
//    {
//        public int EmployeeId;
//        public string Name;
//    }
//    class CallByValue_CallByRef
//    {
//        static void Main(string[] args)
//        {
//            //Call By Value
//            int a = 15;
//            int b = a; //15
//            b = 30;

//            Console.WriteLine("a:" + a);
//            Console.WriteLine("b:" + b);


//            int x = 25;
//            UpdateValue(x);
//            Console.WriteLine("x:" + x);

//            //Call by ref
//            Employee employee1 = new Employee();
//            employee1.EmployeeId = 1;
//            employee1.Name = "Jigar";
//            UpdateName(employee1);
//            //Employee employee2 = new Employee();
//            //employee2.EmployeeId = 2;
//            //employee2.Name = "Harsh";

//            Console.WriteLine("Emp1 Name:" + employee1.Name);
//            //Console.WriteLine("Emp2 Name:" + employee2.Name);
//            Console.ReadLine();
//        }

//        private static void UpdateName(Employee employee)
//        {
//            employee.Name = "Harsh";
//        }

//        private static void UpdateValue(int y)
//        {
//            y = 40;
//        }
//    }
//}
