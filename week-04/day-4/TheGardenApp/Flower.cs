using System;
namespace TheGardenApp
{
	public class Flower : Plant
    {      
        public Flower(string color)
        {
            this.color = color;
			currentAmountOfWater = 0;
			amountOfWaterNeeded = 5;
			absorption = 0.75;
         
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
			else
			{
				Console.WriteLine("The {0} flower doesn't need water.", color);	
			}
        }      
    }
}
