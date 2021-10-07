using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample
{
    public class EmpDetails:Employee
    {
        public int Age;
        public double Salary;

        public void GetDetails(int a,double s)
        {
            Age = a;
            Salary = s;
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Salery: {0}", Salary);
        }  
    }
}
