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
        public static void main(string[] args)
        {
            /* {
                 Sum();
             }
             static void Sum()
             {
                 Console.WriteLine("hey nitin");
             }*/

            //No Argument but Return Value

            /*{
                int Result = Sum();
                Console.WriteLine($"Sum is {Result}");
                Console.ReadKey();
            }
            static int Sum()
            {
                int x = 10;
                int y = 20;
                int sum = x + y;
                return sum;
            }*/

            //Argument but Not Return

            /*{
                int x = 10, y = 20;
                Sum(x, y);
                Console.ReadKey();
            }
            static void Sum(int x, int y)
            {
                int sum = x + y;
                Console.WriteLine($"Sum is {sum}");
            }*/

            //Argument and Return

            /*{
                int x = 10, y = 20;
                int Result = Sum(x, y);
                Console.WriteLine($"Sum is {Result}");
                Console.ReadKey();
            }
            static int Sum(int x, int y)
            {
                int sum = x + y;
                return sum;
            }*/
        }
    }
}
    

