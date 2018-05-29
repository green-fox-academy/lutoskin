using System;
using System.Collections.Generic;

namespace TheGardenApp
{
    public class Garden
    {
		protected double water;
		protected string color;
		int amountOfWater;
		private List<Garden> thirstyPlants = new List<Garden>();

		public void AddFlower(Flower addFlower)
		{
			if (water <= 0)
			{
				thirstyPlants.Add(addFlower);
			}
		}

		public void AddTree(Tree addTree)
        {
            if (water <= 0)
            {
				thirstyPlants.Add(addTree);
            }
        }

		public void Water(int amountOfWater)
		{
			Console.WriteLine("Watering with " + amountOfWater);
		}
    }
}