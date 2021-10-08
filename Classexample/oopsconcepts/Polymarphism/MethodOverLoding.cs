using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample
{
    class MethodOverLoding
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("the addtion of {0} and {1} is :{2}", a, b,sum);
            return 0;
        }

        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("the addtion of {0}  {1}  abd {2} is :{3}", a, b,c,sum);
            return 0;
        }

        public float Add(float a, float b)
        {
            float sum= a + b;
            Console.WriteLine("the addtion of {0} and {1} is :{2}", a, b,sum);
            return 0;

        }
    }
}
