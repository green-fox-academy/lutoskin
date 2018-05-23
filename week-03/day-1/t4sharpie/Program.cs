using System;

namespace t4sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
			Sharpie pen = new Sharpie("blue", 1);
			pen.use();
			Console.WriteLine("sharpie ink " + pen.inkAmount);
		}
    }
}
