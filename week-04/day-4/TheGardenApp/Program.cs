using System;

namespace TheGardenApp
{
	class Program
    {
        static void Main(string[] args)
        {
			Garden garden = new Garden();
			garden.plants.Add(new Flower("yellow"));
			garden.plants.Add(new Flower("blue")); 
			garden.plants.Add(new Tree("purple")); 
			garden.plants.Add(new Tree("orange"));

			foreach (var plant in garden.plants)
			{
				plant.IsItThirsty();
			}

			WaterGarden(garden.plants, 40);
		}
    }
}
