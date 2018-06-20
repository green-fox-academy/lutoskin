using System;
namespace newHeroBattle
{
	public class DCHero : Hero
    {
		public DCHero(string name) : base(name)
        {
			Motivation = 45;
        }

		public DCHero(string name, double motivation) : base(name, motivation)
		{
		}

		public override void Punch(IPunchable other)
		{
			if (other is MarvelHero)
			{
				base.Punch(other);
			}
		}
	}
}
