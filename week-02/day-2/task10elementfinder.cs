using System;
using System.Collections.Generic;

namespace w2d2t10forreal
{
    class Program
    {
        static void Main(string[] args)
        {
			var List = new List<int> { 1, 2, 3, 4, 5 };
			Console.WriteLine(ContainsSeven(List));
			Console.WriteLine(ContainsSevenBool(List));

            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!
            

        }
        
		static string ContainsSeven(List<int> NumbersList)
		{
			if (NumbersList.Contains(7))
			{
                return "Hooray";
			}
			else
			{
			    return "Noooooo";
			}

		}

		static string ContainsSevenBool(List<int> NumbersList)
		{
			bool b = true;
         
            // Assign the result of a boolean expression to b.
			b = (NumbersList.Contains(7));

			// Branch depending on whether b is true or false.
			if (b)
			{
				return "yas";
			}
			else
			{
				return "lol nope";
			}
      
		}
	}
}
