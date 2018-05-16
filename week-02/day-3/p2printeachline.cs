using System;
using System.IO;

namespace w2d3p2
{
    class Program
    {
        static void Main(string[] args)
        {
			// Write a program that opens a file called "my-file.txt", then prints
			// each of lines form the file.
			// If the program is unable to read the file (for example it does not exists),
			// then it should print an error message like: "Unable to read file: my-file.txt"
			OpenMyFile("my-file.txt");

        }

		static void OpenMyFile(string something)
		{
			string data = "";
			try
			{
				StreamReader sr = new StreamReader("my-file.txt");
				while (data != null)
                {
                    data = sr.ReadLine();
                    if (data != null)
                    {
                        Console.WriteLine(data);
                    }
                }
			}
			catch (IOException)
			{
				Console.WriteLine("unable"); 
			}   
		}
    }
}
