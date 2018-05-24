using System;

namespace t9stringsagainandagain
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(CompleteString("spacex"));
        }

		public static string CompleteString(string textIn)
		{
			if (textIn == "")
			{
				return null;
			}
			if (textIn.Length == 1)
			{
				return textIn[0].ToString();
			}

			return textIn[0] + "*" + CompleteString(textIn.Remove(0,1));
		}
	}
}
// Given a string, compute recursively a new string where all the
// adjacent chars are now separated by a "*".