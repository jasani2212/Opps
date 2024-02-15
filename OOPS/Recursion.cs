using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class RecursionExp
    {
        int n=0;
        public void demoRecursive()
        {
            if(n==20)
            {
                return;
            }
            Console.WriteLine(n);
            n++;
            demoRecursive();
        } 
    }
}
