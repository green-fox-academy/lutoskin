using System;

namespace t8stringsagain
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(RemoveAllX("spacex"));
		}

		public static string RemoveAllX(string textIn);
		{
			char letter;

            if (textIn == "")
			{
				return null;
			}
            else if (textIn[0] == 'x')
			{
				letter = "";
			}
            else 
			{
				letter = textIn[0];
			}	
			return letter + RemoveAllX(textIn(0,1));
		}

    }
}
// Given a string, compute recursively a new string where all the 'x' chars have been removed.
