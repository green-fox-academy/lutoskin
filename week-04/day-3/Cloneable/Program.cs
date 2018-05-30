using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
			Student john = new Student("John", 20, "male", "BME");
			object clone = john.Clone();
			object clone2 = john.Clone();
			object clone3 = john.Clone();
			Console.WriteLine(clone);
            Console.WriteLine(clone2);
			Console.WriteLine(clone3);
		}
    }
}
