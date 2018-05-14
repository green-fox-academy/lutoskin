using System;

namespace week2
{
	class Program
	{
		static void Main(string[] args)
		{
			//1 doubling
			Console.WriteLine(Doubling());

			//2 greeter function
			string al = "Greenfox";
			Console.WriteLine(Greet(al));

			//3 append a
			string am = "kuty";
			Console.WriteLine(AppendA(am));

			//4 summing
			Console.WriteLine("Give me a number");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine(Sum(number));

			//5 factorial
			Console.WriteLine("Give me a number");
			int numberFact = int.Parse(Console.ReadLine());
			Console.WriteLine(Factorio(numberFact));

			//6 third
			int[] q = { 4, 5, 6, 7 };
			Console.WriteLine(q[2]);

			//7 compare length
			// - Create an array variable named `p1`
			//   with the following content: `[1, 2, 3]`
			// - Create an array variable named `p2`
			//   with the following content: `[4, 5]`
			// - Print if `p2` has more elements than `p1`

			int[] p1 = { 1, 2, 3 };
			int[] p2 = { 4, 5 };
			if (p2.Length > p1.Length)
			{
				Console.WriteLine("p2 has more elements than p1");
			}
			else
			{
				Console.WriteLine("p2 does not have more elements than p1");
			}

			//8 sum elements
			// - Create an array variable named `r`
			//   with the following content: `[54, 23, 66, 12]`
			// - Print the sum of the second and the third element
			int[] r = { 54, 23, 66, 12 };

			Console.WriteLine(r[1] + r[2]);
            
		}

		//1
        
		public static int Doubling()
		{
			int baseNum = 123;
			return (baseNum * 2);
		}

		//2

		public static string Greet(string al)
		{

			return "Hello dear " + al;
		}

		//3
		// - Create a string variable named `am` and assign the value `kuty` to it
		// - Write a function called `appendA` that gets a string as an input,
		//   appends an 'a' character to its end and returns with a string
		// - Print the result of `appendAFunc(am)`

		public static string AppendA(string am)
		{
			return am + "a";
		}

		//4
		// - Write a function called `sum` that sum all the numbers
		//   until the given parameter and returns with an integer
		public static int Sum(int number)
		{
			int sumOfNumber = 0;
			for (int i = 1; i <= number; i++)
			{
				sumOfNumber += i;
			}
			return sumOfNumber;
		}

		//5
		// - Create a function called `factorio`
		//   that returns it's input's factorial
		public static int Factorio(int numberFact)
		{
			int factOfNumber = 1;
			for (int i = 1; i <= numberFact; i++)
			{
				factOfNumber *= i;
			}
			return factOfNumber;
		}
      
    }
}
