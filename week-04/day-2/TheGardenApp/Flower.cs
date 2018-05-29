using System;
namespace TheGardenApp
{
	public class Flower : Garden
    {      
		public void Info(string color)
		{
            if (water < 5)
            {
                Console.WriteLine("The {0} flower needs water.", color);
            }
			Console.WriteLine("The {0} flower doesn't need water.", color);
		}
      
		public Flower(string color, double water)
		{
			this.color = color;
			water = 0;
		}
        
		public double Water(double amountOfWater)
        {
            return water += 0.75 * amountOfWater;
        }

    }
}
