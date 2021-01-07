using System;

namespace MyApplication
{
    class Animal  
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Tiger : Animal  
    {
        public override void animalSound()
        {
            Console.WriteLine("Tiger");
        }
    }

    class Dog : Animal   
    {
        public override void animalSound()
        {
            Console.WriteLine("Dog");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  
            Animal myTiger = new Tiger();  
            Animal myDog = new Dog();  

            myAnimal.animalSound();
            myTiger.animalSound();
            myDog.animalSound();
        }
    }
}
