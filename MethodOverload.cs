using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class MethodOverload
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static int PlusMethod(double x, double y)
        {
            int z=Convert.ToInt32(x + y);
            return z;
        }

        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}
