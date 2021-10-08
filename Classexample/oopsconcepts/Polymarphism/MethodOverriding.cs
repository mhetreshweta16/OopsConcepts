using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample
{
    class  MethodOverriding //base class
    {
        public virtual void Display()
        {
            Console.WriteLine("hello good morning ");
        }

    }

    class XYZ : MethodOverriding
    {
        public override void Display()
        {
            Console.WriteLine("hey, hello good evening ");
        }
    }

    class ABC : MethodOverriding
    {
        public override void Display()
        {
            Console.WriteLine("hey, hello how are you ");
        }
    }
}
