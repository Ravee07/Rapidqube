using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Encapsulation
{
    class Encapsulation
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Prasad";
            Console.WriteLine(myObj.Name);
        }
    }
}
