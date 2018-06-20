using System;

namespace santaclaus
{
    public class SantaFactory
    {
		private int balance;
        
		public SantaFactory()
        {
			balance = 200;
        }

		public Toy Produce(string toyType, string colour)
		{
			Toy doll = new Toy(toyType, colour);
			if (balance >= doll.Price)
			{
				balance -= doll.Price;
                return doll;
			}
			else
			{
				return null;
			}
		}

		public Toy Produce(string toyType, string colour, int size)
        {
			Toy ball = new Toy(toyType, colour, size);
			if (balance >= ball.Price)
            {
                balance -= ball.Price;
                return ball;
            }
            else
            {
                return null;
            }
        }

		public Toy Produce(string toyType, int size)
        {
			Toy rope = new Toy(toyType, size);
			if (balance >= rope.Price)
            {
                balance -= rope.Price;
                return rope;
            }
            else
            {
                return null;
            }
        }

		internal int GetBalance()
		{
			return balance;
		}
	}	
}