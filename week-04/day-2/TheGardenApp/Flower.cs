using System;
namespace TheGardenApp
{
	public class Flower : Garden
    {      
        public Flower(string color)
        {
            this.color = color;
            water = 0;
        }
        
		public void Info()
        {
            if (water < 5)
            {
                Console.WriteLine("The {0} flower needs water.", color);
            }
            Console.WriteLine("The {0} flower doesn't need water.", color);
        }
        
		public void Water(double amountOfWater)
        {
            water += 0.75 * amountOfWater;
        }
    }
}
