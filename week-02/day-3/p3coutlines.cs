using System;
using System.IO;
using System.Linq;

namespace w2d3p3forreal
{
    class Program
    {
        static void Main(string[] args)
        {
			// Write a function that takes a filename as string,
			// then returns the number of lines the file contains.
			// It should return zero if it can't open the file, and
			// should not raise any error.      

			Console.WriteLine(CountLines("file.txt"));
		}

		static int CountLines(string filePath)
		{
            try
			{
				return File.ReadLines(filePath).Count();            
			}
			catch (IOException)
			{
				return 0;
			}
		}
    }
}
