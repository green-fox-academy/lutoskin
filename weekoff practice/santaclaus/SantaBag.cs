using System;
using System.Collections.Generic;

namespace santaclaus
{
    public class SantaBag
    {
		public static List<Toy> santaBagInventory = new List<Toy>();  
        
		public int GetNumberOfItems()
		{
			return santaBagInventory.Count;
		}
        
		public void Add(Toy toy)
		{
			if (toy != null)
			{
				santaBagInventory.Add(toy);
			}
		}
	}
}