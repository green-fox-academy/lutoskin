using System;
using System.Linq;

namespace ex6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			CountCharactersInString("kismacska");            
        }

		private static void CountCharactersInString(string input)
		{			
			var freq = from c in input
					   group c by c into freqs
					   select new { freqs.Key, Count = freqs.Count() };
			foreach (var f in freq)
            {
                Console.WriteLine(f);
            }
		}      
    }
}
