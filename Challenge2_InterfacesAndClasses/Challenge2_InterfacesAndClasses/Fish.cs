using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_InterfacesAndClasses
{
    class Fish : IAnimal
    {
        public string Gender { get; set; }

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
