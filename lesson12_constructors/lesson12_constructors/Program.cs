using System;

namespace lesson12_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal myAnimal = new Animal();

            Dog myDog = new Dog();
            myDog.Breathe();

            myAnimal.Name = "David";
            myAnimal.Breathe();
        }

        class Animal : IAnimal
        {
            public string Name { get; set; }
            public string Color { get; set; }

            public void Breathe()
            {
                Console.WriteLine("I'm Breathing");
            }

            public void Eat()
            {

            }
        }

        class Dog : IAnimal
        {
            public int NumberofLegs { get; set; }

            public string Name { get; set; }

            public void Breathe()
            {
                Console.WriteLine("I'm Breathing");
            }
        }

        interface IAnimal
        {
            string Name { get; set; }

            void Breathe();

        }
    }
}
