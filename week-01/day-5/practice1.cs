using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //12 cuboid

			double a = 3;
			double b = 2;
			double c = 4;
			double surface = 2*a*b + 2*a*c + 2*b*c;
			double volume = a*b*c;
			Console.WriteLine("Surface Area: " + surface);
			Console.WriteLine("Volume: " + volume);

            //16 animals and legs

            Console.WriteLine("How many chickens does this farmer have?");
			int chickens = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many pigs does this farmer have?");
			int pigs = Int32.Parse(Console.ReadLine());
			int legs = (chickens * 2) + (pigs * 4);

			Console.WriteLine("The farmers animals have " + legs + " legs all together.");

		}
    }
}
