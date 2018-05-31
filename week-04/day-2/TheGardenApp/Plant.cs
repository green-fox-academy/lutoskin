using System;
using System.Collections.Generic;

namespace TheGardenApp
{
	public class Plant: Garden
    {
        protected string color;
		protected double currentAmountOfWater;
		protected double amountOfWaterNeeded;
		protected double absorption;
		protected int amountOfWaterPoured;
		protected bool thirsty;
                   

        public void WaterGarden(int amountOfWaterPoured)
        {
            Console.WriteLine("Watering garden with " + amountOfWaterPoured);

            int numberOfThirstyPlants = 0;

            foreach (var plant in plants)
            {
                if (thirsty == true)
                {
                    numberOfThirstyPlants++;
                }
            }

			foreach (var plant in plants)
            {
				if (thirsty == true)
				{
					currentAmountOfWater += amountOfWaterPoured / numberOfThirstyPlants;
				}
			}
		}

		public virtual void IsItThirsty()
        {
			
		}
        
    }
}