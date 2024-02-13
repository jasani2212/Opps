using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    interface Myinterface
    {
        void myMethod();
    }
    interface Otherinterface
    {
        void myMethod2();
    }

    class Yourinterface : Myinterface, Otherinterface
    {
        public void myMethod()
        {
            Console.WriteLine("heyy how are you");
        }
        public void myMethod2()
        {
            Console.WriteLine("i m fine");
        }
    }
}
 



