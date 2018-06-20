using System;
using System.Collections.Generic;

namespace newcandyshop_practise
{
    public class CandyShop
    {
		private double moneyInStore;
		private int sugarInStore;
		private double percent;
		public static readonly Sweet CANDY = new Candy();
		public static readonly Sweet LOLLIPOP = new Lollipop();


        public CandyShop(int sugarInStore)
        {
			this.sugarInStore = sugarInStore;
        }

		List<Sweet> candyShopInventory = new List<Sweet>();

		public void CreateSweets(Sweet sweet)
		{
			candyShopInventory.Add(sweet);
			sugarInStore -= sweet.SugarNeeded;
		}
           
		public void Sell(Sweet sweet, int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				moneyInStore += sweet.Price * (1 + percent/100);
				candyShopInventory.Remove(sweet);
			}
		}

		internal double Raise(double inputPercent)
		{
			 percent = inputPercent;
			 return percent;
		}

		internal void BuySugar(int amount)
		{
			sugarInStore += amount;
			moneyInStore -= amount / 10;
		}

		internal void PrintInfo()
        {
			List<Sweet> lollipopsOnly = new List<Sweet>();
			foreach (Sweet sweet in candyShopInventory)
			{
                if (sweet is Lollipop)
				{
					lollipopsOnly.Add(sweet);
				}
			}
			Console.WriteLine($"Inventory: {candyShopInventory.Count - lollipopsOnly.Count} candies, {lollipopsOnly.Count} lollipops," +
			                  $"Income: {moneyInStore}$, Sugar: {sugarInStore}gr ");
        }
		// "Invetory: 1 candies, 1 lollipops, Income: 5$, Sugar: 570gr"
	}
}