using System;
namespace t7petrolstation
{
	public class Station
	{
		public int gasAmount;

		public Station(int gasAmount)
		{
			this.gasAmount = gasAmount;
		}

		public void Refill(Car car)
		{
			gasAmount -= car.capacity;
			car.gasAmount += car.capacity;
            Console.WriteLine("refill");
		}
    }
}
