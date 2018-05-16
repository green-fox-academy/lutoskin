using System;
using System.IO;

namespace w2d3p5
{
    class Program
    {
        static void Main(string[] args)
        {
			// Create a function that takes 3 parameters: a path, a word and a number,
            // then it should write to a file.
            // The path parameter should be a string, that describes the location of the file.

            // The word parameter should be a string, that will be written to the file as lines

            // The number parameter should describe how many lines the file should have.

            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.
		
			Console.WriteLine("Type in a word");
            string word = Console.ReadLine();
			Console.WriteLine("Type in a number");
			int numberOfLines = Convert.ToInt32(Console.ReadLine());
			string path = "p5file.txt";
			WriteMultipleLines(word, numberOfLines, path);
			Console.WriteLine(File.ReadAllText(path));

		}

		static void WriteMultipleLines(string word, int numberOfLines, string path)
		{
            try
			{
				StreamWriter sw = new StreamWriter(path);

                for (int i = 0; i < numberOfLines; i++)
                {
					sw.WriteLine(word);
                }
                sw.Dispose();
			}
			catch (IOException)
			{
				Console.WriteLine("");
			}

		}
    }
}
