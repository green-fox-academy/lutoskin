
using System;

namespace trickyAvg
{
	public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5, 9, 2, 3, 18, 4, -3 };
            int[] numbers2 = new int[] { 2, 8, 13, 3, 9, 28, 49 };
			Console.WriteLine(TrickyAverage(numbers));
			Console.WriteLine(TrickyAverage(numbers2));
        }
        
        public static double TrickyAverage(int[] array)
        {
            double maxmimumValue = -100;
            double minimumValue = 100;

            foreach (int num in array)
            {
                if (Math.Abs(num) % 2 == 1)
                {
                    if (num < minimumValue) minimumValue = num;
                }

                if (num % 2 == 0)
                {
                    if (num > maxmimumValue) maxmimumValue = num;
                }
            }
            double trickyAverage = (minimumValue + maxmimumValue) / 2;

			return trickyAverage;
        }
    }
}