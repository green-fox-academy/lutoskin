using System;

namespace t7strings
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(ChangeXToY("spacex"));
        }

		public static string ChangeXToY(string textIn)
		{
			char letter;

			if (textIn == "")
			{
				return null;
			}

			else if (textIn[0] == 'x')
			{
				letter = 'y';
			}

			else 
			{
				letter = textIn[0];
			}
			return letter + ChangeXToY(textIn.Remove(0,1));
		}
    }
}
// Given a string, compute recursively (no loops) a new string where all the
// lowercase 'x' chars have been changed to 'y' chars.