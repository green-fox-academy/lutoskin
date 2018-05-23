using System;
namespace t5counter
{
    public class Counter
    {
		public int number;

		public Counter()
		{
			number = 0;
		}

		public void Add(int addNumber)
		{
			number += addNumber;
            Console.WriteLine("addnumber");
		}

        public void Add()
		{
			number++;
            Console.WriteLine("add");
		}
        
        public string Get()
		{
			string numberString = Convert.ToString(number);
			return numberString;
		}

        public void Reset()
		{
			number = 0;
            Console.WriteLine("reset");
		}
    }
}
