using System;

namespace Methods
{
    class Program
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static void Main(string[] args)
        {
            MyMethod("Prasad", 23);
            MyMethod("Omkar", 25);
            MyMethod("Ravina", 22);
        }
    }
}
