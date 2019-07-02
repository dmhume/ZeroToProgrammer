using System;

namespace Lesson11_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Color = "Blue";

            Car myCar2 = new Car();
            myCar2.Color = "Red";

            int total = Math.Add(5, 3);

            Console.WriteLine(myCar.Color);
            Console.WriteLine(myCar2.Color);
            Console.WriteLine(total);
        }
    }

    class Car
    {
        public string Color { get; set; }
    }

    class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
