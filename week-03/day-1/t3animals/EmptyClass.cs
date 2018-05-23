using System;
namespace t3animals
{
    public class Animal
    {
		public int hunger;
		public int thirst;


		public Animal()
		{
			hunger = 50;
			thirst = 50;
		}

        public void eat()
		{
			hunger--;
            Console.WriteLine("eat");
		}

        public void drink()
		{
			thirst--;
            Console.WriteLine("drink");
		}

        public void play()
		{
			hunger++;
			thirst++;
            Console.WriteLine("play");
		}
	}
}
