using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_InterfacesAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Gender = "male";
            myDog.Breathe();
            myDog.Eat();
            Console.WriteLine("My gender is " + myDog.Gender);

            Fish myFish = new Fish();
            myFish.Gender = "female";
            myFish.Eat();
            myFish.Breathe();
            Console.WriteLine("My gender is " + myFish.Gender);
        }
    }
}
