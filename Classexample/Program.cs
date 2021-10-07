using System;

namespace Classexample
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple class example
            /* Car ss = new Car();
             ss.color = "red";
             ss.model = "1233";
             ss.CarDetails();*/

            //Inheritance example
            /* EmpDetails e1 = new EmpDetails();
             Console.WriteLine("the Employee details are");
             e1.GetEmpInfo("Shweta",123);
             e1.GetDetails(22, 40000);*/

            //Encapsulation example
            /*Rectangel r = new Rectangel();
            r.Getdetails();
            r.Display();*/

            //Abstraction Example
            RectangleShape r = new RectangleShape();
            r.Get();
            r.Area();

        }

    }
}
