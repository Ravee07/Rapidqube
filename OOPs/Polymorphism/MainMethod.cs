using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Polymorphism
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car();

            myCar.honk();

            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
