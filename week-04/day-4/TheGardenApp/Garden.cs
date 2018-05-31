using System;
using System.Collections.Generic;

namespace TheGardenApp
{
	public class Garden
	{
		List<Plant> plants = new List<Plant>
		{
				new Flower("yellow"),
				new Flower("blue"),
				new Flower("yellow"),
				new Tree("purple"),
				new Tree("orange")
		};
	}
}

