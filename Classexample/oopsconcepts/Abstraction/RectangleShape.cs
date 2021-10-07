using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample
{

    abstract class Shape
    {
        public abstract void  Area();
    }
    
    class RectangleShape: Shape
    {
        private double length;
        private double width;

        public void Get( )
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public override void Area()
        {
            Console.WriteLine("Rectangle class area :");
            double res;
            res = length * width;
           Console.WriteLine("Area is : {0}", res);
        }
    }
}
