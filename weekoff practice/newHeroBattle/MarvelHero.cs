using System;
namespace newHeroBattle
{
	public class MarvelHero : Hero
    {
		public MarvelHero(string name) : base(name)
        {
			Motivation = 40;
        }

		public MarvelHero(string name, double motivation) : base(name, motivation)
		{
		}

		public override void Punch(IPunchable other)
        {
			if (other is DCHero)
            {
                base.Punch(other);
            }
        }
	}
}
