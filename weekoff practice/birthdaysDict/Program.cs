using System;
using System.Collections.Generic;
using System.IO;

namespace birthdaysDict
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			ReadLinesFromFile("birthdays.csv");

			List<Person> people = GetPeople(ReadLinesFromFile("birthdays.csv"));
			foreach (Person currentPerson in people)
			{
				Console.WriteLine(currentPerson);
			}

			foreach (string city in GetRomiCities())
			{
				Console.WriteLine();
			}
		}

		private static List<int> MostProductiveYrs(Dictionary<int, int> birthYearFreq)
		{
			List<int> mostChildrensYear = new List<int>();

			KeyValuePair<int, int> toCompare = new KeyValuePair<int, int>(0, 0);
			foreach (KeyValuePair<int, int> currentBirthFreq in birthYearFreq)
			{
				if (currentBirthFreq.Value > toCompare.Value)
				{
					toCompare = currentBirthFreq;
				}
			}
			foreach (KeyValuePair<int, int> currentBirthFreq in birthYearFreq)
			{
				if (currentBirthFreq.Value == toCompare.Value)
				{
					mostChildrensYear.Add(currentBirthFreq.Key);
				}
			}
			return mostChildrensYear;
		}

		private static List<string> ReadLinesFromFile(string fileName)
		{
			List<string> result = new List<string>();
			try
			{
				foreach (string line in File.ReadAllLines(fileName))
				{
					result.Add(line);
				}
			}
			catch (FileNotFoundException fne)
			{
				Console.WriteLine(fne.Message);
				Console.WriteLine($"nagyi, nincs ilyen {fileName} fájl");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("nagyi, vegyél új gépet");
			}
			return result;
		}

		private static List<int> GetYears(List<string> inputLines)
		{
			List<int> yrs = new List<int>();
			foreach (string line in inputLines)
			{
				string[] partsOfLine = line.Split(';');
				try
				{
					string year = partsOfLine[1].Split('-')[0];
					yrs.Add(Int32.Parse(year));
				}
				catch (IndexOutOfRangeException)
				{
					Console.WriteLine();
				}
				catch (FormatException)
				{

				}
			}
			return yrs;
		}

		private static List<Person> GetPeople(List<string> inputLines)
		{
			List<Person> people = new List<Person>();
			foreach (string line in inputLines)
			{
				string[] partsOfLine = line.Split(';');
				try
				{
					people.Add(new Person(partsOfLine[0], partsOfLine[1], partsOfLine[2]));
				}
				catch (IndexOutOfRangeException)
				{
					Console.WriteLine();
				}
				catch (FormatException)
				{

				}
			}
			return people;
		}

		private static Dictionary<int, int> MostProductiveYear(List<int> birthYrs)
		{
			Dictionary<int, int> childrenCounter = new Dictionary<int, int>();
			foreach (int currentBirthYear in birthYrs)
			{
				if (!childrenCounter.ContainsKey(currentBirthYear))
				{
					childrenCounter[currentBirthYear] = 1;
				}
				else
				{
					childrenCounter[currentBirthYear] += 1;
				}
			}
			return childrenCounter;
		}


		private static Dictionary<string, int> MostPopulatedCity(List<Person> people)
		{
			Dictionary<string, int> cityCounter = new Dictionary<string, int>();
			foreach (Person currentPerson in people)
			{
				if (!cityCounter.ContainsKey(currentPerson.Place))
				{
					cityCounter[currentPerson.Place] = 1;
				}
				else
				{
					cityCounter[currentPerson.Place] += 1;
				}
			}
			return cityCounter;
		}


		private static List<string> GetRomiCities(Dictionary<string, int> cityFreq)
		{
			List<string> romiCities = new List<string>();

			foreach (KeyValuePair<string, int> currentCityFreq in cityFreq)
			{
				if (currentCityFreq.Value % 2 == 0)
				{
					romiCities.Add(currentCityFreq.Key);
				}
			}
			return romiCities;
		}
	}
}
// Create a function that
// - takes a filename as a parameter,
// - reads a csv file which rows contains data in the following format: <person name>;<birthdate in YYYY-MM-DD format>;<city name>
// - returns the year when the most births happend.

// You can find such a csv file in this directory: births.csv
// If you pass births.csv to your function, the result should be 2006.
