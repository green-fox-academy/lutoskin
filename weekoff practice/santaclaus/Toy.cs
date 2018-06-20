using System;
namespace santaclaus
{
    public class Toy
    {
		private string toyType;
        private string colour;
		private int price;
        private int size;
		private string owner;
              
		public int Price { get => price; set => price = value; }
		public string Owner { get => owner; set => owner = value; }

		public Toy(string toyType, string colour)
		{
			this.toyType = toyType;
			this.colour = colour;
			price = 25;
			owner = null;
		}

		public Toy(string toyType, string colour, int size)
		{   
			this.toyType = toyType;
            this.colour = colour;
			this.size = size;
			price = 10;
			owner = null;
		}

		public Toy(string toyType, int size)
        {
            this.toyType = toyType;
            this.size = size;
			price = 15;
			owner = null;
        }
	}
}
