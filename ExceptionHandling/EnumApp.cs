using System;

namespace MyApplication
{
    class EnumApp
    {
        enum Months
        {
            January,    
            February,   
            March,      
            April                  
        }
        static void Main(string[] args)
        {
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }
    }
}
