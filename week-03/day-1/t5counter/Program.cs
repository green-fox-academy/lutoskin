using System;

namespace t5counter
{
    class Program
    {
        static void Main(string[] args)
        {
			Counter counter = new Counter();

			counter.Add();
			counter.Add(2);
			counter.Reset();
			Console.WriteLine(counter.Get());
		}
    }
}
