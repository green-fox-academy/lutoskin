using System;

namespace fishtank
{
    public class FishTank
    {
        public static void Main(string[] args)
		{
			// There are 3 kind of fish:
			// - Clownfish, gains 1 gramm when fed and has stripe color.
			// - Tang, gains 1 gramms when fed and can suffer short-term memory loss.
			// - Koi, gains 2 gramms when fed.
			// Each fish has a name, weight, color and has a status and feed method.

			// Create an aquarium and take care of your fish.
			// Create a method on the aquarium that feeds all the fish in the aquarium:
			// increases the weight of every fish with the amount of gramms they gain when fed.
			// Create a method on the aquarium that removes the big fish.
			// A big fish's weight is at least 11 gramms.
			// The aquarium has a status method it should print the status for each fish.

			var aquarium = new Aquarium();
		

			aquarium.Add(new Koi("Nami", 9, "pink"));
			aquarium.Add(new Tang("Dory", 8, "blue", true));
			aquarium.Add(new Tang("Bubbles", 10, "yellow", false));
			aquarium.Add(new Clownfish("Nemo", 5, "orange", "white"));

			Console.WriteLine(aquarium.Status());

			// Nami, weight: 9, color: pink
			// Dory, weight: 8, color: blue, short-term memory loss: true
			// Bubbles, weight: 10, color: yellow, short-term memory loss: false
			// Nemo, weight: 5, color: orange, stripe color: white

            
			aquarium.Feed();
			aquarium.RemoveOversizedFish();

			Console.WriteLine(aquarium.Status());

			// Dory, weight: 9, color: blue, short-term memory loss: true
			// Nemo, weight: 6, color: orange, stripe color: white
		}
	}
}