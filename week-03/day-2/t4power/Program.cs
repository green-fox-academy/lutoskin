using System;

namespace t4power
{
    class Program
    {
		static void Main()
        {
            Console.WriteLine(Power(2,3));
        }

        public static int Power(int baseNumber, int power)
		{
			if (power == 0)
			{
				return 1;
			}

			else
			{
				return baseNumber * Power(baseNumber, power - 1);
			}	
		}
    }
}
