using System;

namespace t5bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(BunniesEars(18));
        }

        public static int BunniesEars(int numberOfBunnies)
		{
			if (numberOfBunnies == 1)
			{
				return 2;
			}

			else
			{
				return 2 + BunniesEars(numberOfBunnies - 1);
			}
		}
    }
}
