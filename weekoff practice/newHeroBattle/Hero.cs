using System;
namespace newHeroBattle
{
	public class Hero : BaseHero, IPunchable
    {      
		public Hero(string name) : base(name)
		{			
		}

		public Hero(string name, double motivation) : base(name)
		{
			Motivation = motivation;
		}
        
        public double Motivation
		{
			get;
			set;
		}
              
		public override int GetMotivationLevel()
		{
			if (Motivation < 25)
			{
				return 0;
			}
			else if (Motivation >= 25 && Motivation < 40)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}

		public override void Punch(IPunchable other)
		{
			double damage = Motivation / 1.5;
			if (Motivation >= 1)
			{
				other.BePunched(damage);
			}
		}

		public void BePunched(double damage)
        {
			Motivation -= damage / Motivation;
        }

		public override string ToString()
		{
			if (GetMotivationLevel() == 0)
			{
				return $"{GetName()} is not motivated anymore.";
			}
			else if (GetMotivationLevel() == 1)
            {
                return $"{GetName()} is motivated.";
            }
			else           
                return $"{GetName()} is well motivated.";            
		}
	}
}
