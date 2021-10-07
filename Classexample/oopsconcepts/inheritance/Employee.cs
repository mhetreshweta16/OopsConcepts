using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample
{
    public class Employee
    {
        public string Name;
        public int EmpId;
        public void GetEmpInfo(string n,int id)
        {
            Name = n;
            EmpId = id;
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("EmplId: {0}", EmpId);
        }
    }
}
