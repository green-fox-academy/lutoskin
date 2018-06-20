using System;
using System.Collections.Generic;

namespace candyshop
{
	public class CandyShop
	{
		private int SugarInventory { get; set; }
		private double Income;
		private double percent = 1;
        
		internal static readonly Sweet CANDY = new Candy();
		internal static readonly Sweet LOLLIPOP = new Lollipop();
		private List<Sweet> itemsOnStock = new List<Sweet>();

		public CandyShop(int SugarInventory)
		{
			this.SugarInventory = SugarInventory;
		}

		public void CreateSweets(Sweet sweet)
		{
			if (sweet.SugarNeeded <= SugarInventory)
			{
				SugarInventory -= sweet.SugarNeeded;
				itemsOnStock.Add(sweet);
			}         
		}

		public void PrintInfo()
		{
			Console.WriteLine($"Inventory: {NumberOfCandiesInStore()} candies, {NumberOfLolliesInStore()} lollipops, Income: {Income:0.##}, Sugar: {SugarInventory}gr");
		}

        private int NumberOfCandiesInStore()
		{
			int counter = 0;
			foreach (Sweet sweetItem in itemsOnStock)
			{
				if (sweetItem is Candy)
				{
					counter++;
				}
			}
			return counter;
		}

		private int NumberOfLolliesInStore()
        {
            int counter = 0;
            foreach (Sweet sweetItem in itemsOnStock)
            {
				if (sweetItem is Lollipop)
                {
                    counter++;
                }
            }
            return counter;
        }

		public void Sell(Sweet sweetIWantToSell, int thisAmount)
		{
			if (sweetIWantToSell is Candy && thisAmount <= NumberOfCandiesInStore())
			{
				Income += thisAmount * CANDY.Price * percent;
				for (int i = 0; i < thisAmount; i++)
				{
					itemsOnStock.Remove(sweetIWantToSell);
				}            
			}
			else if (sweetIWantToSell is Lollipop && thisAmount <= NumberOfLolliesInStore())
            {
				Income += thisAmount * LOLLIPOP.Price * percent;
				for (int i = 0; i < thisAmount; i++)
				{
					itemsOnStock.Remove(sweetIWantToSell);
				}
			}
		}

		public void BuySugar(int sugarBuy)
		{
			if (Income >= sugarBuy / 10)
			{
				Income -= sugarBuy / 10;
				SugarInventory += sugarBuy;
			}
		}

		public void Raise(double raiseWithPercent)
		{
			percent *= 1 + (raiseWithPercent/100);
		}
	}
}

// One lollipop's price is 10$
// And it made from 5gr of sugar
// One candie's price is 20$
// And it made from 10gr of sugar
// we can raise their prices with a given percentage


// It can store sugar and money as income. The constructor should take the amount of sugar in gramms.
// we can create lollipops and candies store them in the CandyShop's storage

// If we create a candy or lollipop the CandyShop's sugar amount gets reduced by the amount needed to create the sweets

// We can raise the prices of all candies and lollipops with a given percentage

// We can sell candy or lollipop with a given number as amount

// If we sell sweets the income will be increased by the price of the sweets and we delete it from the inventory
// We can buy sugar with a given number as amount. The price of 1000gr sugar is 100$
// If we buy sugar we can raise the CandyShop's amount of sugar and reduce the income by the price of it.

// The CandyShop should print properties represented as string in this format:

// "Inventory: 3 candies, 2 lollipops, Income: 100, Sugar: 400gr"