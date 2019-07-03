using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_InterfacesAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("male", "Tim");
            myDog.Breathe();
            myDog.Eat();
            Console.WriteLine("My gender is " + myDog.Gender + " and my name is " + myDog.Name);

            Fish myFish = new Fish("female", "Holly");
            myFish.Eat();
            myFish.Breathe();
            Console.WriteLine("My gender is " + myFish.Gender + " and my name is " + myFish.Name);
        }
    }
}
