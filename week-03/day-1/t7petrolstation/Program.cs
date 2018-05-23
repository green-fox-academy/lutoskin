using System;

namespace t7petrolstation
{
    class Program
    {
        static void Main(string[] args)
        {
			Car car = new Car(0, 100);
			Station station = new Station(1000);
			Console.WriteLine(car.gasAmount);

			station.Refill(car);
			Console.WriteLine(car.capacity);
			Console.WriteLine(car.gasAmount);
			Console.WriteLine(station.gasAmount);
		}
    }
}
