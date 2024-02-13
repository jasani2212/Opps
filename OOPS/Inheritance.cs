using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
        //Single Inheritance

       /* class Animal
        {
            public void eat()
            {
                
            }
        public void eat2()
        {
            Console.WriteLine("ok done");
        }
        }
        class Dog : Animal
        {
        public void eat()
        {
             Console.WriteLine("Ohh thats Great");
        }
        }*/

       //Hirarchical Inheritance
      /* class A
    {
        public void hirarchical()
        {
            Console.WriteLine("this is first hirarchical");
        }
    }
    class B : A
    {
        public void hirarchical2()
        {
             Console.WriteLine("this is second hirarchical");
        }
    }
    class C : A
    {
        public void hirarchical3()
        {
            Console.WriteLine("this is third hirarchical");
        }
    }*/

    //Multilevel Inheritance

    class A
    {
        public void demo()
        {
            Console.WriteLine("this is demo");
        }
    }
    class B : A
    {
        public void demo2()
        {
            Console.WriteLine("this is demo2");
        }
    }
    class C : B
    {
        public void demo3()
        {
            Console.WriteLine("this is demo3");
        }
    }


    }

