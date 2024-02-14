using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
            public class FunctionExp
            {   
            //No Argument and No Return Type
                public static void Sum_NA_NR()
             {
               Console.WriteLine("hey nitin");
             }

            //No Argument but Return Value

            public static int Sum_NA_WR()
            {
                int x = 10; 
                int y = 20;
                int sum = x + y;
                return sum;
            }

            //Argument but Not Return
            public static void Sum_WA_NR(int x, int y)
            {
                int sum = x + y;
                Console.WriteLine($"Sum is {sum}");
            }

            //Argument and Return

            public static int Sum_WA_WR(int x, int y)
            {
                int sum = x + y;
                return sum;
            }
        }
   }
    

