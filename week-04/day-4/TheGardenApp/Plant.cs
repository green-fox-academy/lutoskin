using System;
using System.Collections.Generic;

namespace TheGardenApp
{
	public class Plant : Garden
    {
        protected string color;
		protected double currentAmountOfWater;
		protected double amountOfWaterNeeded;
		protected double absorption;
		protected int amountOfWaterPoured;
		protected bool thirsty;
		int numberOfThirstyPlants = 0;
                   
        public void WaterGarden(List<Plant> plants, int amountOfWaterPoured)
        {
            Console.WriteLine("Watering garden with " + amountOfWaterPoured);

				if (thirsty == true)
				{
					currentAmountOfWater += amountOfWaterPoured / numberOfThirstyPlants;
				}
			}
		}

		public virtual void CountThirstyPlants()
		{
			if (thirsty == true)
			{
				numberOfThirstyPlants++;
			}
		}

		public virtual void IsItThirsty()
        {			
		}        
    }
}