using System;
using System.Collections.Generic;
using System.IO;

namespace WorstSong
{
    public class WorstSong
    {
        public static void Main(string[] args)
        {
			List<int> worstYears = new List<int>(GetWorstMusicalYears(GetYearsMusically(GetYears(ReadLinesFromFile("worstsongs.csv")))));
			foreach (int currentYear in worstYears)
			{
				Console.WriteLine(currentYear);
			}
		}

		private static List<string> ReadLinesFromFile(string fileName)
		{
			List<string> lines = new List<string>();
			foreach (string line in File.ReadAllLines(fileName))
			{
				lines.Add(line);
			}
			return lines;
		}

		private static List<int> GetYears(List<string> inputLines)
		{
			List<int> yrs = new List<int>();
			foreach (string line in inputLines)
			{
				string[] partsOfLine = line.Split(';');
 				string year = partsOfLine[partsOfLine.Length-1];
				yrs.Add(Int32.Parse(year));
			}
			return yrs;
		}

		private static Dictionary<int, int> GetYearsMusically(List<int> yrs)
		{
			Dictionary<int, int> yearlyBadSongCounter = new Dictionary<int, int>();
			foreach (int currentYear in yrs)
			{
				if(!yearlyBadSongCounter.ContainsKey(currentYear))
				{
					yearlyBadSongCounter[currentYear] = 1;
				}
				else
				{
					yearlyBadSongCounter[currentYear] += 1;
				}
			}
			return yearlyBadSongCounter;
		}

		private static List<int> GetWorstMusicalYears(Dictionary<int, int> yearlyBadSongCounter)
		{
			List<int> worstMusicalYears = new List<int>();

			KeyValuePair<int, int> toCompare = new KeyValuePair<int, int>(0, 0);
			foreach (KeyValuePair<int, int> currentYear in yearlyBadSongCounter)
			{
                if (currentYear.Value > toCompare.Value)
				{
					toCompare = currentYear;
				}
			}
			foreach (KeyValuePair<int, int> currentYear in yearlyBadSongCounter)
			{
                if (currentYear.Value == toCompare.Value)
				{
					worstMusicalYears.Add(currentYear.Key);
				}
			}
			return worstMusicalYears;
		}
	}
}

// The 100worst.csv file contains the 100 worst singles over 25 years.
// Your task is to check which year produced the most.
// So create the necessary method(s).
// And print out the sentence below with the proper year.
//  `The year when the most worst songs came out is <year>.`
