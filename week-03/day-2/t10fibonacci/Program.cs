using System;

namespace t10fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(7));
        }

        public static int Fibonacci(int number)
		{
			if (number == 0)
			{
				return 0;
			}
			else if (number == 1)
			{
				return 1;
			}
			else 
			{
				return Fibonacci(number - 2) + Fibonacci(number - 1);
			}
		}
	}
}