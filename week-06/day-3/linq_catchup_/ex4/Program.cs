using System;
using System.Linq;

namespace ex4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int[] n = new[] { 3, 9, 2, 8, 6, 5 };

			var sqrGreaterThanTw = n.Where(num => Math.Pow(num, 2) > 20);

			foreach (var num in sqrGreaterThanTw)
			{
                Console.WriteLine(num);
			}
		}
    }
}

