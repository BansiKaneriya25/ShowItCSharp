using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp3
{
    //OOP - Object Oriented Programming

    //Class - class is a blueprint - we can define property
    //Object - instance of class

    //Encapsulation 
    //- process of hiding the members from outside the class and implemented using access modifiers
    //- is called information hiding
    //- binding the data members and func into single unit
    //Real time example - capsule - inside many ingridient used but from outside this all hide

    //Inheritance
    //Parent-child relationship is called Inheritance
    //Inherit properties from one class to another class
    //Real time example - Father business adopt child
    //Advantage - Code reusability
    // : colon - syntax

    //Base/Parent Class -> Derived/Child Class

    //Single    A -> B
    //Multilevel A -> B -> C
    //Multiple - A , B -> C
    //Hierarchical - A -> B, A-> C, A-> D
    //Hybrid - A-> B, A-> C  , B -> D, C -> D

    //Interface
    //Interface is looks like class but no implementation
    //We can declare signature of methods, properties and event 
    //Implementation part is handle by class
    //Inherite with class
    //Implementation must inside the class when inherite interface otherwise gives error
    //Multiple inhertance concept achived by interface
    //Can't create object or instance
    //By default interface is public

    //Implicit
    //Explicit

    //Abstraction
    //Hide implementation details and display only necessory features of the object.
    //Real time example - Car - 

    //Polymorphism
    //one name many form
    //Having one name with multiple functionality
    //Real time example - Area - triangle , circle

    //types
    //Static or Compile time
    //Dynamic or Run-time

    //Static or Compile time
    // - Method Overloading - same name with diff param and return type

    //Dynamic or Run-time
    // - Method Overriding - same name with same parama and same return type but in diffrent class(base/child class)
    // virtual and override keyword to archive this funcitionality

    //Partial - Same name class in diffrent source file
    //While compile code - common class will be created

    //Sealed Modifier
    //restricts the inheritance feature in OOP

    //Constructor - While create a object of class, constructor will be called
    //Same name of class and no return type 
    //Types:
    //1. Default - without any parameters
    //2. parameterized - with parameters
    //3. copy - copy contains with same class
    //4. static
    //  - create only one static constructor
    //  - must be parameterless
    //  - will be invoke only once at the time of class loading
    //  - no access modifier in static constructor
    //5. private - 
    //  - using a private constructor we can not create a object from outside of class.

    //Static Class
    // we can not create a object
    // inside static class - all members will be static
    // can not create constructor (IMP)

    static class Static_Class
    {
        public static int Id { get; set; }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsEmailValid(string email)
        {
            //logic
            // if email no valid
            //return false;
            return true;
        }
    }

    class Static_Polymorphism
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    sealed class PQR
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    //we can not inherite PQR because it's sealed modifier
    class XYZ //:PQR
    {

    }

    class Dynamic_Polymorphism_Base
    {
        public virtual int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Dynamic_Polymorphism_Derived_One : Dynamic_Polymorphism_Base
    {
        public override int Add(int a, int b)
        {
            return a + b * (50);
        }
    }
    class Dynamic_Polymorphism_Derived : Dynamic_Polymorphism_Base
    {
        public override int Add(int a, int b)
        {
            return a + b * (100);
        }
    }

    class Abstraction_A
    {
        public void SendEmail()
        {
            //get all emp data from db
            //for loop
            //send email 
        }
    }

    interface I_A
    {
        void TestA(); // this is signature
        void Print();
        void Display();
    }

    interface I_B
    {
        void TestB(); // this is signature
        void Print();
        void Display();
    }

    public class M_D : I_A
    {
        public void TestA()
        {
            Console.WriteLine("A method is called");
        }

        public void Print()
        {
            Console.WriteLine("Print method is called");
        }

        public void Display()
        {
            Console.WriteLine("Display method is called");
        }
    }

    public class M_C : I_A, I_B
    {
        public void TestA()
        {
            Console.WriteLine("AB method is called");
        }

        public void TestB()
        {
            Console.WriteLine("B method is called");
        }

        public void Print()
        {
            Console.WriteLine("Print method is called");
        }

        void I_A.Display()
        {
            Console.WriteLine("PrintA method is called");
        }

        void I_B.Display()
        {
            Console.WriteLine("PrintB method is called");
        }
    }

    public class SingleInheritance_A
    {
        public void TestA()
        {
            Console.WriteLine("A method is called");
        }
    }

    public class SingleInheritance_B : SingleInheritance_A
    {
        public void TestB()
        {
            Console.WriteLine("B method is called");
        }
    }

    public class C : SingleInheritance_B
    {
        public void TestC()
        {
            Console.WriteLine("C method is called");
        }
    }

    public class A
    {

    }

    public class H_B : A //derived class
    {

    }

    public class H_C : A //derived class
    {

    }

    public class H_D : A
    {

    }

    //multiple  - no supported in net only
    //public class multiple_C : A, B
    //{

    //}

    class ABC // by default class is internal
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }

    public class Class_Constructor
    {
        public Class_Constructor()
        {
            Console.WriteLine("Default construtor is called");
        }

        public Class_Constructor(string abc)
        {
            Console.WriteLine("param construtor is called" + abc);
        }
        public Class_Constructor(string abc, string xyz)
        {
            Console.WriteLine("param construtor is called" + abc);
        }

        static Class_Constructor()
        {
            Console.WriteLine("static construtor is called");
        }
    }

    class OOPS
    {
        static void Main(string[] args)
        {
            ABC obj = new ABC(); //object of abc class or instance of abc class

            SingleInheritance_A objA = new SingleInheritance_A();
            objA.TestA();

            SingleInheritance_B objB = new SingleInheritance_B();
            objB.TestA();
            objB.TestB();

            SingleInheritance_A objAB = new SingleInheritance_B();
            objAB.TestA();
            //objAB.TestB(); //can' be accessiable

            //SingleInheritance_B aaaa = new SingleInheritance_A(); //build error, can't creat object like this

            //Multilevel
            C objC = new C();
            objC.TestA();
            objC.TestB();
            objC.TestC();

            //I_A i_A = new I_A();

            M_C obc_MC = new M_C();
            obc_MC.Print(); // implicit implementation

            I_A obc_MC_I = new M_C();
            obc_MC_I.Display(); //explicite implementation

            Abstraction_A abstraction_A = new Abstraction_A();
            abstraction_A.SendEmail();

            Static_Polymorphism static_Polymorphism = new Static_Polymorphism();
            static_Polymorphism.Add(2, 3, 4);

            Dynamic_Polymorphism_Derived dynamic_Polymorphism_Derived = new Dynamic_Polymorphism_Derived();
            dynamic_Polymorphism_Derived.Add(2, 3);

            PartialClass_One partialClass_One = new PartialClass_One();
            //partialClass_One.ID = 1;

            Class_Constructor class_Construtor = new Class_Constructor();
            //which constructor will call first?
            //first static and then default

            Class_Constructor class_Construtor1 = new Class_Constructor("hello");

            //Static_Class objS = new Static_Class(); // we cann't do like this
            int returnSum = Static_Class.Add(2, 3);
            bool isValid = Static_Class.IsEmailValid("showItDotNet@gmail.com");
        }
    }
}
