
using System;
using System.Collections.Generic;
using System.IO;

namespace FavouriteAnimals
{
    public class FavouriteAnimals
    {
        public static void Main(string[] args)
        {
			if (args.Length == 0)
			{
				string favs = File.ReadAllText("favourites.txt");
				Console.WriteLine("C# FavouriteAnimals " + favs);
			}

			else
			{
				for (int i = 0; i < args.Length; i++)
				{
					AddAnimal(args[i]);
				}
			}
            
			// The program's aim is to collect your favourite animals and store them in a text file.
            // There is a given text file called '''favourites.txt''', it will contain the animals
            // If ran from the command line without arguments
            // It should print out the usage:
            // ```C# FavouriteAnimals [animal] [animal]```
            // You can add as many command line arguments as many favourite you have.
            // One animal should be stored only at once
            // Each animal should be written in separate lines
            // The program should only save animals, no need to print them
        }

		private static void AddAnimal(string animal)
        {
			List<string> animals = new List<string>(File.ReadAllLines("favourites.txt"));
			List<string> addAnimals = new List<string> {animal};
			if (!animals.Contains(animal))
			{
				File.AppendAllLines("favourites.txt", addAnimals);
			} 

            Console.WriteLine("léjk");
        }

    }
}