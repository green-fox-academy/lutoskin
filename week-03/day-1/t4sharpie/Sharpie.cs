using System;
namespace t4sharpie
{
    public class Sharpie
    {
        public string color;
		public float width;
		public float inkAmount;

		public Sharpie(string color, float width)
		{
			this.color = color;
			this.width = width;
			inkAmount = 100;
		}

        public void use()
		{
			inkAmount--;
		}
	
    }
}
