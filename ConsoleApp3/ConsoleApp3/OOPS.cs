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
    // - Method Overloading

    //Dynamic or Run-time
    // - Method Overriding

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
        }
    }
}
