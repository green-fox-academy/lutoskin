using System;
namespace fishtank
{
    public class Fish
    {
		private string name;
        private int weight;
        private string colour;
		private int gain;

		public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Colour { get => colour; set => colour = value; }
		public int Gain { get => gain; set => gain = value; }

		public Fish(string name, int weight, string colour)
		{
			this.name = name;
			this.weight = weight;
			this.colour = colour;
		}
        
		public virtual string GetInfo()
		{
			return "";
		}
	}
}
