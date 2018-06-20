namespace fishtank
{
	public class Tang : Fish
    {
        private bool status;

		public Tang(string name, int weight, string colour, bool status) : base(name, weight, colour)
        {
            this.Name = name;
            this.Weight = weight;
			this.Colour = colour;
			this.status = status;
			Gain = 1;
        }

		public override string GetInfo()
        {
			return $"{Name}, weight: {Weight}, colour: {Colour}, status: {status} \n";
        }
    }
}