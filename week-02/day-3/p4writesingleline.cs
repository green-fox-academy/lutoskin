using System;
using System.IO;

namespace w2d3p4
{
    class Program
    {
        static void Main(string[] args)
        {
			// Open a file called "my-file.txt"
			// Write your name in it as a single line
			// If the program is unable to write the file,
			// then it should print an error message like: "Unable to write file: my-file.txt"
			Console.WriteLine(WriteSingleLine("anna"));
			Console.WriteLine(File.ReadAllText("my-file.txt"));
			Console.ReadLine();

		}

		static string WriteSingleLine(string something)
		{
            try
			{
				StreamWriter sw = new StreamWriter("my-file.txt");
				sw.Write(something);
				sw.Dispose();
				return "ok, done";   
			}

			catch (Exception)
			{
				return "unable to";
			}

		}
    }
}
