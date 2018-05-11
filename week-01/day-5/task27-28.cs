using System;

namespace task27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
		
            //27 fizzbuzz
			for (int i = 1; i < 101; i++)
			{
				
				if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
                else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
				else {Console.WriteLine(i); }
            }


            //28 draw triangle
            Console.WriteLine("please give me a number");
			string sizeString = Console.ReadLine();
			int size;
			int.TryParse(sizeString, out size);
            Console.WriteLine();

			for (int i = 0; i < size; i++)
			{  
				Console.WriteLine();
                for (int j = 0; j <= i; j++)
     				{Console.Write("*");}
			}

           
		}
    }
}
