using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
   public abstract class Car
    {
        abstract public int drive();
    }
    public class Audi : Car
    {
        public override int drive()
        {
            Console.WriteLine("hey drive Safely");

            return 1;
        }
 
     }
}
