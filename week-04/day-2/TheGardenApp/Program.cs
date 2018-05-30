using System;
using System.Collections.Generic;

namespace TheGardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
			var plants = new List<Garden>();
		    var yellowFlower = new Flower("yellow");
			plants.Add(yellowFlower);
			var blueFlower = new Flower("blue");
			plants.Add(blueFlower);
			var purpleTree = new Tree("purple");
			plants.Add(purpleTree);
			var orangeTree = new Tree("orange");
			plants.Add(orangeTree);

			foreach (var plant in plants)
            {
				Garden.AddPlant();
            }
		}
    }
}
