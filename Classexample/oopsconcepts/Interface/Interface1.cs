using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample
{
    public interface Interface1
    {
        void sam_add(int a, int b);
        void sam_sub(int a, int b);
        void display();
    }

    class simple : Interface1
    {
        int x, y;
        public void sam_add(int a, int b)
        {
            int m, n;
            m = a;
            n = b;
            x = m + n;
        }
        public void sam_sub(int a, int b)
        {
            int m, n;
            m = a;
            n = b;
            y = a - b;
        }
        public void display()
        {
            Console.WriteLine("Added Value is:" + x);
            Console.WriteLine("Subtracted value is:" + y);
        }
    }
}
