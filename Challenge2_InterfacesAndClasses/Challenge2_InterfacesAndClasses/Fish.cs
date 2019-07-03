using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_InterfacesAndClasses
{
    class Fish : IAnimal
    {
        public string Gender { get; }
        public string Name { get; }

        public Fish(string gender, string name)
        {
            Gender = gender;
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("I am a fish and I am eating");
        }
        public void Breathe()
        {
            Console.WriteLine("I am a fish and I am breathing");
        }
    }
}
