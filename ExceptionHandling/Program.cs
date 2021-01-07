using System;

namespace MyApplication
{
    interface IAnimal
    {
        void animalSound(); 
    }
    class Tiger : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Tiger");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tiger myPig = new Tiger();  
            myPig.animalSound();
        }
    }
}
