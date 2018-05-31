using System;
namespace Comparable
{
	public class Domino : IComparable
    {
		private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		public int[] GetValues()
        {
            return Values;
        }
    }
}
