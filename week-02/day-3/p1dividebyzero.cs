using System;

namespace w2d2p1
{
    class Program
    {
        static void Main(string[] args)
        {
			// Create a function that takes a number
			// divides ten with it,
			// and prints the result.
			// It should print "fail" if the parameter is 0
			Console.WriteLine(FunctionDivideTen());
		
		}
        
		public static string FunctionDivideTen()
		{
			int a = 10;
            Console.WriteLine("Please give me a number");
            int b = Int32.Parse(Console.ReadLine());
            try
            {
                int c = a / b;
				return c.ToString();
            }
            catch (DivideByZeroException)
            {
				return "fail";
            }
            
		}
    }
}
