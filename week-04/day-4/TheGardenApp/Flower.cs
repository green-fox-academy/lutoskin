using System;
namespace TheGardenApp
{
	public class Flower : Plant
    {      
        public Flower(string color)
        {
            this.color = color;
			currentAmountOfWater = 0;
			absorption = 0.75;
			amountOfWaterNeeded = 5;
         
            if (currentAmountOfWater < amountOfWaterNeeded)
            {
                thirsty = true;
            }
		}

		public override void IsItThirsty()
        {
			if (thirsty == true)
            {
                Console.WriteLine("The {0} flower needs water.", color);
            }
            Console.WriteLine("The {0} flower doesn't need water.", color);
        }      
    }
}
