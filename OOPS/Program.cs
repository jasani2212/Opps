// See https://aka.ms/new-console-template for more information

using OOPS;
using System.Collections.Generic;

class Program
{
    //Passed By Value 
    /*public static void PassedByValue(int a)
    {
        a = a + 15;
        Console.WriteLine(a);
    }*/

    //Passed By Ref
    /*public static void PassedByRef(ref int a)
    {
        a = a + 15;
        Console.WriteLine(a);
    }*/

    //Passed By Out

    /* public static void PassedByOut(out int a)
     {
         a = 25;
         Console.WriteLine(a);
     }*/
    public static void Main(String[] args)
    {
        #region PassedBy Value
        /* int b = 5;
         PassedByValue(b);
         Console.WriteLine(b);
         Console.ReadLine();*/
        #endregion PassedBy Value

        #region PassedBy Ref
        /*int b = 5;
        PassedByRef(ref b);
        Console.WriteLine(b);
        Console.ReadLine();*/
        #endregion PassedBy Ref 

        #region PassedBy Out
        /*int n;
        PassedByOut(out n);
        Console.WriteLine(n);
        Console.ReadLine();*/
        #endregion PassedBy Out

        #region Inheritance
        //Single 
        //Dog obj = new Dog();
        //obj.eat2();
        //obj.eat();

        //hirarchical
        //C obj = new C();
        //obj.hirarchical();

        //Multilevel
        //C obj = new C();    
        //obj.demo2();

        #endregion Inheritance

        #region Polymorphism 

        //method Overloading
        /* Addition obj = new Addition();
         obj.Sum(5.5F, 5);*/

        //method Overriding
        //Multiplication obj = new Multiplication();
        //obj.Sum(5, 10);

        #endregion

        #region Abstraction
        //Car obj = new Audi();
        //obj.drive();
        //#endregion Abstraction
        #endregion Abstraction

        #region Constructor
        //Default Constructor
        //Expconstructor obj = new Expconstructor();

        //Parameterized Constructor
        // Expconstructor obj = new Expconstructor(10);

        //Private Constructor
        //Expconstructor obj = new Expconstructor(10);

        #endregion Constructor

        #region Interface
        //Yourinterface obj = new Yourinterface();
        //obj.myMethod();
        //obj.myMethod2();
        #endregion Interface

        #region Partial Class
        //Employee obj = new Employee();
        //obj.Empname();
        //obj.EmpSalary();

        #endregion Partial Class

        #region Static Class
        //StaticExp.Name = "Nitin";
        //StaticExp.Display();
        #endregion Static Class

        #region Sealed Class
        //SealedExp obj = new SealedExp();
        //obj.hey();
        #endregion Sealed Class

        #region Looping Statements
        //While loop

        /*int i = 1;
        while(i<=20)
        {
            Console.WriteLine(i+"");
            i++;
        }*/

        //Do While Loop

        /*int i = 1;
        do
        {
            Console.WriteLine(i);
            i--;
        }
        while (i<=30);*/

        //For Loop

        /*for(int i = 0; i <=15; i++) 
        {
            Console.WriteLine(i);
        }*/

        //For Each
        /* int[] a = { 10, 20, 30, 40, 50 };
         foreach(int i in a)
         {
             Console.WriteLine(i);
         }*/
        #endregion Looping Statements

        #region Datatypes

        /*{
            int a = 5;               // integer (whole number)
            double b = 5.99D;  // floating point number
            char c = 'D';         // character
            bool d = true;          // boolean
            string e = "hey nitin";     // string
            string[] arr = { "nitin", "jasani" }; //Array
            *//*Dictionary<string,int> dictionary = new Dictionary<string, int>();  
            dictionary.Add("one", 1);
            dictionary.Add("two", 2);
            Console.WriteLine(dictionary);*//*
            Console.WriteLine(arr[0]);            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }*/
        #endregion Datatypes

        #region Function
        /*FunctionExp.Sum_NA_NR();
        Console.WriteLine();

        FunctionExp.Sum_WA_NR(10,20);
        Console.WriteLine();

        int a = FunctionExp.Sum_NA_WR();
        Console.WriteLine(a);

        int b = FunctionExp.Sum_WA_WR(30,40);
        Console.WriteLine(b);*/


        #endregion Function

        #region Recursion
        /*RecursionExp obj = new RecursionExp();
        obj.demoRecursive();*/
        #endregion Recursion

        #region Enum
       /* EnumExp today = EnumExp.Thurseday;
        Console.WriteLine(today);*/
        #endregion Enum
    }
}


