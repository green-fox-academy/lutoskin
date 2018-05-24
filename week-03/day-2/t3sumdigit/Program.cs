using System;

namespace t3sumdigit
{
    class Program
    {
		public static void Main() 
		{
            Console.WriteLine(SumDigit(2456));
        }

        public static int SumDigit(int n)
		{
			if (n < 10)
			{
				return n;
			}
            
			else
			{
				return n%10	+ SumDigit(n/10);
			}
		}
    }
}
