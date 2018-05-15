using System;
using System.Collections.Generic;
using System.Text;

namespace w2d2t8
{
    class Program
    {
        static void Main(string[] args)
        {
			var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }

		public static StringBuilder AppendA(List<string> far)
		{
			StringBuilder appendAFar = new StringBuilder();
			for (int i = 0; i < far.Count; i++)
			{
				appendAFar.Append(far[i] + "a ");
			}
			return appendAFar;
		}
    }
}
