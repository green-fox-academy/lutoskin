using System;
using System.Collections.Generic;

namespace fishtank
{
    internal class Aquarium
    {
		List<Fish> aquariumInventory = new List<Fish>();

		internal void Add(Fish fish)
		{
			aquariumInventory.Add(fish);
		}
        
		internal string Status()
		{
			string fishStatus = "";

			foreach (Fish fish in aquariumInventory)
			{
				fishStatus += fish.GetInfo();
			}
			return fishStatus;
		}

		internal void Feed()
		{
			foreach (Fish fish in aquariumInventory)
			{
				fish.Weight += fish.Gain;
			}
		}

		internal void RemoveOversizedFish()
		{
			List<Fish> copyOfAquariumInventory = new List<Fish>(aquariumInventory);
			foreach (Fish fish in copyOfAquariumInventory)
			{
				if (fish.Weight >= 11)
				{
					aquariumInventory.Remove(fish);
				}
			}
		}
	}
}
