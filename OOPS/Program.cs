// See https://aka.ms/new-console-template for more information

using OOPS;

class Program
{

    public static void Main(String[] args)
    {

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
     
       /* {
            int a = 5;               // integer (whole number)
            double b = 5.99D;  // floating point number
            char c = 'D';         // character
            bool d = true;          // boolean
            string e = "hey nitin";     // string
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }*/
    }

    #endregion Datatypes

}

