using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7
			int favNum = 19;
            Console.WriteLine("My favourite number is " + favNum + "\n");

			//8
			int a = 123;
			int b = 526;
			(a, b) = (b, a);
			Console.WriteLine(a);
			Console.WriteLine(b);

			//10 boolean
			bool unmarried = true;
			Console.WriteLine(unmarried);

			//11 variablemutation
			int c = 3;
			c += 10;
			Console.WriteLine(c);

			int d = 100;
			d -= 7;
			Console.WriteLine(d);

			int e = 44;
			e *= 2;
			Console.WriteLine(e);

			int f = 125;
			f /= 5;
			Console.WriteLine(f);

			int g = 8;
			g *= g;
			Console.WriteLine(g);

			int h1 = 123;
			int h2 = 345;
			if (h1 > h2)
			{ Console.WriteLine("true"); }
			else { Console.Write("false" + "\n"); }

			int i1 = 350;
			int i2 = 200;
			if (i2 * 2 > i1)
			{ Console.WriteLine(true + "\n"); }
			else { Console.WriteLine(false + "\n"); }

			double j = 1_357_988_018_575_474;
			double j1 = j % 11;
			if (j1 == 0)
            { Console.WriteLine(true + "\n"); }
            else { Console.WriteLine(false + "\n"); }

			int k1 = 10;
			int k2 = 3;
			int k22 = k2 * k2;
			int k222 = k2 * k2 * k2;
			if (k1 > k22)
			{ Console.WriteLine(true + "\n"); }
			else { Console.WriteLine(false + "\n"); }
			if (k1 < k222)
			{ Console.WriteLine(true + "\n"); }
			else { Console.WriteLine(false + "\n"); }
			bool first = true;
			bool second = true;
			if (first && second)
			{ Console.WriteLine("yas so true"); }

			int l = 1521;
			int l1 = l % 3;
			int l2 = l % 5;
			bool x = l1 == 0;
			Console.WriteLine(x);
			bool y = l2 == 0;
			Console.WriteLine(y);

			string m = "Apple";
			m = m + m + m + m;
				Console.WriteLine(m);

        }
    }
}
    