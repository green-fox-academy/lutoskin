using System;
namespace newcandyshop_practise
{
    public class Sweet
    {
		private int sugarNeeded;
		private double price;

        public int SugarNeeded { get => sugarNeeded; set => sugarNeeded = value; }
        public double Price { get => price; set => price = value; }

		public Sweet(int sugarNeeded, double price)
		{
			this.sugarNeeded = sugarNeeded;
			this.price = price;
		}      
	}
}
