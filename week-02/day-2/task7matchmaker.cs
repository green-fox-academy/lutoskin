using System;
using System.Collections.Generic;
using System.Text;

namespace w2d2t7
{
    class Program
    {
        static void Main(string[] args)
        {
			var girls = new List<string> {"Eve", "Ashley", "Bözsi", "Kat", "Jane"};
            var boys = new List<string> {"Joe", "Fred", "Béla", "Todd", "Neef", "Jeff"};

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));
            
        }

		public static StringBuilder MakingMatches(List<string> girls, List<string> boys)
		{
			StringBuilder girlsAndBoys = new StringBuilder();
			for (int i = 0; i < girls.Count; i++)
			{
				girlsAndBoys.Append(girls[i] + " ")
				            .Append(boys[i] + " \n");
                
			}
			girlsAndBoys.Append(boys[5]);
			return girlsAndBoys;
		}
	}
}
