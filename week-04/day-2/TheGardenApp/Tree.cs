using System;
namespace TheGardenApp
{
	public class Tree : Garden
    {
		public Tree(string color)
        {
            this.color = color;
            water = 0;
        }

		public void Info()
        {
            if (water < 10)
            {
                Console.WriteLine("The {0} tree needs water.", color);
            }
            Console.WriteLine("The {0} tree doesn't need water.", color);
        }

        public void Water(double amountOfWater)
        {
            water += 0.4 * amountOfWater;
        }
    }
}
