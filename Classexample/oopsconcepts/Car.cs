using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample
{
    public class Car
    {
        public string color;
        public string model;
        public void CarDetails()
        {
            Console.WriteLine("Color:{0} Model:{1}", color, model);
        }
    }
}
