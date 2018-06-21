using System;
using System.Linq;

namespace ex5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            
			var freq = from num in n
					   group num by num into freqs
					   select new { freqs.Key, Count = freqs.Count() };

			var f = n.GroupBy(num => new { num }).Select(frequies => new {frequies.Key, Count = frequies.Count()});


			foreach (var freqsKey in freq)
			{
				Console.WriteLine(freqsKey);
			}

            Console.WriteLine("--");

			foreach (var freqsKey in f)
            {
                Console.WriteLine(freqsKey);
            }
		}
    }
}
//Write a LINQ Expression to find the frequency of numbers in the following array