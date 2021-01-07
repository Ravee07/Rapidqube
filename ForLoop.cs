using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsLoops
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            string[] cars = { "Honda", "BMW", "Ford"};
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
