using System;

namespace t3animals
{
    class Program
    {
        static void Main(string[] args)
        {
			Animal lion = new Animal();
			lion.eat();
			Console.WriteLine("lion hunger is " + lion.hunger);
			lion.drink();
			Console.WriteLine("lion thrist is " + lion.thirst);
			lion.play();
			Console.WriteLine("lion hunger is " + lion.hunger + ", thirst " + lion.thirst);

			Animal tiger = new Animal();
			Animal zebra = new Animal();
		}
    }
}
