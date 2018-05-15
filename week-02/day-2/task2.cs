using System;

namespace w2d2t2
{
    class Program
    {
        static void Main(string[] args)
        {
			//2 url fixer

            string url = "https//www.reddit.com/r/nevertellmethebots";
            url = url.Insert(5, ":");
            url = url.Replace("bots", "odds");
            Console.WriteLine(url);
		}
    }
}
