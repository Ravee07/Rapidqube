using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsLoops
{
    class Array
    {
        static void Main(string[] args)
        {
            string[] cars = { "Honda", "BMW", "Ford" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}
