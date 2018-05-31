using System;
namespace TheGardenApp
{
	public class Tree : Plant
    {
		public Tree(string color)
        {
            this.color = color;
			currentAmountOfWater = 0;
			amountOfWaterNeeded = 10;
			absorption = 0.4;

            if (currentAmountOfWater < amountOfWaterNeeded)
            {
                thirsty = true;
            }
        }

        public override void IsItThirsty()
        {
			if (thirsty == true)
            {
                Console.WriteLine("The {0} tree needs water.", color);
            }
            Console.WriteLine("The {0} tree doesn't need water.", color);
        }
    }
}
