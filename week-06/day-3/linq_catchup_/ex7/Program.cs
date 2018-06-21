using System;
using System.Linq;

namespace ex7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string[] cities = { "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS" };

			var aiCities = from city in cities
						   where city[0] is 'A' && city[city.Length - 1] is 'I'
						   select city;

			foreach (var city in aiCities)
			{
                Console.WriteLine(city);
			}
		}
    }
}

// Write a LINQ Expression to find the strings which starts with A and ends with I in the following array: