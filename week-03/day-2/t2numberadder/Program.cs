using System;

namespace t2numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
			int n;
            Console.WriteLine("Give me a number");
			n = Int32.Parse(Console.ReadLine());
			Console.WriteLine(NumberAdder(n));
        }

		public static int NumberAdder(int n)
		{
			if (n == 1)
			{
				return + 1;
			}

			else
			{
				return n + NumberAdder(n - 1);
			}
		}
    }
}
