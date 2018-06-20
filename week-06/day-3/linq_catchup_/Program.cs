using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_catchup
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evens = n.Where(num => num % 2 == 0);

            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }
			Console.WriteLine("----");
           
			var avgEvens = evens.Average();

			var pos = n.Where(num => num > 0).Select(num=> Math.Pow(num, 2));
            
			foreach (var num in pos)
			{
                Console.WriteLine(num);
			}

			Console.WriteLine("----");
           
            Console.WriteLine(avgEvens);
        }
    }
}
