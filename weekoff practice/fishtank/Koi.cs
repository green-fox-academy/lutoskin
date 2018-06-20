namespace fishtank
{
	public class Koi : Fish
	{
		public Koi(string name, int weight, string colour) : base(name, weight, colour)
		{
			Name = name;
			Weight = weight;
			Colour = colour;
			Gain = 2;
		}

		public override string GetInfo()
		{
			return $"{Name}, weight: {Weight}, colour: {Colour} \n";
		}
    }
}
