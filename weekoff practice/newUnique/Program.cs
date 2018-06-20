using System;
using System.Collections.Generic;

namespace newUnique
{
    public class MainClass
    {
		public static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            foreach (char c in UniqueCharacters("aaabbbccccdeff"))
            {
                Console.Write("\"" + c + "\" ");
            }
            

        }
        public static List<char> UniqueCharacters(string input)
        {
            List<char> uniqueCharacters = new List<char>();
            char[] allcharacters = input.ToCharArray();

            foreach (char c in allcharacters)
            {
                if (!uniqueCharacters.Contains(c))
                {
                    uniqueCharacters.Add(c);
                }
            }
            return uniqueCharacters;
        }
    }
}
