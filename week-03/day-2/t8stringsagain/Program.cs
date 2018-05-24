using System;

namespace t8stringsagain
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(RemoveX("sxpacex"));
        }

		public static string RemoveX(string textIn)
		{
			if (textIn == "")
			{
				return null;
			}
			if (textIn[0] == 'x')
			{
				return RemoveX(textIn.Remove(0, 1));
			}
		
			return textIn[0] + RemoveX(textIn.Remove(0, 1));
		}
	}
}
