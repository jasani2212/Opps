using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class EmployeeFinalSalary
    {   
        int hoursWorked;
        double salary;
        public void getInfo(int hoursWorked , double salary)
        {
             this.hoursWorked = hoursWorked;
             this.salary = salary;
        }
        public void addSalary()
        {
            if(salary<200)
            {
                salary += 10;
            }
        }
        public void additionalWork()
        {
            if(hoursWorked > 6)
            {
                salary += 5; 
            }
        }
        public void DisplayFinalSalary()
        {
            addSalary();
            additionalWork();
            Console.WriteLine(salary);
        }
    }
}
