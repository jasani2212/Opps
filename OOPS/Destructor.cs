using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Destructor
    {
        public string Name;
        public int Age;
        public Destructor(String Name , int Age) 
        {
            this.Name = Name;
            this.Age = Age;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }
        ~Destructor()
        {
            Console.WriteLine("Destructor has been Invoked!!");
        }
    }
}
