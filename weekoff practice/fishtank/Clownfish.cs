namespace fishtank
{
	public class Clownfish : Fish
    {

        private string stripeColour;

		public Clownfish(string name, int weight, string colour, string stripeColour) : base(name, weight, colour)
        {
            this.Name = name;
			this.Weight = weight;
			this.Colour = colour;
			this.stripeColour = stripeColour;
			Gain = 1;
        }

		public override string GetInfo()
        {
			return $"{Name}, weight: {Weight}, colour: {Colour}, stripe colour: {stripeColour} \n";
        }
    }
}