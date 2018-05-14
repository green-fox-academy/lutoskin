using System;

namespace task9_
{
	class Program
	{
		static void Main(string[] args)
		{
			//9 change element
			// - Create an array variable named `s`
			//   with the following content: `[1, 2, 3, 8, 5, 6]`
			// - Change the 8 to 4
			// - Print the fourth element
			int[] s = { 1, 2, 3, 8, 5, 6 };
			int newS = 4;
			s[3] = newS;

			Console.WriteLine(s[3]);

			//10 increment element
			//- Create an array variable named `t`
			//  with the following content: `[1, 2, 3, 4, 5]`
			//- Increment the third element
			//- Print the third element
			int[] t = { 1, 2, 3, 4, 5 };
			t[2] += 1;
			Console.WriteLine(t[2]);

			//11 print elements
			// - Create an array variable named `numbers`
			//   with the following content: `[4, 5, 6, 7]`
			// - Print all the elements of `numbers`
			int[] numbers = { 4, 5, 6, 7 };

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}
    
		}
	}

}