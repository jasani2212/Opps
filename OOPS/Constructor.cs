using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Expconstructor
    {
        int n;
        private Expconstructor(int n)
        {
            //default cinstructor
            /*Console.WriteLine("this is my default constructor");*/
         
            Console.Write(n);

        }
        public static void main(string[] args)
        {
            Expconstructor obj = new Expconstructor(20);
        }

    }
}
