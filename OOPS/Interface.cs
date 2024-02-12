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
    class Yourinterface : Myinterface
    {
        public void myMethod()
        {
            Console.WriteLine("heyy how are you");
        }
    }
}
